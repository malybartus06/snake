   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SnakeSnake  5   	       Snake.MapConfigurator   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Snake     5   	     � Title$  Map Configurator��5   	   $	��500��6"   $	��800��6/   $	��300��5	   	   $	��300��6      BackgroundColor#��[  5
   	     	TextColor#��[ 5   	     MainFont#��[ 5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ Assets/icon.ico��5   	   .��5      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� -   5        $
��Exit��5      $��0,0,0,15q�67   $
��Left=�6I   $	��Top=�6d   $��10(�6|   �� 5      $��Rozmiar Mapy��6   $��Center=�6,   $��16(�6I   $
��0,10q�6W   �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   $��10q�6?   .+�5      �� $��Liczba wierszy: ��6   $��Center=�64   �� 5      -   5         ��Name$ RowsTextBox��5      $��50��6/   $��Center=�6:   $��5q�6U   5      �� 5!      $��2��6   $ 
Horizontal=�6&   $��10q�6?   .+�5"      �� $��Liczba kolumn: ��6   $��Center=�63   �� 5#      -   5        $ ColumnsTextBox��5#      $��50��62   $��Center=�6=   $��5q�6X   5$      �� 5&      -   5         ��Name$	 akt��5&      $��3��6%   $�� ��62   $��Center=�6:   $��8(�6U   �� 5)      -   5        $��4��5)      $��
Potwierdź��6"   $��Center=�6R   $��10q�6o   5*      5+      5-      