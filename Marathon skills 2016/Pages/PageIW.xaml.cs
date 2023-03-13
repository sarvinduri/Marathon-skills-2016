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
    /// Логика взаимодействия для PageIW.xaml
    /// </summary>
    public partial class PageIW : Page
    {
        public PageIW()
        {
            InitializeComponent();
        }

        private void BtnIU_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame fmOb= new ClassFrame();
            ClassFrame.frmObj.Navigate(new PageIU());
        }
        private void BtnIN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
