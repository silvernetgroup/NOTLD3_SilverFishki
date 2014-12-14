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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SilverFiszki
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StatsPage : Page
    {
        public StatsPage()
        {
            this.InitializeComponent();
        }

        private void SelectPoziom(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Counter.Poziom = (string)button.Content;

            switch (Counter.Poziom)
            {
                case "Łatwy": Counter.PoziomNumer = 1; break;
                case    "Średni": Counter.PoziomNumer = 2; break;
                case    "Trudny": Counter.PoziomNumer = 3; break;
            }

            this.Frame.Navigate(typeof(NaukaPage));
        }
    }
}
