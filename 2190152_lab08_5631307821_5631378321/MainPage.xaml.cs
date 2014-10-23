//Phoomipat Utis 5631307821
//Siwat Thumvila 5631378321
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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace _2190152_lab08_5631307821_5631378321
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
       
            Boolean[] hobbyListTruth = new Boolean[4]{false,false,false,false};
            String[] hobbyList = new String[4] { check1.Content.ToString(), check2.Content.ToString(), check3.Content.ToString(), check4.Content.ToString() };


            if (check1.IsChecked.Value) { hobbyListTruth[0] = true; }
            if (check2.IsChecked.Value) { hobbyListTruth[1] = true; }
            if (check3.IsChecked.Value) { hobbyListTruth[2] = true; }
            if (check4.IsChecked.Value) { hobbyListTruth[3] = true; }

            if (name.Text == null) { name.Text = ""; }

            if (height.Text == null) { height.Text = ""; }

            String genderString;
            if (gender.SelectionBoxItem==null) { genderString = ""; }
            else { genderString = gender.SelectionBoxItem.ToString(); }       
            

            Class1 yolo2 = new Class1(name.Text,genderString,height.Text,hobbyList,hobbyListTruth);
            
            
            Frame.Navigate(typeof(Page2), yolo2);
        }

        private void check1_Checked(object sender, RoutedEventArgs e)
        {
            check1.IsChecked = true;
        }

        private void check2_Checked(object sender, RoutedEventArgs e)
        {
            check2.IsChecked = true ;
        }

        private void check2_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {

        }

        private void check3_Checked(object sender, RoutedEventArgs e)
        {
            check3.IsChecked = true;

        }

        private void check4_Checked(object sender, RoutedEventArgs e)
        {
            check4.IsChecked = true;
        }

        private void check1_Unchecked(object sender, RoutedEventArgs e)
        {
            check1.IsChecked = false;
        }

        private void check2_Unchecked(object sender, RoutedEventArgs e)
        {
            check2.IsChecked = false;
        }

        private void check3_Unchecked(object sender, RoutedEventArgs e)
        {
            check3.IsChecked = false;
        }

        private void check4_Unchecked(object sender, RoutedEventArgs e)
        {
            check4.IsChecked = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            height.Text = Convert.ToDouble(height.Text)+0.1+"";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            height.Text = Convert.ToDouble(height.Text) - 0.1 + "";
        }

    }
}
