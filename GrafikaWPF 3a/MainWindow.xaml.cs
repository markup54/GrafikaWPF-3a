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

namespace GrafikaWPF_3a
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            image_gory.Source = new BitmapImage(new Uri("rys2.jpg",UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> listObrazkow = new List<string>();
            listObrazkow.Add("rys1.jpg");
            listObrazkow.Add("rys2.jpg");
            listObrazkow.Add("rys3.jpg");
            listObrazkow.Add("rys4.jpg");
            Random random = new Random();
            int indeks = random.Next(listObrazkow.Count);
            image_gory.Source = new BitmapImage(new Uri(listObrazkow[indeks], UriKind.Relative));
        }
    }
}
