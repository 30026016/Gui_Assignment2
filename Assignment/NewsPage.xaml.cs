using Assignment.ViewModels;
using System;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewsPage : Page
    {
        private DispatcherTimer _loadTimer;
        private UISettings _uiSettings;

        private static DependencyProperty s_articleProperty =
            DependencyProperty.Register("Article", typeof(NewsViewModel), typeof(NewsPage), new PropertyMetadata(null));

        public static DependencyProperty ArticleProperty
        {
            get { return s_articleProperty; }
        }

        public NewsViewModel News
        {
            get { return (NewsViewModel)GetValue(s_articleProperty); }
            set { SetValue(s_articleProperty, value); }
        }
        public NewsPage()
        {
            this.InitializeComponent();

            VisualStateManager.GoToState(this, "ContentNotLoadedState", false);

            // Simulate asynchronous loading of content
            _loadTimer = new DispatcherTimer();
            _loadTimer.Interval = TimeSpan.FromSeconds(0.55);
            _loadTimer.Tick += LoadTimer_Tick;

            _uiSettings = new UISettings();
        }

        private void LoadTimer_Tick(object sender, object e)
        {
            // Play content entrance animation
            VisualStateManager.GoToState(this, "ContentLoadedState", _uiSettings.AnimationsEnabled);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var news = new NewsViewModel();
            news.Headline = (string)e.Parameter;

            this.News = news;

            _loadTimer.Start();

            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested += ArticlePage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested -= ArticlePage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void ArticlePage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            e.Handled = true;
            Frame.GoBack();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
