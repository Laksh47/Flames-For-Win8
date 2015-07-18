using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string name1, name2,u;
        int g,r;
        public MainPage()
        {
            this.InitializeComponent();
           
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            name1 = first.Text;
            name2 = second.Text;
            g = name2.Length + name1.Length;
            r = g % 6;
            switch (r)
            {
                case 0:
                    u = "Friendship";
                    break;
                case 1:
                    u = "Love ";
                    break;
                case 2:
                    u = "Affection";
                    break;
                case 3:
                    u = "Marriage";
                    break;
                case 4:
                    u = "Enemy";
                    break;
                case 5:
                    u = "Siblings";
                    break;
            }
            text3.Text = u;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        //private void next_Click(object sender, RoutedEventArgs e)
        //{
            
       // }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "";
            second.Text = "";
            text3.Text = "";

        }
    }
}
