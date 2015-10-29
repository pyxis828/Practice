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
using System.Collections.ObjectModel;

namespace PracticeDatgrid
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox txt04;
        TextBox txt05;
        ObservableCollection<TestItem> TestItemList = new ObservableCollection<TestItem>();
       
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtbox04_Loaded(object sender, RoutedEventArgs e)
        {
            txt04 = (sender as TextBox);
            //txt04.IsEnabled = false;
        }

        private void txtbox05_Loaded(object sender, RoutedEventArgs e)
        {
            txt05 = (sender as TextBox);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            TestItemList.Add(new TestItem());
            gvTest.ItemsSource = TestItemList;
        }
        private void chk01_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (sender as CheckBox);
            if (c.IsChecked == true)
            {
                txt04.IsEnabled = true;
               
            }
        }
    }
}
