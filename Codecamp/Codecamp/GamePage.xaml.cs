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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Codecamp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {


        public GamePage()
        {
            this.InitializeComponent();

           /* Canvas Mycan = new Canvas();
	        Mycan.Width = 400;
	        Mycan.Height = 400;
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Colors.Blue);
            Mycan.Background = myBrush;
            Mycan.Margin = new Thickness(0, 0, 1000, 1000);
            MainPanel.Children.Add(Mycan);

            Canvas Mycan2 = new Canvas();
            Mycan2.Width = 400;
            Mycan2.Height = 400;
            SolidColorBrush myBrush2 = new SolidColorBrush(Windows.UI.Colors.Red);
            Mycan2.Background = myBrush2;
            Mycan2.Margin = new Thickness(100, 100, 1000, 1000);
            MainPanel.Children.Add(Mycan2); */

            /*player pl = new player(1,10000);
            //MainPanel.Children.Add(p1.drawFigure);

            BitmapImage image = new BitmapImage(new Uri("/MyProject;component/Images/down.png", UriKind.Relative));

            Image figure = new Image();
            figure.Source = image;
            figure.Width = 50;
            figure.Height = 50;
            figure.Margin = new Thickness(10, 10, 1000, 1000);
            MainPanel.Children.Add(figure);

            //player p2 = new player(2,10000);*/
           //pl_blue.C
        }

        private void Roll(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int step = rnd.Next(1, 7);
            greetingOutput.Text = " " + step;

           // p1.
            pl_black.Margin = new Thickness(100, 100, 0, 0);
        }

        public void buyField()
        {

        }
    }
}
