﻿using System;
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
using System.Windows.Shapes;

namespace PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent
{
    /// <summary>
    /// Interaction logic for PopUpWindowForMasterDataShowing.xaml
    /// </summary>
    public partial class PopUpWindowForMasterDataShowing : Window
    {
        //constructer override by changeing parameter signature
        public PopUpWindowForMasterDataShowing(object trainee)
        {
            InitializeComponent();
            //data binding 
            DataContext = trainee;
        }
    }
}
