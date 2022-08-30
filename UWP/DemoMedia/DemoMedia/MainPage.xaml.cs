using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoMedia
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ObservableCollection<Song> _songs;

        public MainPage()
        {
            InitializeComponent();
            _songs = new ObservableCollection<Song>();
        }

        private async void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            var filePicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.List,
                SuggestedStartLocation = PickerLocationId.MusicLibrary
            };

            filePicker.FileTypeFilter.Add(".mp3");

            var file = await filePicker.PickSingleFileAsync();
            if (file == null)
                return;

            var fileProp = await file.Properties.GetMusicPropertiesAsync();
            _songs.Add(
                new Song
                {
                    Title = fileProp.Title,
                    Album = fileProp.Album,
                    Artist = fileProp.Artist,
                    Duration = fileProp.Duration,
                    SongFile = file
                });


            MyMedia.SetSource(
                await file.OpenAsync(FileAccessMode.Read),
                file.ContentType);
            MyMedia.AutoPlay = true;
        }
    }
}