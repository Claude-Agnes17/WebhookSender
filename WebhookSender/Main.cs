using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;

namespace WebhookSender
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private static void SendWebHook(string hookURL, string name, string profile, string message)
        {
            NameValueCollection webhookInfo = new NameValueCollection();
            webhookInfo.Add("username", name);
            webhookInfo.Add("avatar_url", profile);
            webhookInfo.Add("content", message);
            new WebClient().UploadValues(hookURL, webhookInfo);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendWebHook(urlBox.Text, nameBox.Text, profileBox.Text, messageBox.Text);
        }
    }
}