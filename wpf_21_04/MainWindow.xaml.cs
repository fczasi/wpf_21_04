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
            thecactussb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void thecactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            thecactusrec.Visibility = Visibility.Hidden;
            thecactussli.Visibility = Visibility.Hidden;
            thecactussb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void bestcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Visible;
            bestcactusli.Visibility = Visibility.Visible;
            bestcactusb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void bestcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Hidden;
            bestcactusli.Visibility = Visibility.Hidden;
            bestcactusb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void cactusescheck_checked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Visible;
            cactusesli.Visibility = Visibility.Visible;
            cactusesb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void cactusescheck_unchecked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Hidden;
            cactusesli.Visibility = Visibility.Hidden;
            cactusesb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void icecreamcheck_checked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Visible;
            icecreamli.Visibility = Visibility.Visible;
            icecreamsb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void icecreamcheck_unchecked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Hidden;
            icecreamli.Visibility = Visibility.Hidden;
            icecreamsb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void stockcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Visible;
            stockcactusli.Visibility = Visibility.Visible;
            stockcactusb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void stockcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Hidden;
            stockcactusli.Visibility = Visibility.Hidden;
            stockcactusb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }
        private void paintingcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Visible;
            paintingcactusli.Visibility = Visibility.Visible;
            paintingcactusb.Visibility = Visibility.Visible;
            cactusprogress.Value++;
        }
        private void paintingcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Hidden;
            paintingcactusli.Visibility = Visibility.Hidden;
            paintingcactusb.Visibility = Visibility.Hidden;
            cactusprogress.Value--;
        }

        private void thecactussli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            thecactusrec.Height = thecactussli.Value;
        }
        private void paintingcactusli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paintingcactusrec.Height = paintingcactusli.Value;
        }
        private void bestcactusli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bestcactusrec.Height = bestcactusli.Value;
        }
        private void cactusesli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cactusesrec.Height = cactusesli.Value;
        }
        private void icecreamli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            icecreamrec.Height = icecreamli.Value;
        }
        private void stockcactusli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            stockcactusrec.Height = stockcactusli.Value;
        }

        private void thecactussb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            thecactusrec.Width = thecactussb.Value;
        }
        private void tbestcactusli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bestcactusrec.Width = bestcactusb.Value;
        }
        private void cactusesb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cactusesrec.Width = cactusesb.Value;
        }
        private void icecreamsb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            icecreamrec.Width = icecreamsb.Value;
        }
        private void stockcactusb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            stockcactusrec.Width = stockcactusb.Value;
        }
        private void paintingcactusb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paintingcactusrec.Width = paintingcactusb.Value;
        }

        private void bestcactusb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}