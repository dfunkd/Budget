   M S B A M L   `   `   `  ����F  BBudget.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Budget.ViewBudget.View  5   	   C&clr-namespace:Budget.View.UserControlsBudget.View.UserControls  5   	       Budget.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   )localclr-namespace:Budget.View    5   	   3uc&clr-namespace:Budget.View.UserControls    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  winMain��5
   	   $	��450��5   	    � Title$ 
MainWindow��5   	   $	��800��5   	   .��5      ]� ��. .+�5   
   � $	��Top=�6   $��0q�6$    � ColumnDefinitions 5      �� 5      $��* �6#   .+�5      A� -   5         A�Name$ ugLegend��5      $��1��6,    A� Columns$ 4��6<   $��40��6H   $��2q�6T    A� Rows$ 1��6_   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��
0, 0, 2, 2q�6    $
��Bold"�64   $��Budget��6F   �� 5      $��
0, 0, 2, 0q�6   $��Center=�63   5      �� 5      ���	#44FFFF00���	#FF000000$��1q�6H   ._�5      �� ���	#88000000$��Center=�67   $��0q�6T   $��Bill(s) Due��6_   $��Center=�6r   5      �� 5      ���	#4400FF00���	#FF000000$��1q�6H   ._�5      �� ���	#88000000$��Center=�67   $��0q�6T   $��Payday��6_   $��Center=�6m   5      �� 5      ���	#44FF0000���	#FF000000$��1q�6H   ._�5      �� ���	#88000000$��Center=�67   $��0q�6T   $��Bill(s) Paid��6_   $��Center=�6s   5      5       5!      ]� 5#   
   $��Bottom=�6   ��. 50      �� 52   
   $	��Top=�6   
���   �$��Stretch=�66   $��1��6T   ]� 53   
   $	��Top=�6   ��. .+�54      �� -   5         ��Name$ btnPrevMonth��54   +   $
��Left=�6   $��Previous Month��6A   $��18(�6Z   $
��Bold"�6h   �� 55      -   5        $ btnNextMonth��55   ,   $��Right=�6   $��
Next Month��6B   $��18(�6W   $
��Bold"�6e   �� 56      $
��Left=�6   $��18(�6.   $
��Bold"�6<   $��Center=�6N   ��6k   ��  �� ElementName$ winMain��	 �� Path$	 MonthString�57      � 58   
   -   5        
 �Name$
 
ugCalendar��58      $	��Top=�6#   $��Stretch=�68   $��2q�6V   $��Stretch=�6a    59      �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   �� 5=      $��* �6#   �� 5>      $��* �6#   �� 5?      $��* �6#   �� 5@      $��* �6#    � RowDefinitions 5B      �� 5C      $��35 �6    �� 5D      $��* �6    �� 5E      $��* �6    �� 5F      $��* �6    �� 5G      $��* �6    �� 5H      $��* �6    �� 5I      $��* �6    5�      5�      5�      