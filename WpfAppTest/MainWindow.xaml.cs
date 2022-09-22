using ServiceReference1;
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

namespace WpfAppTest
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

        
        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            ServiceReference1.Service1Client age = new ServiceReference1.Service1Client();

            int number1 = int.Parse(txtnumber1.Text);
            int number2 = int.Parse(txtnumber2.Text);
            CompositeType c = new CompositeType();
            c.Number1 = number1;
            c.Number2 = number2;

            int result =await age.AdditionAsync(c);
            txtresult.Text = result.ToString();
        }
    }
}
