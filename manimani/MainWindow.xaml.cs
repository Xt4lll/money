using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
        private ObservableCollection<notes> table = new ObservableCollection<notes>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            table.Add(new notes("sdfsd", "sada", "asda", false));
            grid.ItemsSource = null;
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

            if (nameOfNote.Text != "" && types.SelectedItem != null && money.Text != "")
            {
                notes note = new notes(nameOfNote.Text.ToString(), types.SelectedItem.ToString(), money.Text.ToString(), false);
                table.Add(note);
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
            table.RemoveAt(grid.SelectedIndex);
            grid.ItemsSource = null;
            grid.ItemsSource = items;
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                notes item = grid.SelectedItem as notes;

                nameOfNote.Text = item.name;
                types.Text = item.type;
                money.Text = item.money;
            }
        }
    }
}


