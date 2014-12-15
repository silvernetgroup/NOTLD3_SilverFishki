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

        private void ButtonDificultEasy_Click(object sender, RoutedEventArgs e)
        {
            Counter.Poziom = Convert.ToString(Poziom.Łatwy);
            Counter.PoziomNumer = Convert.ToInt32(Poziom.Łatwy);

            MoveToNextPage();
        }

        private void ButtonDificultMedium_Click(object sender, RoutedEventArgs e)
        {
            Counter.Poziom = Convert.ToString(Poziom.Średni);
            Counter.PoziomNumer = Convert.ToInt32(Poziom.Średni);

            MoveToNextPage();
        }

        private void ButtonDificultHard_Click(object sender, RoutedEventArgs e)
        {
            Counter.Poziom = Convert.ToString(Poziom.Trudny);
            Counter.PoziomNumer = Convert.ToInt32(Poziom.Trudny);

            MoveToNextPage();
        }        
        
        private void MoveToNextPage()
        {
            this.Frame.Navigate(typeof(LearnPage));
        }

    }
}
