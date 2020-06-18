using Assignment.ViewModels;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private async void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string UserName = userName.Text.ToString();
                string Password = txtPassword.Password.ToString();

                var result = ValidateInput(UserName, Password);
                if (result.IsOk)
                {
                    this.Frame.Navigate(typeof(MainPage), UserName);
                }
                else
                {
                    var dialog = new MessageDialog(result.Description, result.Message);
                    await dialog.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                Result.Error(ex.Message);
            }
            finally
            {

            }
        }

        private Result ValidateInput(string UserName, string Password)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(UserName))
                {
                    return Result.Error("Login error", "Please, enter a valid user name.");
                }
                if (String.IsNullOrWhiteSpace(Password))
                {
                    return Result.Error("Login error", "Please, enter a valid password.");
                }
                return Result.Ok();
            }
            catch (Exception e)
            {
                return Result.Error(e.Message);
            }
            finally
            {
                Result.Ok();
            }
        }

        private void OnBackgroundFocus(object sender, RoutedEventArgs e)
        {
            DoEffectIn();
        }

        private void OnForegroundFocus(object sender, RoutedEventArgs e)
        {
            DoEffectOut();
        }

        public enum EffectMode
        {
            None,
            Background,
            Foreground,
            Disabled
        }

        private EffectMode _currentEffectMode = EffectMode.None;

        private void DoEffectIn(double milliseconds = 1000)
        {
            try
            {
                if (_currentEffectMode == EffectMode.Foreground || _currentEffectMode == EffectMode.None)
                {
                    _currentEffectMode = EffectMode.Background;
                    background.Scale(milliseconds, 1.0, 1.1);
                    background.Blur(milliseconds, 6.0, 0.0);
                    foreground.Scale(500, 1.0, 0.95);
                    foreground.Fade(milliseconds, 1.0, 0.75);
                }
            }
            catch (Exception e)
            {
                Result.Error(e.Message);
            }
            finally
            {
                Result.Ok();
            }
        }

        private void DoEffectOut(double milliseconds = 1000)
        {
            try
            {
                if (_currentEffectMode == EffectMode.Background || _currentEffectMode == EffectMode.None)
                {
                    _currentEffectMode = EffectMode.Foreground;
                    background.Scale(milliseconds, 1.1, 1.0);
                    background.Blur(milliseconds, 0.0, 6.0);
                    foreground.Scale(500, 0.95, 1.0);
                    foreground.Fade(milliseconds, 0.75, 1.0);
                }
            }
            catch (Exception e)
            {
                Result.Error(e.Message);
            }
            finally
            {
                Result.Ok();
            }
        }
    }
}
