using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using static System.Net.Mime.MediaTypeNames;

namespace manimani
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<notes> table = new List<notes>();
            grid.ItemsSource = table;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> TypeList = new List<string>();

            foreach (var item in types.Items)
            {
                TypeList.Add(Convert.ToString(item));
            }

            typeEnter window = new typeEnter();
            var result = window.ShowDialog();

            if (result == true && window.typeBox.Text != "")
            {
                types.Items.Add(window.typeBox.Text);
            }
        }

        private void addNote_Click(object sender, RoutedEventArgs e)
        {
            List<notes> table = new List<notes>();

            if (nameOfNote.Text != "" && types.SelectedItem != null && money.Text != "")
            {
                table.Add(new notes(nameOfNote.Text.ToString(), types.SelectedItem.ToString(), money.Text.ToString(), false));

                grid.ItemsSource = null;
                grid.ItemsSource = table;
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            List<string> items = new List<string>();
            foreach (var item in grid.Items)
            {
                items.Add(item.ToString());
            }
            items.RemoveAt(grid.SelectedIndex);
            grid.ItemsSource = null;
            grid.ItemsSource = items;
        }
    }
}


