   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	       Presentation.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��40px �6   6,   �� 5      $
��40px �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��200px �6   6/   .+�5   
   �� -   5         ��Name$ TextBox_NumberLeft��5      $��0��6.   $��0��6;   $��5q�6K   $��18(�6V   6�   �� 5   
   -   5        $ TextBox_NumberRight��5      $��1��6/   $��0��6<   $��5q�6L   $��18(�6W   6�   �� 5   
   -   5         ��Name$ ComboBox_NumberLeftType��5      $��0��64   $��1��6A   $��5q�6Q   $��18(�6\   .@�5      �� $��Integer��6   6/   �� 5      $
��Real��6   6,   5      �� 5   
   -   5        $ ComboBox_NumberRightType��5      $��1��65   $��1��6B   $��5q�6R   $��18(�6]   .@�5      �� $��Integer��6   6/   �� 5      $
��Real��6   6,   5      �� 5!   
   -   5         ��Name$ Label_Result��5!      $��2��6&   $��0��63   $��2��6C   $��18(�6W   6g   5"      5#      