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
using MahApps.Metro.Controls;

namespace DotNetChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckDotNetVersion();
        }

        public void CheckDotNetVersion()
        {
            DotNetVersion.Content = DotNetCheck.GetDotNetVersion();
            UpdateList.ItemsSource = DotNetCheck.GetDotNetUpdateList();
        }

        private void UpdateList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string str = UpdateList.SelectedItem.ToString();
            string kbnumber = str.Substring(str.LastIndexOf("KB") + 2);
            System.Diagnostics.Process.Start("https://support.microsoft.com/kb/"+kbnumber);
        }
    }
}
