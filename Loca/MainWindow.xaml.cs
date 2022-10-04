using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Loca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void button_ua_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk");

            this.Title = "ua";

            button1.Content = Localization.ButtonText;
            button2.Content = Localization.ButtonText2;
            button3.Content = Localization.ButtonText3;
        }

        private void button_uk_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            this.Title = "eng";

            button1.Content = Localization.ButtonText;
            button2.Content = Localization.ButtonText2;
            button3.Content = Localization.ButtonText3;
        }

        private void button_fr_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");

            this.Title = "fr";

            button1.Content = Localization.ButtonText;
            button2.Content = Localization.ButtonText2;
            button3.Content = Localization.ButtonText3;
        }
    }
}
