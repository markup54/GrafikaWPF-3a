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
using System.Windows.Shapes;

namespace GrafikaWPF_3a
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKaruzela.xaml
    /// </summary>
    /// 
    public partial class WindowKaruzela : Window
    {
        public int Licznik { get; set; }
        public List<string> obrazki = new List<string>();
        public WindowKaruzela()
        {
            InitializeComponent();
            obrazki.Add("rys1.jpg");
            obrazki.Add("rys2.jpg");
            obrazki.Add("rys3.jpg");
            obrazki.Add("rys4.jpg");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Licznik--;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Licznik++;
        }
    }
}
