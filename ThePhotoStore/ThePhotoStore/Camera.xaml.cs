using ThePhotoStore.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage.Provider;
using Windows.Media.MediaProperties;


// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ThePhotoStore
{
    public sealed partial class Camera : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        
        
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public Camera()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private StorageFile photo;
        private WriteableBitmap wbM;
        async private void CameraCapture()
        {

            CameraCaptureUI cUI = new CameraCaptureUI();

            cUI.PhotoSettings.AllowCropping = true;
            cUI.PhotoSettings.CroppedAspectRatio = new Size(10, 10);
            cUI.PhotoSettings.MaxResolution = CameraCaptureUIMaxPhotoResolution.MediumXga;

            photo =
                await cUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo != null)
            {
                using (var streamCamera = await photo.OpenAsync(FileAccessMode.Read))
                {

                    BitmapImage bmI = new BitmapImage();
                    bmI.SetSource(streamCamera);
                    ImageSource.Source = bmI;
                    ImageSource.Visibility = Visibility.Visible;
                    int width = bmI.PixelWidth;
                    int height = bmI.PixelHeight;

                     wbM = new WriteableBitmap(width, height);

                    using (var stream = await photo.OpenAsync(FileAccessMode.Read))
                    {
                        wbM.SetSource(stream);
                    }
                }
            }
        }
                
            
        
        private async void SaveImageAsJpeg()
            {
                // Create the File Picker control
            FileSavePicker fsP = new FileSavePicker();
            fsP.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            fsP.FileTypeChoices.Add("JPG File", new List<string>() { ".jpg" });
            fsP.FileTypeChoices.Add("PNG File", new List<string>() { ".png" });
            fsP.FileTypeChoices.Add("JPEG File", new List<string>() { ".jpeg" });
            fsP.FileTypeChoices.Add("BMP FILE", new List<string>() { ".bmp" });
            fsP.SuggestedFileName = "New Picture";

            StorageFile file = await fsP.PickSaveFileAsync();
            
            if (file != null)
            {
                // If the file path and name is entered properly, and user has not tapped 'cancel'..

                using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                {
                    // Encode the image into JPG format,reading for saving
                    BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.JpegEncoderId, stream);
                    Stream pixelStream = wbM.PixelBuffer.AsStream();
                    byte[] pixels = new byte[pixelStream.Length];
                    await pixelStream.ReadAsync(pixels, 0, pixels.Length);
                    encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Ignore, (uint)wbM.PixelWidth, (uint)wbM.PixelHeight, 96.0, 96.0, pixels);
                    await encoder.FlushAsync();
                }
            }
        }

         private void Camera_Click(object sender, RoutedEventArgs e)
        {
            CameraCapture();
        }
        private void SavePhoto_Click(object sender, RoutedEventArgs e)
        {
            SaveImageAsJpeg();
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
    }
}
    


        
        
       
        
    

