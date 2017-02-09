using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace InfoKioskVIKK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Infokiosk_Vikk.Tunniplaan));
        }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AvalehtBoxItem.IsSelected)
            {
                ContentFrame.Navigate(typeof(Infokiosk_Vikk.Avaleht));
            }
            else if (KontaktidBoxItem.IsSelected)
            {
                ContentFrame.Navigate(typeof(Infokiosk_Vikk.Kontaktid));
            }
            else if (UudisedBoxItem.IsSelected)
            {
                ContentFrame.Navigate(typeof(Infokiosk_Vikk.Uudised));
            }
            else if (TunniplaanBoxItem.IsSelected)
            {
                ContentFrame.Navigate(typeof(Infokiosk_Vikk.Tunniplaan));
            }

            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}