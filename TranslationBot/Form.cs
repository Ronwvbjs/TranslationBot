using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace TranslationBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        private TwitchClient twitchClient;

        private Regex translateCommand;

        public Form()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.TranslationBotFormLocation;

            subscriptionKeyTextBox.Text = Properties.Settings.Default.SubscriptionKeyTextBoxText;
            showSubscriptionKeyCheckBox.Checked = Properties.Settings.Default.ShowSubscriptionKeyCheckBoxChecked;

            modelTypeComboBox.SelectedIndex = Properties.Settings.Default.ModelTypeComboBoxSelectedIndex;

            botUserNameTextBox.Text = Properties.Settings.Default.BotUserNameTextBoxText;

            botTokenTextBox.Text = Properties.Settings.Default.BotTokenTextBoxText;
            showBotTokenCheckBox.Checked = Properties.Settings.Default.ShowBotToekCheckBoxChecked;

            channelNameTextBox.Text = Properties.Settings.Default.ChannelNameTextBoxText;

            commandNameTextBox.Text = Properties.Settings.Default.CommandNameTextBoxText;

            beginTagPatternTextBox.Text = Properties.Settings.Default.BeginTagPatternTextBoxText;
            endTagPatternTextBox.Text = Properties.Settings.Default.EndTagPatternTextBoxText;

            forceTranslationCheckBox.Checked = Properties.Settings.Default.ForceTranslationCheckBoxChecked;

            startButton.Text = Properties.Resources.StartButtonStartText;
        }

        private void Form_ClientSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();

                notifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Visible = true;

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Activate();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Activate();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (twitchClient != null)
            {
                twitchClient.Disconnect();
                twitchClient = null;
            }

            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.TranslationBotFormLocation = Location;
            }

            Properties.Settings.Default.SubscriptionKeyTextBoxText = subscriptionKeyTextBox.Text;
            Properties.Settings.Default.ShowSubscriptionKeyCheckBoxChecked = showSubscriptionKeyCheckBox.Checked;

            Properties.Settings.Default.ToLanguageComboBoxSelectedIndex = toLanguageComboBox.SelectedIndex;
            Properties.Settings.Default.ModelTypeComboBoxSelectedIndex = modelTypeComboBox.SelectedIndex;

            Properties.Settings.Default.BotUserNameTextBoxText = botUserNameTextBox.Text;

            Properties.Settings.Default.BotTokenTextBoxText = botTokenTextBox.Text;
            Properties.Settings.Default.ShowBotToekCheckBoxChecked = showBotTokenCheckBox.Checked;

            Properties.Settings.Default.ChannelNameTextBoxText = channelNameTextBox.Text;

            Properties.Settings.Default.CommandNameTextBoxText = commandNameTextBox.Text;

            Properties.Settings.Default.BeginTagPatternTextBoxText = beginTagPatternTextBox.Text;
            Properties.Settings.Default.EndTagPatternTextBoxText = endTagPatternTextBox.Text;

            Properties.Settings.Default.ForceTranslationCheckBoxChecked = forceTranslationCheckBox.Checked;

            Properties.Settings.Default.Save();
        }

        private void ShowSubscriptionKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            subscriptionKeyTextBox.UseSystemPasswordChar = !showSubscriptionKeyCheckBox.Checked;
        }

        private void ModelTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string supportLanguageCode;

            switch (modelTypeComboBox.SelectedIndex)
            {
                case 0:
                    supportLanguageCode = Properties.Resources.SMTSupportLanguageCode;
                    break;

                default:
                    supportLanguageCode = Properties.Resources.NMTSupportLanguageCode;
                    break;
            }

            toLanguageComboBox.Items.Clear();
            foreach (string item in supportLanguageCode.Split(','))
            {
                toLanguageComboBox.Items.Add(item);
            }

            try
            {
                toLanguageComboBox.SelectedIndex = Properties.Settings.Default.ToLanguageComboBoxSelectedIndex;
            }
            catch (ArgumentOutOfRangeException)
            {
                toLanguageComboBox.SelectedIndex = 0;
            }
        }

        private void ShowBotTokenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            botTokenTextBox.UseSystemPasswordChar = !showBotTokenCheckBox.Checked;
        }

        private void InputCommandNameTextBox_TextChanged(object sender, EventArgs e)
        {
            translateCommand = new Regex(beginTagPatternTextBox.Text + commandNameTextBox.Text + endTagPatternTextBox.Text, RegexOptions.Singleline);
        }

        private void BeginTagPatternTextBox_TextChanged(object sender, EventArgs e)
        {
            translateCommand = new Regex(beginTagPatternTextBox.Text + commandNameTextBox.Text + endTagPatternTextBox.Text, RegexOptions.Singleline);
        }

        private void EndTagPatternTextBox_TextChanged(object sender, EventArgs e)
        {
            translateCommand = new Regex(beginTagPatternTextBox.Text + commandNameTextBox.Text + endTagPatternTextBox.Text, RegexOptions.Singleline);
        }

        private void ForceTranslationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (forceTranslationCheckBox.Checked)
            {
                beginTagPatternLabel.Enabled = false;
                beginTagPatternTextBox.Enabled = false;

                commandNameLabel.Enabled = false;
                commandNameTextBox.Enabled = false;

                endTagPatternLabel.Enabled = false;
                endTagPatternTextBox.Enabled = false;
            }
            else
            {
                beginTagPatternLabel.Enabled = true;
                beginTagPatternTextBox.Enabled = true;

                commandNameLabel.Enabled = true;
                commandNameTextBox.Enabled = true;

                endTagPatternLabel.Enabled = true;
                endTagPatternTextBox.Enabled = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer;

            if (startButton.Text == Properties.Resources.StartButtonStopText)
            {
                startButton.Text = Properties.Resources.StartButtonStartText;

                if (twitchClient != null)
                {
                    twitchClient.Disconnect();
                    twitchClient = null;
                }

                twitchGroupBox.Enabled = true;

                subscriptionKeyLabel.Enabled = true;
                subscriptionKeyTextBox.Enabled = true;
                showSubscriptionKeyCheckBox.Enabled = true;
            }
            else
            {
                if (twitchClient == null)
                {
                    startButton.Enabled = false;

                    twitchGroupBox.Enabled = false;

                    subscriptionKeyLabel.Enabled = false;
                    subscriptionKeyTextBox.Enabled = false;
                    showSubscriptionKeyCheckBox.Enabled = false;

                    try
                    {
                        ConnectionCredentials connectionCredentials;

                        connectionCredentials = new ConnectionCredentials(botUserNameTextBox.Text, botTokenTextBox.Text);

                        twitchClient = new TwitchClient();
                        twitchClient.Initialize(connectionCredentials, channelNameTextBox.Text);

                        twitchClient.Connect();

                        twitchClient.OnMessageReceived += OnTwitchMessageReceived;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    timer = new System.Windows.Forms.Timer();

                    timer.Interval = 1000;

                    timer.Tick += OnTick;
                    timer.Enabled = true;
                }
            }
        }

        private string GetSubscriptionKeyTextBox()
        {
            return subscriptionKeyTextBox.Text;
        }

        private string GetToLanguageComboBoxText()
        {
            return toLanguageComboBox.Text;
        }

        private async void OnTwitchMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            string message, fromLanguageCode, toLanguageCode;
            Match match;

            message = e.ChatMessage.Message;
            if (!forceTranslationCheckBox.Checked)
            {
                match = translateCommand.Match(message);
                if (match.Success)
                {
                    message = message.Replace(match.Value, "");
                }
                else
                { 
                    message = null;
                }
            }

            if (message != null)
            {
                fromLanguageCode = DetectLanguage(message);
                if (toLanguageComboBox.InvokeRequired)
                {
                    toLanguageCode = (string)toLanguageComboBox.Invoke(new Func<string>(GetToLanguageComboBoxText));
                }
                else
                {
                    toLanguageCode = toLanguageComboBox.Text;
                }

                if (fromLanguageCode == toLanguageCode)
                {
                    message = null;
                }
            }

            if (message != null)
            {
                twitchClient.SendMessage(twitchClient.JoinedChannels[0], await Translate(message));
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (!twitchClient.IsConnected)
            {
                return;
            }

            startButton.Text = Properties.Resources.StartButtonStopText;

            startButton.Enabled = true;

            ((System.Windows.Forms.Timer)sender).Enabled = false;
        }

        private string DetectLanguage(string text)
        {
            // Send request
            string detectURI = string.Format(Properties.Resources.TranslatorTextAPIEndpoint, "detect");

            HttpWebRequest detectLanguageWebRequest = (HttpWebRequest)WebRequest.Create(detectURI);

            if (subscriptionKeyTextBox.InvokeRequired)
            {
                detectLanguageWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", (string)subscriptionKeyTextBox.Invoke(new Func<string>(GetSubscriptionKeyTextBox)));
            }
            else
            {
                detectLanguageWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKeyTextBox.Text);
            }

            detectLanguageWebRequest.ContentType = "application/json; charset=utf-8";
            detectLanguageWebRequest.Method = "POST";

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string jsonText = serializer.Serialize(text);

            string body = "[{ \"Text\": " + jsonText + " }]";
            byte[] data = Encoding.UTF8.GetBytes(body);

            detectLanguageWebRequest.ContentLength = data.Length;

            using (var requestStream = detectLanguageWebRequest.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            // Read and parse JSON response
            HttpWebResponse response = (HttpWebResponse)detectLanguageWebRequest.GetResponse();

            var responseStream = response.GetResponseStream();
            var jsonString = new StreamReader(responseStream, Encoding.GetEncoding("utf-8")).ReadToEnd();
            dynamic jsonResponse = serializer.DeserializeObject(jsonString);

            var languageInfo = jsonResponse[0];
            if (languageInfo["score"] > (decimal)0.5)
            {
                return languageInfo["language"];
            }
            else
            {
                return "";
            }
        }

        private async Task<string> Translate(string text)
        {
            string fromLanguageCode = DetectLanguage(text);
            if (fromLanguageCode == "")
            {
                //MessageBox.Show("The source language could not be detected automatically " + "or is not supported for translation.", "Language detection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return text;
            }

            string toLanguageCode;
            if (toLanguageComboBox.InvokeRequired)
            {
                toLanguageCode = (string)toLanguageComboBox.Invoke(new Func<string>(GetToLanguageComboBoxText));
            }
            else
            {
                toLanguageCode = toLanguageComboBox.Text;
            }

            // Handle null operations: no text or same source/target languages
            if (text == "" || fromLanguageCode == toLanguageCode)
            {
                return text;
            }

            // Send translation request
            string endpoint = string.Format(Properties.Resources.TranslatorTextAPIEndpoint, "translate");
            string uri = string.Format(endpoint + "&from={0}&to={1}", fromLanguageCode, toLanguageCode);

            string translation;

            Object[] body = new Object[] { new { Text = text } };
            var requestBody = JsonConvert.SerializeObject(body);
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(uri);
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                    if (subscriptionKeyTextBox.InvokeRequired)
                    {
                        request.Headers.Add("Ocp-Apim-Subscription-Key", (string)subscriptionKeyTextBox.Invoke(new Func<string>(GetSubscriptionKeyTextBox)));
                    }
                    else
                    {
                        request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKeyTextBox.Text);
                    }

                    request.Headers.Add("X-ClientTraceId", Guid.NewGuid().ToString());

                    var response = await client.SendAsync(request);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<List<Dictionary<string, List<Dictionary<string, string>>>>>(responseBody);
                    translation = result[0]["translations"][0]["text"];
                }
            }

            return translation;
        }
    }
}
