using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ConnectAPI
{
    public partial class Form1 : Form
    {
        JArray jsonData = new JArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                tb_filePath.Text = filePath;
            }
        }

        private void btn_read_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_filePath.Text))
            {
                MessageBox.Show("Please select CSV file", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jsonData.Clear();
            string CSVFilePathName = String.Format(@"{0}", tb_filePath.Text);
            string[] Lines = File.ReadAllLines(CSVFilePathName);
            int total = Lines.Length;

            DataTable dt = new DataTable();
            dt.Columns.Add("Biomatric ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Auth Type");
            dt.Columns.Add("TA ID");

            for (int i = 0; i < total; i++)
            {
                if (i != 0)
                {
                    var row = Lines[i].Split(',');

                    var bioId = row[0];
                    var timeStamp = row[1];
                    var authType = row[2];
                    var taId = row[3];

                    //Create object for post API
                    dynamic obj = new JObject();
                    obj.biomatric_id = bioId;
                    obj.time_stamp = timeStamp;
                    obj.auth_type = authType;
                    obj.ta_id = taId;

                    jsonData.Add(obj);

                    //New data row for display gridview
                    DataRow dr = dt.NewRow();
                    dr[0] = bioId;
                    dr[1] = timeStamp;
                    dr[2] = authType;
                    dr[3] = taId;
                    dt.Rows.Add(dr);
                }
            }
            dataGridView1.DataSource = dt;
            lb_total.Text = String.Format("จำนวน {0} รายการ", (total - 1).ToString());
            tb_json.Text = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
            Console.WriteLine(jsonData);
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to post data to API", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var client = new RestClient();
                var request = new RestRequest("api_url_here", Method.Post);
                request.AddHeader("Accept", "application/json");
                //request.AddHeader("x-ibm-client-id", "REPLACE_THIS_KEY");
                request.AddBody("data", JsonConvert.SerializeObject(jsonData));

                //ใช้ในกรณีอินเทอร์เน็ตวิ่งผ่าน proxy
                //client.Proxy = new WebProxy("xxxxx.xxxx.xx.xx", port number);
                RestResponse response = client.Execute(request);

                //Response 200 OK
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    MessageBox.Show("Post to API Successfully !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btn_clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearData();
        }

        public void clearData()
        {
            tb_filePath.Text = string.Empty;
            tb_json.Text = string.Empty;
            dataGridView1.DataSource = null;
            lb_total.Text = string.Format("จำนวน 0 รายการ");
            jsonData.Clear();
        }

        private void lb_copy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(JsonConvert.SerializeObject(jsonData, Formatting.Indented));
            MessageBox.Show("Copy Json to clipboard !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
