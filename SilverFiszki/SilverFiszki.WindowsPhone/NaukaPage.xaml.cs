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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace SilverFiszki
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NaukaPage : Page
    {
        private Random random = new Random();
        PolishEanglishDictionary db = new PolishEanglishDictionary();
        Row currentRow = null;

        DispatcherTimer timer = new DispatcherTimer();

        public NaukaPage()
        {
            this.InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += timer_Tick;
            LoadNext();
        }

        private void timer_Tick(object sender, object e)
        {
            timer.Stop();
            LoadNext();
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            Data.Znam++;
            //ButtonZnam.Content = "Znam " + Counter.Znam;
            ZnamCounter.Text = Data.Znam.ToString();

            LoadNext();
        }
        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            Data.Nieznam++;
            //ButtonNieznam.Content = "Nie Znam - " + Counter.Nieznam;
            NieZnamCounter.Text = Data.Nieznam.ToString();

            if (Data.Jezyk == "en")
            {
                Opis.Text = currentRow.Angielski + " - " + currentRow.ZdanieAngielski;
            }
            else
            {
                Opis.Text = currentRow.Polski + " - " + currentRow.ZdaniePolski;
            }

            timer.Start();
        }

        private void LoadNext()
        {
            currentRow = db.getRanodmRow(Data.PoziomNumer);
            MainImage.Source = currentRow.Image;
            Opis.Text = "";
        }
    }
}
