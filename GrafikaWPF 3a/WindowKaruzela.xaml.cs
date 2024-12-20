﻿using System;
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
        public List<Obraz> obrazki = new List<Obraz>();
        public WindowKaruzela()
        {
            InitializeComponent();
            obrazki.Add(new Obraz("rys1.jpg"));
            obrazki.Add(new Obraz("rys2.jpg"));
            obrazki.Add(new Obraz("rys3.jpg"));
            obrazki.Add(new Obraz("rys4.jpg"));
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Licznik--;
            if (Licznik < 0)
            {
                Licznik = obrazki.Count - 1;
            }
            wyswietlObraz(Licznik);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Licznik++;
            if(Licznik == obrazki.Count)
            {
                Licznik = 0;
            }
            wyswietlObraz(Licznik);
        }
        private void wyswietlObraz(int i)
        {
            imageModyfikowany.Source = new BitmapImage(new Uri(obrazki[i].UrlObrazka,UriKind.Relative));
            polubieniaTextBlock.Text = obrazki[i].LiczbaPolubien.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            obrazki[Licznik].LiczbaPolubien++;
            wyswietlObraz(Licznik);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
