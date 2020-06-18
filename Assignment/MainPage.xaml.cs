using Assignment.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Random _random;
        private DispatcherTimer _updateTimer;

        public MainPage()
        {
            this.InitializeComponent();
            _random = new Random();
            _updateTimer = new DispatcherTimer();
            _updateTimer.Interval = TimeSpan.FromSeconds(3.0);
            _updateTimer.Tick += UpdateTimer_Tick;
            signIn.Click += loginbtn_Click;
        }

        private void UpdateRandomSection()
        {
            try
            {
                var sectionsInView = HeadlinesHub.SectionsInView;
                var sectionsCount = sectionsInView.Count;

                if (sectionsCount > 0)
                {
                    var sectionToUpdate = sectionsInView[_random.Next(sectionsCount)];
                    sectionToUpdate.DataContext = new FinalNewsViewModel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                
            }
        }

        private void UpdateTimer_Tick(object sender, object e)
        {
            UpdateRandomSection();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            string text = e.Parameter as string;
            signIn.Content = "Welcome " + text;
            
            _updateTimer.Start();
        }

        private void SectionView_ArticleSelected(object sender, NewsViewModel e)
        {
            Frame.Navigate(typeof(NewsPage), e.Headline);
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
