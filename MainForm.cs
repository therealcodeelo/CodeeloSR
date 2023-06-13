using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Culture = CultureInfo.CreateSpecificCulture("ru-ru");
            Choices choices = new Choices();
            choices.Add(new string[] { "Всем", "привет", "вы", "на", "канале", "Кодило", "Всем привет вы на канале Кодило" });
            grammarBuilder.Append(choices);

            var grammar = new Grammar(grammarBuilder);
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
    }
}
