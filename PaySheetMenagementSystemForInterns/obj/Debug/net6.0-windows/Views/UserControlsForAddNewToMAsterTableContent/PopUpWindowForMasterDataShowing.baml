   M S B A M L   `   `   `  ����]  YPaySheetMenagementSystemForInterns, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContentRPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent  5   	   x    rPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent.PopUpWindowForMasterDataShowing   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   rlocal`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent     5   	   X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fEf=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5	   	     � Title$  Trainee Details��5   	   $	��400��5
   	   $	��400��6    � Icon$ /Resourses/logo.png��5   	   .��5      �� $��2q�6   
�������
�������._�5   
   �� $��1q�6   ���#43496b �� CornerRadius$ 3��5      ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #d5daf0��6#    � Offset$ 1Q�63   � 5      $ white��6#   $ 0Q�61   5      ._�5      � .+�5      ��  �� Orientation$ Vertical=�6   $��Center=�64   $��Center=�5      .+�5!      �� .+�5#      � $��Center=�6    � ColumnDefinitions 5$      �� 5%   "   $	��100 �63   �� 5&   "   $��* �63   .+�5)      �� $��0��6$   $��0,0,10,0q�64   .��5*   "   (� .��5+   &   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 UserTag=�62   
   
Foreground
 �#43496b$��70��5-   2   5.   #   5/      �� 51      $��1��6)   .+�54   "   �� $ 
Horizontal=�6-   .+�55   &   �� -   5         ��Name$ TraineeNumber��55   0   $��Center=�57   0   $
��Bold"�58   0   $��20(�59   0   ��56   0   �� *[Trainee No]+59   0   5;   #   �� 5>   "   $ 
Horizontal=�6-   $��0,5,0,0q�6F   .+�5?   &   �� -   5        $ 	TraineeID��5?   0   $��Center=�5A   (   $
��Bold"�5B   (   ��5@   (   �� *[ID]+5B   (   5D   #   �� 5G   "   $ 
Horizontal=�6-   $��0,5,0,0q�6F   .+�5I   &   �� -   5        $ TraineeLocation��5I   0   $��Center=�5K   (   $
��Bold"�5L   (   ��5J   (   �� *
Location+5L   (   �� 5O   &   .��5P   *   (� .��5Q   .     $	 Location=�6:   

 �   �$��15��5S   2   5T   +   5U   '   5V   #   5Y      5_      �� 5b      .+�5e      �� $ 
Horizontal=�6%   $��0,5,0,0q�6>   .+�5f      �� $!��                     Name :��6$   $	��120��6J   �� 5g      -   5        $ TraineeName��5g   (   $	��250��6=   $��Center=�5i   (   $
��Bold"�5j   (   ��5h   (   �� *[Name]+5j   (   5l      �� 5q      $ 
Horizontal=�6%   $��0,5,0,0q�6>   .+�5r      �� $��Telephone Number :��6$   $	��120��6A   �� 5s      -   5        $ TraineeTelephoneNumber��5s   (   $	��250��6H   $��Center=�5u   (   $
��Bold"�5v   (   ��5t   (   �� *[Telephone No]+5v   (   5x      �� 5z      $��1q�5{   !   ���#43496b$��5,10,5,5q�5}   !   $ 3��5~   !   ._�5�   "   �� $��0,0,0,10q�6-   .+�5�   &   �� .��5�   *   �� $��Training��60   $
��Bold"�6C   5�   '   �� 5�   &   $ 
Horizontal=�61   .+�5�   *   �� $��                Start :��60   $	��100��6R   �� 5�   *   -   5        $ TraineeStartDate��5�   4   $	��250��6N   $��Center=�5�   4   $
��Bold"�5�   4   ��5�   4   �� *[Start Date]+5�   4   5�   '   �� 5�   &   $ 
Horizontal=�61   $��0,5,0,0q�6J   .+�5�   *   �� $��                 End :��60   $	��100��6Q   �� 5�   *   -   5        $ TraineeEndDate��5�   4   $	��250��6L   $��Center=�5�   (   $
��Bold"�5�   (   ��5�   (   �� *
[End Date]+5�   (   5�   '   �� 5�   &   $ 
Horizontal=�61   .+�5�   *   �� $��           Months :��60   $	��100��6N   �� 5�   *   -   5        $ TraineeMonths��5�   4   $	��250��6K   $��Center=�5�   4   $
��Bold"�5�   4   ��5�   4   �� *Months+5�   4   5�   '   5�   #   5�      �� 5�      $ 
Horizontal=�6)   $��10q�5�   )   $��Right=�5�   )   .+�5�   "   �� $��Pay or No :��6(   �� 5�   "   -	   5        $ 
TraineePay��5�   ,   $��Center=�5�   (   $
��Bold"�5�   (   ���#43496b��5�   (   �� *[Should pay or no]+5�   (   5�      5�      5�      5�      5�      5�      5�      5�      