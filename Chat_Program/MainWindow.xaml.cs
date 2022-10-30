using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Chat_Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int location = 0;
        List<string> fakemessage = new()
        {
           "salam",
           "necesen",
           "saol ",
           "is guc",
           "teki ",
           "dogurdan"
        };
        public System.Windows.CornerRadius CornerRadius { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Time_Label.Content = DateTime.Now.ToString("hh:mm");
        }

        private void Exititem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private  void Sendbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Messagetextbox.Text))
                return;

            
            Label label = new Label();
            label.Height = 28;
            label.Width = 100;
            label.FontSize = 17;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.VerticalAlignment = VerticalAlignment.Top;
                
            label.Margin = new Thickness(2, location+=20, 0, 0);
            messagegrid.Children.Add(label);
            label.Content = Messagetextbox.Text;


           
            

            Label label1 = new Label();
            label1.Height = 32;
            label1.Width = 90;
            label1.FontSize = 17;
            label1.HorizontalAlignment = HorizontalAlignment.Right;
            label1.VerticalAlignment = VerticalAlignment.Top;
            label1.Margin = new Thickness(0, location += 40,0, 0);
            messagegrid.Children.Add(label1);
            label1.Content = fakemessage[Random.Shared.Next(0,6)];

            
           
        }
    }
}
