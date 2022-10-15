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
using System.Drawing;
using Color = System.Windows.Media.Color;
using Color2 = System.Drawing.Color;

namespace SliderView
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            L.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(VM.colorAlpha), Convert.ToByte(VM.colorRed), Convert.ToByte(VM.colorGreen), Convert.ToByte(VM.colorBlue)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Color2 color = Color2.FromArgb(Convert.ToByte(VM.colorAlpha), Convert.ToByte(VM.colorRed), Convert.ToByte(VM.colorGreen), Convert.ToByte(VM.colorBlue));
            VM.Name = "#" + color.Name.ToString();
            VM.Colors.Add(VM.color);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(LB.SelectedIndex != -1)
                VM.Colors.RemoveAt(LB.SelectedIndex);
        }
    }
}
