using ThePhotoStore.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media.Imaging; 
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.Graphics.Imaging;
using Windows.ApplicationModel.Background;
using System.Text;
using System.Threading.Tasks; 

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ThePhotoStore
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class PhotoPage : Page
    {

        private const String photoKey = "capturedPhoto";

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public PhotoPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

        }


        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }


        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            navigationHelper.OnNavigatedTo(e);

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FolderPage));
        }


        private void View_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewPage));
        }



        private async Task CopyPicturesAsync(StorageFolder targetFolder)
        {



            var file = await KnownFolders.PicturesLibrary.GetFilesAsync();

            foreach (var f in file)
            {
                var newPicture = await f.CopyAsync(targetFolder, "New Picture");

            }

        }
        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                IRandomAccessStream fileStream =
                        await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                BitmapImage bmI = new BitmapImage();

                bmI.SetSource(fileStream);
                picSource.Source = bmI;
                this.DataContext = file;
                StorageFolder picturesFolder = KnownFolders.PicturesLibrary;
                StorageFile copyFile = await file.CopyAsync(picturesFolder);
            }

        }
    }
} 
           
            
        


       
      

    

