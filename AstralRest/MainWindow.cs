using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AstralRest.Models;
using Newtonsoft.Json;

namespace AstralRest
{
    public partial class MainWindow : Form
    {
        HttpClient client;
        public string lastCookie = "XXXX";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            new Guna.UI2.WinForms.Guna2DragControl
            {
                TargetControl = this,
                UseTransparentDrag = false
            };

            new Guna.UI2.WinForms.Guna2Elipse
            {
                TargetControl = this,
                BorderRadius = 7
            };

            guna2TextBox1.Text = Properties.Settings.Default.Cookie;
        }

        private void AddControl(string title, string content)
        {
            var card = new LookupCard(title, content)
            {
                Dock = DockStyle.Top
            };

            MainPanel.Controls.Add(card);
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (lastCookie != guna2TextBox1.Text)
            {
                CookieContainer cookies = new CookieContainer();
                cookies.Add(new Cookie
                {
                    Domain = "205.209.120.124",
                    Name = "PHPSESSID",
                    Value = guna2TextBox1.Text
                });
                lastCookie = guna2TextBox1.Text;

                Properties.Settings.Default.Cookie = lastCookie;
                Properties.Settings.Default.Save();

                client = new HttpClient(handler: new HttpClientHandler { CookieContainer = cookies });
            }

            MainPanel.Controls.Clear();

            var request = await client.GetAsync($"http://205.209.120.124/api/search?query={queryTB.Text}");

            var resp = await request.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<Welcome>(resp);

            if (obj.Alert == "No credits remaining")
            {
                MessageBox.Show(obj.Alert);
                return;
            }

            label4.Text = obj.Alert.Replace("Credits Left: ", "");

            foreach (var item in obj.Results)
            {
                AddControl(item.Source.Title, item.Source.Data);
            }
        }
    }
}