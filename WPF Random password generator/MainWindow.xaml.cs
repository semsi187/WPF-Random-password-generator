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
using Bogus;

namespace WPF_Random_password_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Handler
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        List<Handler> handlers = new List<Handler>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            handlers = new Faker<Handler>()
                .RuleFor(u => u.Username, f => f.Internet.UserName())
                .RuleFor(u => u.Password, f => f.Internet.Password())
                .Generate(5);
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            
            
            Username.Text = handlers[0].Username;
            Password.Text = handlers[1].Password;  
        }
    }
}
