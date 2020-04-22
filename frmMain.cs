using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Text;

namespace x509_verifier_rest_client
{
    public partial class frmMain : Form
    {
        String pdf_verifier_url = "https://signatureverifier.d-logic.com/pdf-sgn-verifier.php";
        String x509_verifier_url = "https://signatureverifier.d-logic.com/x509-verifier.php";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = Text + " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnPdfVerify_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Please select the PDF file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = JsonSerializer.Serialize(new JsonQuery());
                    // "{\"operation\":\"verify\",\"user_id\":0,\"security_token\":\"\"}";

                    webDisplay.Visible = false;
                    webDisplay.DocumentText = "";
                    webDisplay.Refresh();
                    tbStatus.Text = "";
                    tbStatus.Refresh();

                    Cursor.Current = Cursors.WaitCursor;

                    var client = new RestClient(pdf_verifier_url);
                    var request = new RestRequest(Method.POST);
                    request.AddFile("file", dialog.FileName, "file");
                    request.AddParameter("query", jsonString);
                    request.AddHeader("content-type", "multipart/form-data");
                    IRestResponse response = client.Execute(request);

                    var options = new JsonSerializerOptions
                    {
                        IgnoreNullValues = true
                    };

                    ResponseContent json_response = JsonSerializer.Deserialize<ResponseContent>(response.Content, options);
                    tbStatus.Text = json_response.status;
                    webDisplay.Document.Write(json_response.msg);
                    webDisplay.Visible = true;
                    webDisplay.Refresh();
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnX509Verify_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PEM certificate files (*.cer;*.crt;*.pem)|*.cer;*.crt;*.pem|All files (*.*)|*.*";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Please select the certificate file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = JsonSerializer.Serialize(new JsonQuery());
                    // "{\"operation\":\"verify\",\"user_id\":0,\"security_token\":\"\"}";

                    webDisplay.Visible = false;
                    webDisplay.DocumentText = "";
                    webDisplay.Refresh();
                    tbStatus.Text = "";
                    tbStatus.Refresh();

                    Cursor.Current = Cursors.WaitCursor;

                    var client = new RestClient(x509_verifier_url);
                    var request = new RestRequest(Method.POST);
                    request.AddFile("file", dialog.FileName, "file");
                    request.AddParameter("query", jsonString);
                    request.AddHeader("content-type", "multipart/form-data");
                    IRestResponse response = client.Execute(request);

                    var options = new JsonSerializerOptions
                    {
                        IgnoreNullValues = true
                    };

                    ResponseContent json_response = JsonSerializer.Deserialize<ResponseContent>(response.Content, options);
                    tbStatus.Text = json_response.status;
                    webDisplay.Document.Write(json_response.msg);
                    webDisplay.Visible = true;
                    webDisplay.Refresh();
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }

    public class JsonQuery
    {
        public JsonQuery()
        {
            operation = "verify";
            user_id = 0;
            security_token = "";
        }
        public String operation { get; set; }
        public UInt64 user_id { get; set; }
        public String security_token { get; set; }
    }

    public class ResponseContent
    {
        public ResponseContent()
        {
            status = "no status";
            msg = "empty";
        }
        public String status { get; set; }
        public String msg { get; set; }
    }
}
