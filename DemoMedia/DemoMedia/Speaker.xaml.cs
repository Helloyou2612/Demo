using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoMedia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Speaker : Page
    {
        public Speaker()
        {
            this.InitializeComponent();
        }

        private async void BtnSpeaker_OnClick(object sender, RoutedEventArgs e)
        {
            var content =
                !string.IsNullOrWhiteSpace(this.txtContent.Text)
                    ? this.txtContent.Text
                    : "Please type some text";

            var media = new MediaElement();
            var syn = new SpeechSynthesizer();
            //Convert text to stream
            var stream = await syn.SynthesizeTextToStreamAsync(content);
            //Read stream
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }
    }
}
