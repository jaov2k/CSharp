using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace arch2mmWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
            FeetTextbox.Text = "0";
            InchTextbox.Text = "0";
            NumeratorTextbox.Text = "0";
            DenominatorTextbox.Text = "1";
        }

        private void FeetTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            FeetTextbox.SelectAll();
        }

        private void InchTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            InchTextbox.SelectAll();
        }

        private void NumeratorTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            NumeratorTextbox.SelectAll();
        }

        private void DenominatorTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            DenominatorTextbox.SelectAll();
        }

        private void FeetTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void InchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void NumeratorTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void DenominatorTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {            
            update();
        }

        private void update()
        {
            double feet, inch, numerator, denominator;

            double.TryParse(FeetTextbox.Text, out feet);            
            double.TryParse(InchTextbox.Text, out inch);
            double.TryParse(NumeratorTextbox.Text, out numerator);
            double.TryParse(DenominatorTextbox.Text, out denominator);
                        
            double total = (feet * 304.8) + (inch * 25.4) + ((denominator == 0) ? 0 : (numerator / denominator * 25.4));
            
            DenominatorTextbox.BorderBrush = denominator.Equals(0) ? Brushes.Black : SystemColors.ControlDarkBrush;
            DenominatorTextbox.FontWeight  = denominator.Equals(0) ? FontWeights.Bold : FontWeights.Normal;
            DenominatorTextbox.Foreground  = denominator.Equals(0) ? Brushes.White : Brushes.Black;
            DenominatorTextbox.Background  = denominator.Equals(0) ? Brushes.Red : Brushes.White;            

            ouputText.Text = total.ToString("F") + "mm";
        }
    }
}
