   M S B A M L   `   `   `  ����]  YPaySheetMenagementSystemForInterns, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContentRPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent  5      �    {PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent.UserControlForAddNewTraineeToTheDataBase   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      rlocal`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fEf=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      $	��670��5
      $	��452��5      $
��Left=�5      .��5      �   � RowDefinitions  5   
   �� 5      $	��665 �6   .+�5   
   � .+�5      �� $��1q�6   $��0��5      ���#d5daf0._�5      �� $��1q�6   $��0��5      ���#43496b
�������._�5!      � ���#d5daf0 � ColumnDefinitions 5"      �� 5#      $	��450 �6/   �� 5$      $��* �6/   .+�5(      �� $��0��6%    �� Orientation$ Vertical=�65   .+�5*      �� $ 
Horizontal=�6)   .+�5+   "   �� $�� Personal details��6(   ���#030c45$	��414��5-   (   
�������$��12(�5/   (   $��Segoe UI Symbol)�50   (   �� 52   "   ���#030c45.��53   &   (� .��54   *   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserTag=�66      
Foreground
 �����$��20��56   6   58   '   59   #   5;      �� 5>      $ 
Horizontal=�6)   $��5q�6B   .+�5?   "   �� $	��120��6(   $��Trainee Number��64   $��12(�5@   $   $��Segoe UI Symbol)�5A   $   �� 5C   "   -   5         ��Name$ TraineeNumberToDB��5C   *   $��12(�5D   &   $��Segoe UI Symbol)�5E   &   $	��300��5F   &   ���#43496b5G   '   5H      �� 5K      $ 
Horizontal=�6)   $��5q�6B   .+�5L   "   �� $	��120��6(   $
��Name��64   $��12(�5M   $   $��Segoe UI Symbol)�5N   $   �� 5P   "   -   5        $ TraineeNameToDB��5P   *    �� TextWrapping$
 Wrap=�5Q   &   $��12(�5R   &   $��Segoe UI Symbol)�5S   &   $	��300��5T   &   ���#43496b5U   &   5V      �� 5Y      $ 
Horizontal=�6)   $��5q�6B   .+�5Z   "   �� $	��120��6(   $��	ID Number��64   $��12(�5[   $   $��Segoe UI Symbol)�5\   $   �� 5^   "   -   5        $ TraineeIDToDB��5^   *   $
 Wrap=�5_   &   $��12(�5`   &   $��Segoe UI Symbol)�5a   &   $	��300��5b   &   ���#43496b5c   '   5d      �� 5g      $ 
Horizontal=�6)   $��5q�6B   .+�5h   "   �� $	��120��6(   $��Location��64   $��12(�5i   $   $��Segoe UI Symbol)�5j   $   �� 5l   "   -   5        $��TraineeLocationToDB��5o   )   $��30��5l   +   
���   �
�������$	��300��5p   )   5q      �� 5v      $ 
Horizontal=�6)   $��5q�6B   .+�5w   "   �� $	��120��6(   $��Pay [ YES or NO ]��64   $��12(�5x   $   $��Segoe UI Symbol)�5y   $   �� 5{   "   -   5        $��TraineeShouPayOrNoToDB��5~   )   $��30��5{   +   
���   �
�������$	��300��5   )   5�      �� 5�      $ 
Horizontal=�6)   $��5q�6B   .+�5�   "   �� $	��120��6(   $��Telephone Number��64   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   "   -   5        $ TraineeTelephoneNoToDB��5�   *   $
 Wrap=�5�   &   $��12(�5�   &   $��Segoe UI Symbol)�5�   &   $	��300��5�   &   ���#43496b5�   '   5�      �� 5�      $ 
Horizontal=�6)   $��5q�6B   .+�5�   "   �� $	��120��6(   $��Training Start Date��64   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   (  "System.Windows.Controls.DatePicker  5�   "   -   5          Name$ TraineeStartDateToDB��5�   -   $��12(�5�   &   $��Segoe UI Symbol)�5�   &   $	��300��5�   &   ���#d5daf05�   &   5�      �� 5�      $ 
Horizontal=�6)   $��5,5,5,20q�6B   .+�5�   "   �� $	��120��6(   $��Training End Date��64   $��12(�5�   $   $��Segoe UI Symbol)�5�   $     5�   "   -   5        $ TraineeEndtDateToDB��5�   -   $��12(�5�   &   $��Segoe UI Symbol)�5�   &   $	��300��5�   &   ���#d5daf05�   &   5�      �� 5�      $��1��6)   $ Vertical=�69   .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $�� Bank Account details��6,   ���#030c45$	��418��5�   (   
�������$��12(�5�   (   $��Segoe UI Symbol)�5�   (   �� 5�   &   ���#030c45.��5�   *   (� .��5�   .     $
 Bank=�6:   
 �����$��20��5�   6   5�   +   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��5q�6F   .+�5�   &   �� $	��120��6,   $��Account Number��68   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   &   -	   5        $ TraineeBankAccNoToDB��5�   .   $
 Wrap=�5�   &   $��12(�5�   &   $��Segoe UI Symbol)�5�   &   $	��300��5�   &   ���#43496b5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��5q�6F   .+�5�   &   �� $	��120��6,   $��	Bank Name��68   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   &   -
   5        $��TraineeBankNameToDB��5�   )   $��30��5�   /   
���   �
�������$	��300��5�   )   65   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��5q�6F   .+�5�   &   �� $	��120��6,   $��	Bank Code��68   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   &   -   5        $��TraineeBankCodeToDB��5�   )   $�� ��5�   )   
�������$	��300��5�   )   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��5q�6F   .+�5�   &   �� $	��120��6,   $��Branch Name��68   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   &   -   5        $��TraineeBranchNameToDB��5�   -   $��30��5�   /   
���   �
�������$	��300��5�   -   69   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��5q�6F   .+�5�   &   �� $	��120��6,   $��Branch Code��68   $��12(�5�   $   $��Segoe UI Symbol)�5�   $   �� 5�   &   -   5        $��TraineeBranchCodeToDB��5  )   
�������$	��300��5  )   5  #   5     �� 5     $��40��6&   $	��300��5  "      borderButton1#��[  5  "   $��Center=�5  "   $��1q�5  "   $��40q�5  "    �� CornerRadius$ 5��5  "   ._�5  "   �� -   5        	 ��Name$	 LoadAddDataToDataBase��5  )     ButtonStyle3#��[ 5  !   .��5  &   �� $ 
Horizontal=�61   .+�5  *     $ Database=�66   $��15��5  .    �#7303075  .   �� 5  *   $�� ADD TO DATABASE��64   $��Center=�5  ,   $��5q�5  ,   $��12(�5   ,   $��Segoe UI Symbol)�5!  ,   5$  '   
 � ToolTip
 5&  &   _� 5'  *   $.��(Click to Add new trainee to the Database��62   5*  #   5+     5.     55     58     59     5:     5=     5?     