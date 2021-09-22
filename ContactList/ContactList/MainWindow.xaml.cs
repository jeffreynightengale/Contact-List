using System;
using System.Collections.Generic;
using System.IO;
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

namespace ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string file = "contacts.txt";
            string[] lines = File.ReadAllLines(file);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split('|');

                int id = Convert.ToInt32(pieces[0]);
                string first = pieces[1];
                string last = pieces[2];
                string email = pieces[3];
                string url = pieces[4];

                Contact c = new Contact();
                c.ID = id;
                c.First = first;
                c.Last = last;
                c.Email = email;
                c.URL = url;

                ContactList.Items.Add(c);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact c = (Contact)ContactList.SelectedItem;
            FirstTxt.Text = c.First;
            LastTxt.Text = c.Last;
            EmailTxt.Text = c.Email;
            var uri = new Uri(c.URL);
            var img = new BitmapImage(uri);
            ImageTxt.Source = img;
            

        }
    }
}
