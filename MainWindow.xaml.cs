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

namespace Hw8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBox notesList = new ListBox();
            notesList.Items.Add("Macbook Pro");
            notesList.Items.Add("HP Pavilion 5478");
            notesList.Items.Add("Acer LK-08");

            products.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Ноутбуки" }, 
                Content = notesList 
            });
        }

    }
}
