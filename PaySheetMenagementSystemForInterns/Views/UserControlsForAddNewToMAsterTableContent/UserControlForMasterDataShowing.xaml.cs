using PaySheetMenagementSystemForInterns.Commands;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent
{
    /// <summary>
    /// Interaction logic for UserControlForMasterDataShowing.xaml
    /// </summary>
    public partial class UserControlForMasterDataShowing : UserControl
    {
        public UserControlForMasterDataShowing()
        {
            InitializeComponent();
            masterDataShowingCommand1.MasterDAtaLoadTogridView(this, connection);
        }

        //import
        MasterDataShowingCommand masterDataShowingCommand1 = new MasterDataShowingCommand();
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");

        //popup window 
        private void masterTableViewDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if(e.ChangedButton == MouseButton.Left)
                {
                    var rowValue = e.Source as DataGrid;
                    //each values pass as an object
                    PopUpWindowForMasterDataShowing popUpWindowForMasterData = new PopUpWindowForMasterDataShowing(rowValue.SelectedItem);
                    popUpWindowForMasterData.Owner = Window.GetWindow(this);
                    popUpWindowForMasterData.Show();
                }
            }
            catch (Exception ex) { }
        }

        
    }
}
