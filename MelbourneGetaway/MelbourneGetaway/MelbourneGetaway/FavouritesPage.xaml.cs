using MelbourneGetaway.Common;
using MelbourneGetaway.Data;
using MelbourneGetaway.ViewModel;
using MelbourneGetaway.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MelbourneGetaway
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class FavouritesPage : Page
    {
        private readonly FavouritesViewModel favouritesViewModel;
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

        public FavouritesPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            favouritesViewModel = new FavouritesViewModel();
            DataContext = favouritesViewModel;
          
        }
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
        private void GridViewDragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            var item = e.Items.FirstOrDefault();
            if (item == null)
                return;

            e.Data.Properties.Add("item", item);
            e.Data.Properties.Add("gridSource", sender);
        }

        private void GridViewDrop(object sender, DragEventArgs e)
        {
            object gridSource;
            e.Data.Properties.TryGetValue("gridSource", out gridSource);

            if (gridSource == sender)
                return;

            object sourceItem;
            e.Data.Properties.TryGetValue("item", out sourceItem);
            if (sourceItem == null)
                return;

            favouritesViewModel.SwitchItem((FavouriteItem)sourceItem);
        }

        private List<String> favouritesList = new List<String>() { };
        private List<FavouriteItem> favouriteItemList = new List<FavouriteItem> { };

        private async Task<string> saveFavouritesToFileAsync()
        {
            
            StorageFolder sFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile sFile = await sFolder.CreateFileAsync("Favourites.txt", CreationCollisionOption.ReplaceExisting);
            

            for (int i = 0; i <= FavouritesGridview2.Items.Count - 1; i++)
            {
                var item = FavouritesGridview2.Items[i];
                FavouriteItem favItem = (FavouriteItem)item;
                favouritesList.Add(favItem.Title);
                await FileIO.WriteLinesAsync(sFile, favouritesList);
            }
            
            return "favouritesList";
            
        }
 
        private async void SaveFavourites_Click(object sender, RoutedEventArgs e)
        {
            await saveFavouritesToFileAsync();
        }
        //private async Task<string> loadFavouritesFromFileAsync()
        //{
        //    favouritesViewModel.ResetItems();
        //    StorageFolder sFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        //    StorageFile sFile = await sFolder.GetFileAsync("Favourites.txt");
        //    var rFile = await FileIO.ReadLinesAsync(sFile);
             
        //    if (rFile != null)
        //        foreach (var line in rFile)
        //        {
        //            for (int i = 0; i <= FavouritesGridView1.Items.Count - 1; i++) 
        //            {
        //                var item = FavouritesGridView1.Items[i];
        //                FavouriteItem favItems = (FavouriteItem)item;
                       
        //        }
        //        return "";
        //}}

        private async void ViewFavourites_Click(object sender, RoutedEventArgs e)
        {

            //await loadFavouritesFromFileAsync();
        }

        private void Clearfavs_Click(object sender, RoutedEventArgs e)
        {
            favouritesViewModel.ResetItems();
        }

       
        

    }
}

