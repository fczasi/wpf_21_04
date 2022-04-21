using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace wpf_20_04_22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void thecactuscheck_checked(object sender, RoutedEventArgs e)
        {
            thecactusrec.Visibility = Visibility.Visible;
            thecactussli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void thecactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            thecactusrec.Visibility = Visibility.Hidden;
            thecactussli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void bestcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Visible;
            bestcactusli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void bestcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Hidden;
            bestcactusli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void cactusescheck_checked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Visible;
            cactusesli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void cactusescheck_unchecked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Hidden;
            cactusesli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void icecreamcheck_checked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Visible;
            icecreamli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void icecreamcheck_unchecked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Hidden;
            icecreamli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void stockcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Visible;
            stockcactusli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void stockcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Hidden;
            stockcactusli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void paintingcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Visible;
            paintingcactusli.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void paintingcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Hidden;
            paintingcactusli.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
    }
}