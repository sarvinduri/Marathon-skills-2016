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

namespace Marathon_skills_2016.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnIW_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frmObj.Navigate(new PageIW());
        }

        private void BtnSp_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnSob_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
