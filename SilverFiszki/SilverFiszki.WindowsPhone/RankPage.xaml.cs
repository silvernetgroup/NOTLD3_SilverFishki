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
    public sealed partial class RankPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public RankPage()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;

            LoadHighscore();
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

        private void LoadHighscore()
        {
            List<Score> highscore = Data.Highscore;

            Rank1.Text = Rank2.Text = Rank3.Text = Rank4.Text = Rank5.Text =
                Rank6.Text = Rank7.Text = Rank8.Text = Rank9.Text = Rank10.Text = "";

            if (highscore.Count >= 10)
            {
                Rank10.Text = FormatPositionInRank(highscore[9], 10);
            }
            if (highscore.Count >= 9)
            {
                Rank9.Text = FormatPositionInRank(highscore[8], 9);
            }
            if (highscore.Count >= 8)
            {
                Rank8.Text = FormatPositionInRank(highscore[7], 8);
            }
            if (highscore.Count >= 7)
            {
                Rank7.Text = FormatPositionInRank(highscore[6], 7);
            }
            if (highscore.Count >= 6)
            {
                Rank6.Text = FormatPositionInRank(highscore[5], 6);
            }
            if (highscore.Count >= 5)
            {
                Rank5.Text = FormatPositionInRank(highscore[4], 5);
            }
            if (highscore.Count >= 4)
            {
                Rank4.Text = FormatPositionInRank(highscore[3], 4);
            }
            if (highscore.Count >= 3)
            {
                Rank3.Text = FormatPositionInRank(highscore[2], 3);
            }
            if (highscore.Count >= 2)
            {
                Rank2.Text = FormatPositionInRank(highscore[1], 2);
            }
            if (highscore.Count >= 1)
            {
                Rank1.Text = FormatPositionInRank(highscore[0], 1);
            }
        }

        private string FormatPositionInRank(Score score, int rank)
        {
            string rankTwoChars = rank.ConvertToTwoCharacterString();
            string scoreString = score.GoodAnswerCount.ConvertToTwoCharacterString();
            string gameTime = string.Format("{1}:{0}", score.CzasGry.Seconds.ConvertToTwoCharacterString(), 
                score.CzasGry.Minutes.ConvertToTwoCharacterString());

            return string.Format("{0}.  {1} pkt  {2}", rankTwoChars ,
                scoreString, gameTime);
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

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
