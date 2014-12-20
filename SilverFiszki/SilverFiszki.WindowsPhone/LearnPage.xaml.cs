using SilverFiszki.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace SilverFiszki
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LearnPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        private Random random = new Random();
        PolishEanglishDictionary db = new PolishEanglishDictionary();
        Row currentRow = null;

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer showTimeTimer = new DispatcherTimer();

        public LearnPage()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;

            Data.GameStart = DateTime.Now;

            showTimeTimer = new DispatcherTimer();
            showTimeTimer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            showTimeTimer.Tick += showTimeTimer_Tick;
            showTimeTimer.Start();

            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += timer_Tick;
            LoadNext();
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        private void showTimeTimer_Tick(object sender, object e)
        {
            TimeSpan timeElapsedInGame = DateTime.Now - Data.GameStart;
            TimerTextBlock.Text = string.Format("{0}:{1}", timeElapsedInGame.Minutes, timeElapsedInGame.Seconds);
        }

        private void timer_Tick(object sender, object e)
        {
            timer.Stop();
            ButtonNieznam.IsEnabled = true;
            ButtonZnam.IsEnabled = true;
            LoadNext();
        }

        private void LoadNext()
        {
            currentRow = db.getRanodmRow(Data.PoziomNumer);
            MainImage.Source = currentRow.Image;
            Opis.Text = "";

            if (Data.Suma == 10)
            {
                Data.GameStop = DateTime.Now;
                this.Frame.Navigate(typeof(ResultPage));
            }
        }

        private void ZnamButton_Click(object sender, RoutedEventArgs e)
        {
            Data.Znam++;
            ZnamCount.Text = Data.Znam.ConvertToTwoCharacterString();
            //ZnamCounter.Text = "Znam - " + Data.Znam.ToString();
            LoadNext();
        }

        private void NieznamButton_Click(object sender, RoutedEventArgs e)
        {
            Data.Nieznam++;
            //NieZnamCounter.Text = "Nie Znam - " + Data.Nieznam;
            NieZnamCount.Text = Data.Nieznam.ConvertToTwoCharacterString();
            if (Data.Jezyk == "en")
            {
                Opis.Text = currentRow.Angielski + " - " + currentRow.ZdanieAngielski;
            }
            else
            {
                Opis.Text = currentRow.Polski + " - " + currentRow.ZdaniePolski;
            }

            BlokujPrzyciski();

            timer.Start();
        }

        private void BlokujPrzyciski()
        {
            ButtonZnam.IsEnabled = false;
            ButtonNieznam.IsEnabled = false;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
