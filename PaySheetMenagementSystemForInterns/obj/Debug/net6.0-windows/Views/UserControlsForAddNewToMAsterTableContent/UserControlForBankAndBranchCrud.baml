   M S B A M L   `   `   `  ����]  YPaySheetMenagementSystemForInterns, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContentRPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent  5      x    rPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent.UserControlForBankAndBranchCrud   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      rlocal`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fEf=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      $	��675��5        � 	Resources  5
         MyStyle �� 
TargetType �� Property �� Value �� ElementName �� Path��%�   &	        �� 5   
   " ��6    .�5      ��  � �� 6&   �� $ UserControlLoaderToAddNew��$ RenderSize.Width��� 5       � �� 6'   �� $ UserControlLoaderToAddNew��$ RenderSize.Height�5      5      .��5      �� $��1q�6   $��0��5      ���#d5daf0$��1q�5      ._�5   
   �� $��1q�6   $��0��5      ���#43496b���#d5daf0._�5      � $	��660��6    � ColumnDefinitions 5      �� 5      $	��500 �6'   �� 5      $��* �6'    � RowDefinitions 5       �� 5!      $	��300 �6$   �� 5"      $��* �6$   .+�5'      �� $��0��6   $��0��6*   .+�5(      ��  �� Orientation$ 
Horizontal=�6!   ���#030c45.+�5)      �� ���#030c45.��5*      (� .��5+   "   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$
	 Bank=�6.   
   
Foreground

 �����$��5q�6M   $��15��6X   5,      5-      �� 5.      $��Banks��6    ���#030c45$	��460��6E   
�������$��15(�6d   $��Center=�6r   5/      �� 51      $ 
Horizontal=�6!   $��	20,20,0,0q�6:   .+�52      �� $��
Bank Name ��6    $	��100��65   �� 53      -   5         ��Name$ nameOfTheBank��53   "   $	��300��69   54      �� 56      $ 
Horizontal=�6!   $��	20,10,0,0q�6:   .+�57      �� $��
Bank Code ��6    $	��100��65   �� 58      -   5        $ codeOfTheBank��58   "   $	��300��69   59      �� 5:      $��20q�6!   $
��Left=�6-   .+�5<      �� -   5         ��Name$ addBank��5<   !   $	��200��62   $	��Add��6>   $��5q�6L   $��25��6W     ButtonStyle3#��[ 5=   "   5?      �� 5B      -   5        $ 
updateBank��5B   !   $	��200��65   $��Update��6A   $��5q�6R   $��25��6]   #��[ 5C   "   5E      �� 5H      -   5        $ 
deleteBank��5H   !   $	��200��65   $��Delete��6A   $��5q�6R   $��25��6]   #��[ 5I   "   5K      5L      5O      �� 5R      $��1��6   $��0��6*   .+�5S      �� $ 
Horizontal=�6!   ���#030c45.+�5T      �� ���#030c45.��5U      (� .��5V   "     $	 BuildingFlag=�6.   

 �����$��5q�6U   $��15��6`   5W      5X      �� 5Y      $��Branch��6    ���#030c45$	��460��6F   
�������$��15(�6e   $��Center=�6s   5Z      �� 5]      $ 
Horizontal=�6!   $��	20,20,0,0q�6:   .+�5^      �� $��
Bankc Code��6    $	��100��65   �� 5_      -   5        $ codeOfTheBankForBranch��5_   "   $	��300��6B   5`      �� 5c      $ 
Horizontal=�6!   $��	20,10,0,0q�6:   .+�5d      �� $��Branch Name ��6    $	��100��67   �� 5e      -   5        $ nameOfTheBranch��5e   "   $	��300��6;   5f      �� 5h      $ 
Horizontal=�6!   $��	20,10,0,0q�6:   .+�5i      �� $��Branch Code ��6    $	��100��67   �� 5j      -   5        $ codeOfTheBranch��5j   "   $	��300��6;   5k      �� 5l      $��20q�6!   $
��Left=�6-   .+�5n      �� -	   5        $ 	addBranch��5n   !   $	��200��64   $	��Add��6@   $��5q�6N   $��25��6Y   #��[ 5o   "   5q      �� 5t      -
   5        $ updateBranch��5t   !   $	��200��67   $��Update��6C   $��5q�6T   $��25��6_   #��[ 5u   "   5w      �� 5z      -   5        $ deleteBranch��5z   !   $	��200��67   $��Delete��6C   $��5q�6T   $��25��6_   #��[ 5{   "   5}      5~      5�      �� 5�      $��0��6   $��1��6*   .+�5�      �� $ 
Horizontal=�6!   
�������.+�5�      �� 
�������.��5�      (� .��5�   "     $	 ArrowRightFromBracket=�6.   
 �#030c45$��19��6`   $��3q�6l   5�      5�      �� 5�      $��Bank Details��6    
�������$	��460��6J   ���#030c45$��15(�6k   $��Center=�6y   5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ toShowBankNamesDG��5�      $��10q�6:   5�      5�      �� 5�      $��1��6   $��1��6*   .+�5�      �� $ 
Horizontal=�6!   
�������.+�5�      �� 
�������.��5�      (� .��5�   "     $	 ArrowRightFromBracket=�6.   
 �#030c45$��19��6`   $��3q�6l   5�      5�      �� 5�      $��Branch Details��6    
�������$	��460��6L   ���#030c45$��15(�6m   $��Center=�6{   5�        5�      -   5        $ toShowBranchNamesDG��5�      $��10q�6<   5�      5�      5�      5�      5�      5�      