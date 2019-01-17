using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MelbourneGetaway.Model;

namespace MelbourneGetaway.ViewModel
{
    public class FavouritesViewModel
    {
        public ObservableCollection<FavouriteItem> FirstCollection { get; set; }

        public ObservableCollection<FavouriteItem> SecondCollection { get; set; }

        public ObservableCollection<FavouriteItem> SwitchCollection { get; set; }
        public  FavouritesViewModel()
        {
            FirstCollection = new ObservableCollection<FavouriteItem>
            {
                new FavouriteItem{ Title = "ACCA, Sight Seeing ", Subtitle = "Added"},
                new FavouriteItem{ Title = "City Circle Tram, Free Outings", Subtitle = "Added"},
                new FavouriteItem{ Title = "Chinese New Year Festival, Events", Subtitle = "Added"},
                new FavouriteItem{ Title = "Chocolate Walking Tour, Food and Wine", Subtitle = "Added"},
                new FavouriteItem{ Title = "Federation Square, Sight Seeing", Subtitle = "Added"},
                new FavouriteItem{ Title = "Melbourne Cup Carnival, Events", Subtitle = "Added"},   
                new FavouriteItem{ Title = "Melbourne Jazz Festival, Events", Subtitle = "Added"},
                new FavouriteItem{ Title = "Melbourne Town Hall, Free Outings", Subtitle = "Added"},
                new FavouriteItem{ Title = "Old Melbourne Gaol, Sight Seeing", Subtitle = "Added"},
                new FavouriteItem{ Title = "Old Treasury Building, Free Outings", Subtitle = "Added"},
                new FavouriteItem{ Title = "Open House Melbourne, Events", Subtitle = "Added"},
                new FavouriteItem{ Title = "Royal Botanic Gardens, Free Outings", Subtitle = "Added"},
                new FavouriteItem{ Title = "Sea life Melbourne Aquarium, Sight Seeing ", Subtitle = "Added"},
                new FavouriteItem{ Title = "Sensory Lab, Food and Wine", Subtitle = "Added"},
                new FavouriteItem{ Title = "Specialty Wine Tours, Food and Wine", Subtitle = "Addeds"},
                new FavouriteItem{ Title = "The Boatbuilders Yard, Food and Wine ", Subtitle = "Added"},
                new FavouriteItem{ Title = "The Commoner, Food and Wine ", Subtitle = "Added"},
                new FavouriteItem{ Title = "The Ian Potter Centre: NGV Australia, Free Outings", Subtitle = "Added"},
           };
            SecondCollection = new ObservableCollection<FavouriteItem>();
            SwitchCollection = new ObservableCollection<FavouriteItem>();
        }

        public void SwitchItem(FavouriteItem item)
        {
            if (FirstCollection.Contains(item))
            {
                FirstCollection.Remove(item);
                SecondCollection.Add(item);
            }
            else
            {
                SecondCollection.Remove(item);
                FirstCollection.Add(item);
            }
        }
        public void ResetItems()
        {
            SwitchCollection.Clear();

            foreach (FavouriteItem item in SecondCollection)
            {
                SwitchCollection.Add(item);
            }
            foreach (FavouriteItem item in SwitchCollection)
            {
                FirstCollection.Add(item);
                SecondCollection.Remove(item);
            }
        }
    
    
    }
}
