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
using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;

namespace PaySheetMenagementSystemForInterns.Views
{
    /// <summary>
    /// Interaction logic for UserControlAddNewUserToMasterTable.xaml
    /// </summary>
    public partial class UserControlAddNewUserToMasterTable : UserControl
    {
        public UserControlAddNewUserToMasterTable()
        {
            InitializeComponent();
        }

        private void LoadAddDataFromExelDAtaSheet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForDataImportFromExcel();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            
        }

        private void seeMasterTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForMasterDataShowing();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
