using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.Web;
using Newtonsoft.Json;
using RestSharp;
using System.IO;

namespace BitlyConverterAutomation
{
    public partial class BitlyConverter : Form
    {
        public BitlyConverter()
        {
            InitializeComponent();
        }

        public class BulkAction
        {
            public virtual string LongURL { get; set; }
            public virtual string SecondHalfName { get; set; }
        }

        private void ConvertToBitly_Click(object sender, EventArgs e)
        {
            ShortenedURLsTextbox.Text = "";
            QRCodesTextbox.Text = "";
            IList<string> LongURLsList = LongURLsTextbox.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            IList<string> SecondHalfNamesList = SecondHalfNamesTextbox.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //!string.IsNullOrEmpty(LongURLsText) ? LongURLsText.Cast<object>().Select(o => o.ToString()).ToList() : new List<string>();

            IList<BulkAction> BulkActions = new List<BulkAction>();

            for (int i = 0; i < LongURLsList.Count; i++)
            {
                BulkActions.Add(new BulkAction
                {
                    LongURL = LongURLsList[i],
                    SecondHalfName = i < SecondHalfNamesList.Count ? SecondHalfNamesList[i] : ""
                });
            }

            ResponseProgress.Visible = true;
            ResponseProgress.Maximum = BulkActions.Count;
            ResponseProgress.Step = 1;
            int listItem = 1;
            string LeeAccessToken = "059d1559e67ba1526e8c99116d3fd5a5572ca3cd";
            string BitlyApi = "https://api-ssl.bitly.com/v4/";
            var client = new RestClient(BitlyApi);
            var request = new RestRequest(Method.POST);
            IRestResponse response;

            foreach (BulkAction BulkAction in BulkActions)
            {
                try
                {
                    ResponseObject ResponseObject;
                    #region Shortening URLs
                    BitlyApi = "https://api-ssl.bitly.com/v4/shorten";

                    client = new RestClient(BitlyApi);
                    request = new RestRequest(Method.POST);
                    request.AddHeader("Authorization", "Bearer " + LeeAccessToken);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddJsonBody(JsonConvert.SerializeObject(
                        new
                        {
                            long_url = BulkAction.LongURL,
                            domain = "go.shell.com"
                        }));
                    response = client.Execute(request);
                    ResponseObject = JsonConvert.DeserializeObject<ResponseObject>(response.Content);
                    #endregion

                    if (!string.IsNullOrEmpty(BulkAction.SecondHalfName))
                    {
                        #region Custom Bitlinks
                        BitlyApi = "https://api-ssl.bitly.com/v4/custom_bitlinks";

                        client = new RestClient(BitlyApi);
                        request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", "Bearer " + LeeAccessToken);
                        request.AddHeader("Content-Type", "application/json");
                        request.AddJsonBody(JsonConvert.SerializeObject(
                            new
                            {
                                custom_bitlink = "go.shell.com/" + BulkAction.SecondHalfName,
                                bitlink_id = ResponseObject.id//link.Replace("https://", "")
                            }));
                        response = client.Execute(request);
                        ResponseObject = JsonConvert.DeserializeObject<ResponseObject>(response.Content);
                        PrintResponse(
                            ShortenedURLsTextbox,
                            ResponseObject.custom_bitlink != null ? "https://" + ResponseObject.custom_bitlink : ResponseObject.description,
                            ResponseObject.custom_bitlink != null ? true : false);
                        #endregion
                    }
                    else
                    {
                        PrintResponse(
                        ShortenedURLsTextbox,
                        ResponseObject.id != null ? ResponseObject.link : ResponseObject.description,
                        ResponseObject.id != null ? true : false);
                    }

                    #region QR Code
                    BitlyApi = "https://api-ssl.bitly.com/v4/bitlinks/" + ResponseObject.id + "/qr";
                    client = new RestClient(BitlyApi);
                    request = new RestRequest(Method.GET);
                    request.AddHeader("Authorization", "Bearer " + LeeAccessToken);
                    request.AddHeader("Content-Type", "application/json");

                    response = client.Execute(request);
                    ResponseObject = JsonConvert.DeserializeObject<ResponseObject>(response.Content);

                    PrintResponse(
                        QRCodesTextbox,
                        ResponseObject.id != null ? ResponseObject.qr_code : ResponseObject.description,
                        ResponseObject.id != null ? true : false);

                    string QRCodeSavePath = Path.Combine(QRCodeFilePathTextbox.Text, listItem + ".png");
                    if (File.Exists(QRCodeSavePath))
                    {
                        File.Delete(QRCodeSavePath);
                    }
                    File.WriteAllBytes(QRCodeSavePath,
                        Convert.FromBase64String(ResponseObject.qr_code.Split(',')[1]));

                    #endregion

                    ResponseProgress.Value = listItem++;
                }
                catch (Exception ex)
                {
                    PrintResponse(QRCodesTextbox, "Exception Caught!\nMessage : " + ex.Message, false);
                }
            }

            //ResponseProgress.Visible = false;
        }


        private void PrintResponse(TextBox Response, string Message, bool IsSuccess)
        {
            if (IsSuccess)
            {
                Response.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);

            }
            else
            {
                Response.ForeColor = Color.Red;
                Response.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            }

            Response.Visible = true;
            Response.Text += Message + "\r\n";
        }
    }

    public class ResponseObject
    {
        private string _bitlinkId;
        public virtual string custom_bitlink { get; set; }
        public bitlink bitlink { get; set; }
        public virtual string id
        {
            get { return _bitlinkId ?? bitlink.id; }
            set { _bitlinkId = value; }
        }
        public virtual string link { get; set; }
        public virtual string qr_code { get; set; }
        public virtual string message { get; set; }
        public virtual string description { get; set; }
        public virtual string resource { get; set; }
        public virtual Error[] errors { get; set; }
        public virtual object noData { get; set; }

    }

    public class bitlink
    {
        public virtual string id { get; set; }
    }

    public class Error
    {
        public virtual string field { get; set; }
        public virtual string error_code { get; set; }
        public virtual string message { get; set; }
    }
}
