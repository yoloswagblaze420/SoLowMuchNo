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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace _2190152_lab08_5631307821_5631378321
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            Class1 swag = (Class1)e.Parameter;
            name2.Text = swag.name;
            gender2.Text = swag.gender;
            height2.Text = swag.height;
            String []hobbyFinal = new String[4] { "", "", "", "" };
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                if (swag.hobbiesTruth[i])
                {
                    hobbyFinal[j] = swag.hobbies[i];
                    j++;
                }
            }
            hobby1.Text = hobbyFinal[0];
            hobby2.Text = hobbyFinal[1];
            hobby3.Text = hobbyFinal[2];
            hobby4.Text = hobbyFinal[3];

        }
 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
