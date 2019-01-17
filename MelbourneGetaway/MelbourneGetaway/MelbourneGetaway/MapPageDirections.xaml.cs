using Bing.Maps;
using Bing.Maps.Directions;
using MelbourneGetaway.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;
using System.Net.Http;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MelbourneGetaway
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MapPageDirections : Page
    {
        private readonly string BingMapsKey =
"AstDVu9gRLtnI5Bh-OncSwPJDDcT4nmi6k0gSK-dcvY7BfEvanOL7xldoSOWFIcb";
        private readonly XNamespace BingMapsNamespace = "http://schemas.microsoft.com/search/local/ws/rest/v1";
        private Location location;
        private int count;
        private Geolocator locator;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private SettingsFlyout directionsInputFlyout;

        private void MapTapped(object sender, TappedRoutedEventArgs e)
        {
            var position = e.GetPosition(this.MyMap);

            if (this.MyMap.TryPixelToLocation(position, out location))
            {
                Pushpin pin = new Pushpin();
                MapLayer.SetPosition(pin, location);
                pin.Background = new SolidColorBrush(Color.FromArgb(230, 255, 0, 0));
                pin.Text = (++count).ToString();
                this.MyMap.Children.Add(pin);
                this.MyMap.SetView(location);
                this.GetDirections(location);

            }
        }
        public List<string> Waypoints
        {
            get;
            set;
        }
        async private void GetDirections(Location location)
        {
            this.Waypoints.Add(string.Format("{0}, {1}", location.Latitude, location.Longitude));
            if (this.Waypoints.Count < 2) return;

            HttpClient hC = new HttpClient();
            StringBuilder sB = new StringBuilder("http://dev.virtualearth.net/REST/V1/Routes/Driving?o=xml&");

            for (int index = 0; index < this.Waypoints.Count; index++)
            {
                sB.Append(
                string.Format("wp.{0}={1}&", index, this.Waypoints[index]));
            }
            sB.Append("avoid=minimizeTolls&key=");
            sB.Append(this.BingMapsKey);
            HttpResponseMessage rM = await hC.GetAsync(sB.ToString());
            rM.EnsureSuccessStatusCode();
            Stream s = await rM.Content.ReadAsStreamAsync();
            XDocument dT = XDocument.Load(s);
            var query = from p
            in dT.Descendants(this.BingMapsNamespace + "ManeuverPoint")
                        select new
                        {
                            Latitude = p.Element(this.BingMapsNamespace + "Latitude").Value,
                            Longitude = p.Element(this.BingMapsNamespace + "Longitude").Value
                        };
            MapShapeLayer layer = new MapShapeLayer();
            MapPolyline polyline = new MapPolyline();
            foreach (var point in query)
            {
                double latitude, longitude;
                double.TryParse(point.Latitude, out latitude);
                double.TryParse(point.Longitude, out longitude);
                polyline.Locations.Add(new Location(latitude, longitude));
            }
            polyline.Color = Colors.Red;
            polyline.Width = 5;
            layer.Shapes.Add(polyline);
            this.MyMap.ShapeLayers.Add(layer);
            var distance = (from d in dT.Descendants
            (this.BingMapsNamespace + "TravelDistance")
                            select d).First().Value;
            this.DistanceTextBlock.Text =
            string.Format("{0} Kms", distance.ToString());
        }
        
            public MapPageDirections()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.Waypoints = new List<string>();
            var directionsManager = MyMap.DirectionsManager;
            var directionsInput = directionsManager.DirectionsInputView;
            directionsInput.Width = 340;
            directionsInput.HorizontalAlignment = HorizontalAlignment.Center;
            directionsInputFlyout = new SettingsFlyout()
             {
                Background = new SolidColorBrush(Colors.DimGray),
                Content = directionsInput,
                Title = "Directions"
            };

            // Add the route summary to the instructions panel.
            Instructions.Content = directionsManager.RouteSummaryView;

            // Attach an event to show the instructions panel when the route changes.
            directionsManager.ActiveRouteChanged += DirectionsManager_ActiveRouteChanged;
        }
        private void ShowDirectionsPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Close bottom appbar.
            this.BottomAppBar.IsOpen = false;

            // Show the directions input flyout.
            directionsInputFlyout.ShowIndependent();
        }

        private void DirectionsManager_ActiveRouteChanged(object sender, DirectionsEventArgs e)
        {
            if (e.Route != null && e.Route.RouteLegs != null && e.Route.RouteLegs.Count > 0)
            {
                // Set the instructions header information. 
                ToLocation.Text = string.Format("{0} Directions\r\n{1}",
                    e.Route.RouteMode,
                    e.Route.RouteLegs[e.Route.RouteLegs.Count - 1].EndLocation.Name);

                // When the user presses the button to show the instructions panel.
                DirectionsPanel.Visibility = Visibility.Visible;
            }
            else
            {
                // Hide the instructions panel.
                DirectionsPanel.Visibility = Visibility.Collapsed;
            }
        }
         private void CloseDirections_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Hide the instructions panel.
            DirectionsPanel.Visibility = Visibility.Collapsed;
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
       
       


    }
}
    









  