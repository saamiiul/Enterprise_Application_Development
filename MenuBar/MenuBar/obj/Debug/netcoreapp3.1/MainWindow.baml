   M S B A M L   `   `   `  ����B  >MenuBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MenuBarMenuBar  5   	       MenuBar.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MenuBar     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� 
�������.+�5
   
   o� $	��Top=�6   $��18(�6$   ���	#FFF9A4A4.@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ newItem��5      $	��New��6,   69   m� 5      -   5        $ openItem��5      $
��Open��6-   6T   m� 5      -   5        $ 	closeItem��5      $��Close��6.   6W   5      m� 5      -   5        $ editItem��5      $
��Edit��6)   6P   m� 5      -   5        $ viewItem��5      $
��View��6)   6P   5      �� 5   
   $��Bottom=�6   $��Copy right 2020��6(   $��Center=�6B   ���	#FFECD15B6   � 5   
    � ShowGridLines$ False��6   $��Center=�6&   $��Center=�6D    � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    61   .+�5      �� -   5         ��Name$ number01��5      $��0��6(   $��Enter Number��65   $	��220��6L   $��0,0,0,10q�6X   $��30��6j   $��20(�6v   $��Arial)�6�   ���#f5f0e1���	#FFBDB9B9 �� 
CaretBrush# � ��6�   6K  �� 5      -   5        $ number02��5      $��1��6(   $��Enter Number��65   $	��220��6K   $��0,0,0,10q�6W   $��30��6i   $��Arial)�6u   $��20(�6�   ���#f5f0e1���	#FFBDB9B9# � ��6�   6J  �� 5      -   5         ��Name$	 sum��5      $��2��6#   $	��Sum��60   $��3,0,0,0q�6@   $��50��6Q   $
��Left=�6\   $��Center=�6w   $��30��6�   6�   �� 5      -	   5        $ minus��5      $��2��6%   $��Minus��62   $��0,0,55,0q�6D   $��50��6V   $��Center=�6a   $��Center=�6~   $��30��6�   6�   �� 5      -
   5        $ multiply��5      $��2��6(   $��Mltiply��65   $��55,0,0,0q�6J   $��50��6\   $��Center=�6g   $��Center=�6�   $��30��6�   6�   �� 5       -   5        $ devide��5       $��2��6&   $��Devide��63   $��0,0,3,0q�6F   $��50��6W   $��Right=�6b   $��Center=�6~   $��30��6�   6�   5!      5"      5#      