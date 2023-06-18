using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CodeeloSR
{
    public partial class MainForm : Form
    {
        CancellationTokenSource cancellationTokenSource;
        public MainForm() => InitializeComponent();
        private async Task StartRecognition()
        {
            cancellationTokenSource = new CancellationTokenSource();
            var recognizer = new SpeechRecognitionEngine(new CultureInfo("ru-ru"));

            //GrammarBuilder grammarBuilder = new GrammarBuilder();
            //grammarBuilder.Culture = CultureInfo.CreateSpecificCulture("ru-ru");
            //Choices choices = new Choices();
            //choices.Add(new string[] { "Всем", "привет", "вы", "на", "канале", "Кодило", "Всем привет вы на канале Кодило" });
            //grammarBuilder.Append(choices);

            var grammar = new Grammar("CodeeloGrammar.xml");
            recognizer.LoadGrammar(grammar);
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            recognizer.MaxAlternates = 1;
            
            try
            {
                await Task.Delay(-1, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException)
            {

                codeeloTextBox1.Text += "Распознаванние прервано из вне" + Environment.NewLine;
                recognizer.RecognizeAsyncCancel();
            }
            
        }
        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            codeeloTextBox1.Text += "Не удалось распознать!" + Environment.NewLine;
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            codeeloTextBox1.Text += e.Result.Text + Environment.NewLine;
            switch (e.Result.Text)
            {
                case "Кодило открой блокнот":
                    Process.Start("notepad.exe");
                    break;
                case "Кодило открой калькулятор":
                    Process.Start("calc.exe");
                    break;
                case "Кодило открой реестр":
                    Process.Start("regedit.exe");
                    break;
                case "Кодило открой цмд":
                    Process.Start("cmd.exe");
                    break;
            }
            cancellationTokenSource.Cancel();
            codeeloToggleButton1.Checked = !codeeloToggleButton1.Checked;
        }

        private async void codeeloToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(codeeloToggleButton1.Checked)
            {
                codeeloTextBox1.Text += "Начал распознавание" + Environment.NewLine;
                await StartRecognition();
                codeeloTextBox1.Text += "Закончил распознавание" + Environment.NewLine;
            }
            else
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("CodeeloGrammar.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode node in xRoot) 
            { 
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if(attr.Value == "object")
                {
                    XmlElement objectEllement = xDoc.CreateElement("item", "http://www.w3.org/2001/06/grammar");
                    XmlText objectElementText = xDoc.CreateTextNode(codeeloTextBox2.Text);

                    objectEllement.AppendChild(objectElementText);
                    node.ChildNodes[0].AppendChild(objectEllement);
                }
            }
            xDoc.Save("CodeeloGrammar.xml");
        }
    }
}
