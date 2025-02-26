using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Iskhakova41
{
    public partial class AuthPage : Page
    {
        private int failedAttempts = 0;
        private string generatedCaptcha = "";

        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Есть пустые поля!");
                return;
            }

            // Проверка логина и пароля в БД
            User user = Iskhakova41Entities.GetContext().User
                          .FirstOrDefault(p => p.UserLogin == login && p.UserPassword == password);

            if (user != null)
            {
                MessageBox.Show("Успешный вход!");
                Manager.MainFrame.Navigate(new ProductPage(user));
                ResetAuthForm();
            }
            else
            {
                failedAttempts++;

                if (failedAttempts == 1)
                {
                    MessageBox.Show("Введены неверные данные! Введите капчу.");
                    GenerateCaptcha();
                    CaptchaPanel.Visibility = Visibility.Visible;
                }
                else if (failedAttempts >= 2)
                {
                    if (CaptchaInput.Text.Trim() != generatedCaptcha)
                    {
                        MessageBox.Show("Капча введена неверно! Блокировка входа на 10 секунд.");
                        BlockLoginButton();
                    }
                    else
                    {
                        MessageBox.Show("Успешная проверка капчи, но логин или пароль неверны!");
                    }
                }
            }
        }

        private void GenerateCaptcha()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rand = new Random();
            generatedCaptcha = new string(Enumerable.Range(0, 4).Select(_ => chars[rand.Next(chars.Length)]).ToArray());

            // Устанавливаем символы в TextBlock и меняем их позиции
            captchaOne.Text = generatedCaptcha[0].ToString();
            captchaTwo.Text = generatedCaptcha[1].ToString();
            captchaThree.Text = generatedCaptcha[2].ToString();
            captchaFour.Text = generatedCaptcha[3].ToString();

            // Случайные цвета для усложнения чтения капчи
            captchaOne.Foreground = new SolidColorBrush(GetRandomColor());
            captchaTwo.Foreground = new SolidColorBrush(GetRandomColor());
            captchaThree.Foreground = new SolidColorBrush(GetRandomColor());
            captchaFour.Foreground = new SolidColorBrush(GetRandomColor());
        }

        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromRgb((byte)rand.Next(100, 255), (byte)rand.Next(100, 255), (byte)rand.Next(100, 255));
        }

        private async void BlockLoginButton()
        {
            ButtonLOgin.IsEnabled = false;
            await Task.Delay(10000); // Блокировка на 10 секунд
            ButtonLOgin.IsEnabled = true;
        }

        private void ResetAuthForm()
        {
            Login.Clear();
            Password.Clear();
            CaptchaInput.Clear();
            CaptchaPanel.Visibility = Visibility.Collapsed;
            failedAttempts = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductPage(null));
            ResetAuthForm();
        }

       
    }
}