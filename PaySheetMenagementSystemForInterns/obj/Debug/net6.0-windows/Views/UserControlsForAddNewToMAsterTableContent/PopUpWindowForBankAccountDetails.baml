   M S B A M L   `   `   `  ????]  YPaySheetMenagementSystemForInterns, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContentRPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent  5      y    sPaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent.PopUpWindowForBankAccountDetails   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   rlocal`clr-namespace:PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fEf=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5	   	     ? Title$  Bank Details??5   	   $	??300??5
   	   $	??700??6    ? Icon$ /Resourses/logo.png??5   	    ? 
ResizeMode$ NoResize=?5   	   .??5      ?? $??2q?6   
???????
???????._?5   
   ?? $??1q?6   ???#43496b ?? CornerRadius$ 3??5      ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5      ?  ? Color$ #d5daf0??6#    ? Offset$ 1Q?63   ? 5      $ white??6#   $ 0Q?61   5      ._?5      ?  ? ColumnDefinitions 5       ?? 5!      $	??200 ?6'   ?? 5"      $??* ?6'   .+?5'      ?? $??0??6   $??10q?6(   $??Center=?64   $??Center=?6Q   .??5(      (? .??5)      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$
	 Bank=?6&   
   
Foreground
 ?#43496b J? Opacity$	 0.2Q?5+   &   5-      5.      ?? 5/      $??0??6   $??10q?6(   $??Center=?50      $??Center=?51      $	??100??52      .??53      (? .??54        $
	 User=?6&   
 ?#43496b$ 1Q?56   &   58      5:      ?? 5=      $??1??6   $??20,0,0,0q?6-   .+?5?      ?? $??Right=?6"   $??	0,10,20,0q?6>   .+?5@      ?? -   5         ??Name$ bankAcc??5@   $   $??Center=?5B   %   $
??Bold"?5C   %   $??20(?5D   %   ??5A   %   ?? *[Account No]+5D   %   5E      ?? 5H       ?? Orientation$ 
Horizontal=?6!   $??0,5,0,5q?6:   .+?5I      ?? -   5        $ TraineeNumber??5I   $   $??Center=?5K   $   $
??Bold"?5L   $   $??20(?5M   $   ??5J   $   ?? *[Trainee No]+5M   $   5N      ?? 5Q      $ 
Horizontal=?6!   $??0,0,0,8q?6:   .+?5R      ?? -   5        $ TraineeName??5R   $   $??Center=?5T   $   $
??Bold"?5U   $   $??12(?5V   $   ??5S   $   ?? *Name+5V   $   5W      ?? 5Z      $ 
Horizontal=?6!   $??0,0,0,5q?6:   .+?5[      ?? -   5        $ bkName??5[   $   $??Center=?5]   $   $
??Bold"?5^   $   $??20(?5_   $   ??5\   $   ?? *[Bank Name]+5_   $   5`      ?? 5c      $ 
Horizontal=?6!   $??0,0,0,8q?6:   .+?5d      ?? -   5        $ bkCode??5d   $   $??Center=?5f   $   $
??Bold"?5g   $   $??12(?5h   $   ??5e   $   ?? *[Bank Code]+5h   $   5i      ?? 5l      $ 
Horizontal=?6!   $??0,0,0,5q?6:   .+?5m      ?? -   5        $ brName??5m   $   $??Center=?5o   $   $
??Bold"?5p   $   $??20(?5q   $   ??5n   $   ?? *[Branch Name]+5q   $   5r      ?? 5u      $ 
Horizontal=?6!   $??0,0,0,8q?6:   .+?5v      ?? -   5        $ brCode??5v   $   $??Center=?5x   $   $
??Bold"?5y   $   $??12(?5z   $   ??5w   $   ?? *[Branch Code]+5z   $   5{      5?      5?      5?      5?      5?      