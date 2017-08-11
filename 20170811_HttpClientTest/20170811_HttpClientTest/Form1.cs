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

namespace _20170811_HttpClientTest
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient mHttpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => DotNetHttpClientRESTFulAsync(textBox_url.Text, textBox_json.Text));
        }

        /// <summary>
        /// HttpClient .Net Current
        /// </summary>
        private async Task<string> DotNetHttpClientRESTFulAsync(string url, string json)
        {
            string rt = string.Empty;

            //POST
            //Start
            //var mDic = new Dictionary<string, string>();
            //mDic.Add("JSON", json);
            //var content = new FormUrlEncodedContent(mDic);

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("JSON", json),
            });

            //mHttpClient.BaseAddress = new Uri("http://192.168.122.145:3000");
            var response = await mHttpClient.PostAsync("http://192.168.122.145:3000/egs-router/", content);

            //MessageBox.Show(response.EnsureSuccessStatusCode().ToString());

            var responseString = await response.Content.ReadAsStringAsync();
            //END

            richTextBox1.Text = responseString;

            return rt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
