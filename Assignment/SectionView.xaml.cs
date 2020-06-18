using Assignment.ViewModels;
using System;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Assignment
{
    public sealed partial class SectionView : UserControl
    {
        private UISettings _uiSettings;

        private static DependencyProperty s_viewModelProperty
            = DependencyProperty.Register(
                "ViewModel",
                typeof(FinalNewsViewModel),
                typeof(SectionView),
                new PropertyMetadata(null, new PropertyChangedCallback(OnViewModelPropertyChanged))
                );

        public static DependencyProperty ViewModelProperty
        {
            get { return s_viewModelProperty; }
        }

        public FinalNewsViewModel ViewModel
        {
            get { return (FinalNewsViewModel)GetValue(s_viewModelProperty); }
            set { SetValue(s_viewModelProperty, value); }
        }
        public SectionView()
        {
            this.InitializeComponent();

            VisualStateManager.GoToState(this, "ContentSteadyState", false);
            _uiSettings = new UISettings();
        }

        /// <summary>
        /// Rotation Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LayoutRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var newSize = e.NewSize;
            UpdateForSizeChanged(newSize.Width, newSize.Height);
        }

        /// <summary>
        /// Rotation Effect based on new height and width
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        private void UpdateForSizeChanged(double newWidth, double newHeight)
        {
            try
            {
                var centerX = newWidth / 2.0;
                RootTransform.CenterX = centerX;
                NextContentTransform.CenterX = centerX;

                var centerZ = -newWidth / 2.0;
                RootTransform.CenterZ = centerZ;
                NextContentTransform.CenterZ = centerZ;

                ClipGeometry.Rect = new Rect(0.0, -1024.0, newWidth, newHeight + 1024.0);
            }
            catch (Exception ex)
            {
                Result.Error(ex.Message);
            }
            finally
            {
                Result.Ok();
            }
        }

        /// <summary>
        /// Transition of story board of news section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContentTransitionStoryboard_Completed(object sender, object e)
        {
            CurrentContentPresenter.Content = NextContentPresenter.Content;
            VisualStateManager.GoToState(this, "ContentSteadyState", false);
        }

        private void OnViewModelChanged(FinalNewsViewModel oldValue, FinalNewsViewModel newValue)
        {
            if (oldValue != null && _uiSettings.AnimationsEnabled)
            {
                NextContentPresenter.Content = newValue;
                CurrentContentPresenter.Content = oldValue;

                VisualStateManager.GoToState(this, "ContentTransitionState", true);
            }
            else
            {
                CurrentContentPresenter.Content = newValue;
            }
        }

        private static void OnViewModelPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((SectionView)o).OnViewModelChanged((FinalNewsViewModel)e.OldValue, (FinalNewsViewModel)e.NewValue);
        }

        private void NewsTapped(object sender, TappedRoutedEventArgs e)
        {
            if (NewsSelected != null)
            {
                NewsSelected(this, (NewsViewModel)((FrameworkElement)e.OriginalSource).DataContext);
            }
        }

        public event TypedEventHandler<object, NewsViewModel> NewsSelected;
    }
}
