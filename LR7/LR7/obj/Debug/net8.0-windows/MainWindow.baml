   M S B A M L   `   `   `  ����>  :LR7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LR7LR7  5   	   G(clr-namespace:LR7.Resources.LocalizationLR7.Resources.Localization  5   	       LR7.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LR7     5   	   8loc(clr-namespace:LR7.Resources.Localization     5   	     � Icon$   /Resources/Images/logo.png��5	   	   (   "LR7.Resources.Localization.Strings   MainWindow_Title � Title# Z 5
   	   $	��450��5   	   $	��800��5   	    
  Window#���   5   	    J� InputBindings 5      �� 5   
    �� CommandParameter$	 RTF��69    �� Command 6   �� *OpenFileCommand+ �� Gesture 5      ��5      
Ctrl+O��6%   5      �� 5   
   $	 TXT��69    6   �� *SaveFileCommand+ 5      ��5      
Ctrl+S��6%   5      .��5      �  � RowDefinitions 5   
   �� 5      $��18 �6   6*   �� 5      $��30 �6   6*   �� 5       $��* �6   6)   �� 5!      $��22 �6   6*   .+�5$   
   o� $��0��6   .@�5%      m�    MainWindow_Menu_File#��Z 6   .@�5&      m�  	   MainWindow_Menu_File_Open#��Z	 6   .@�5(      m� $
   MainWindow_Menu_File_Open_Rtf#��Z
 6    m� CommandParameter$	 RTF��5*       m� Command 5)      �� *OpenFileCommand+5*   8   m� 5,      $   MainWindow_Menu_File_Open_Txt#��Z 6   $	 TXT��5.       5-      �� *OpenFileCommand+5.   8   5/      m� 51          MainWindow_Menu_File_Save#��Z 6   .@�53      m� $   MainWindow_Menu_File_Save_Rtf#��Z 6   $	 RTF��55       54      �� *SaveFileCommand+55   8   m� 57      $   MainWindow_Menu_File_Save_Txt#��Z 6   $	 TXT��59       58      �� *SaveFileCommand+59   8   5:      5;      m� 5=         MainWindow_Menu_Edit#��Z 6   .@�5?      m� .   'MainWindow_Menu_Edit_SyntaxHighlighting#��Z 6   .@�5A      m� 1   *MainWindow_Menu_Edit_SyntaxHighlighting_On#��Z 6   $
 true��5C       5B      �� *SetSyntaxHighlightingCommand+5C   9   m� 5E      2   +MainWindow_Menu_Edit_SyntaxHighlighting_Off#��Z 6   $ false��5G       5F      �� *SetSyntaxHighlightingCommand+5G   :   5I      5J      m� 5L         MainWindow_Menu_Theme#��Z 6   .@�5N      m� !   MainWindow_Menu_Theme_Dark#��Z 6   $! /Resources/Themes/Dark.xaml��5P       5O      �� *ChangeThemeCommand+5P   L   m� 5R      "   MainWindow_Menu_Theme_Light#��Z 6   $" /Resources/Themes/Light.xaml��5T       5S      �� *ChangeThemeCommand+5T   M   5U      m� 5W         MainWindow_Menu_Language#��Z 6   .@�5Y      m� '    MainWindow_Menu_Language_English#��Z 6   $ en��5[       5Z      �� *ChangeLanguageCommand+5[   3   m� 5]      )   "MainWindow_Menu_Language_Ukrainian#��Z 6   $ uk-UA��5_       5^      �� *ChangeLanguageCommand+5_   6   5`      5a      c� 5c   
   $��1��6   .@�5e      �� -   5         ��Name$ ComboBox_FontFamily��5e      $	��100��64     ComboBox#���  6C   $��
2, 0, 2, 0q�6f   5g      �� 5i      -   5        $ ComboBox_FontSize��5i      $��70��62   #���  6@   $��
2, 0, 2, 0q�6c    �� 
IsEditable$
 True��6x   5k      �� 5m      d� 5o      -   5         d�Name$ Button_Bold��5o      $��
2, 0, 3, 0q�60   $ ��EditingCommands.ToggleBold��5p      .��5q      �� $
��Bold"�6   $��22(�6.    �� LineStackingStrategy$ BlockLineHeight=�6<    �� 
LineHeight$ 22��6c   $��2,0,2,0q�6s   B5s      5t      d� 5v      -   5        $ Button_Italic��5v      $��
2, 0, 3, 0q�62   $"��EditingCommands.ToggleItalic��5w      .��5x      �� $��Italic$�6   $��22(�6/   $ BlockLineHeight=�6=   $ 22��6d   $��4,0,4,0q�6t   I5z      5{      d� 5}      -   5        $ Button_Underline��5}      $��
2, 0, 3, 0q�65   $%��EditingCommands.ToggleUnderline��5~      .��5      �� $��	Underline{�6   $��20(�68   $ BlockLineHeight=�6F   $ 20��6m   $��2,0,2,0q�6}   U5�      5�      d� 5�      -   5        $ Button_Image��5�      $��22��61   $��22��6=   $��
2, 0, 3, 0q�6H   $	��PNG��5�      ��5�      �� *InsertImageCommand+��5�      �� 5�        �� ImageSource$!  /Resources/Images/image.png��6!   ! j� Stretch$
! Fill=�6K   5�      d� 5�      -   5        $ Button_Allign_Left��5�      $��22��67   $��22��6C   $��
2, 0, 3, 0q�6N   $
��Left��5�      ��5�      �� *SetTextAligmentCommand+��5�      �� 5�      $&   /Resources/Images/align-left.png��6!   $
! Fill=�6P   5�      d� 5�      -   5        $ Button_Allign_Center��5�      $��22��69   $��22��6E   $��
2, 0, 3, 0q�6P   $��Center��5�      ��5�      �� *SetTextAligmentCommand+��5�      �� 5�      $"  /Resources/Images/format.png��6!   $
! Fill=�6L   5�      d� 5�      -	   5        $ Button_Allign_Right��5�      $��22��68   $��22��6D   $��
2, 0, 3, 0q�6O   $��Right��5�      ��5�      �� *SetTextAligmentCommand+��5�      �� 5�      $'  !/Resources/Images/align-right.png��6!   $
! Fill=�6Q   5�      d� 5�      -
   5        $ Button_Allign_Justify��5�      $��22��6:   $��22��6F   $��
2, 0, 3, 0q�6Q   $��Justify��5�      ��5�      �� *SetTextAligmentCommand+��5�      �� 5�      $#  /Resources/Images/justify.png��6!   $
! Fill=�6M   5�      5�      �� 5�   
   -   5        " ��Name$" RichTextBox_Content��5�      $��2��63   5�      �� 5�   
   $��3��6   .@�5�      �� #   MainWindow_Status_Words#��Z# 6   6P   �� 5�      -   5        $ ��Name$$ TextBlock_Words��5�      064   �� 5�       %   MainWindow_Status_Letters#��Z% 6   6R   �� 5�      -   5        $$ TextBlock_Letters��5�      066   5�      5�      5�      