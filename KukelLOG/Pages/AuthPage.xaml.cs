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

namespace KukelLOG
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            using (var db = new KukelLOGEntities())
            {
                //var Users = db.Users.AsNoTracking().Where(u => u.Login.StartsWith("max")).ToList();//
                var Users = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == "max" && u.Password == "test");
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Pages.Page1());
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
