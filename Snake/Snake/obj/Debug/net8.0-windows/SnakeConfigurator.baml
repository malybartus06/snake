   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SnakeSnake  5   	       Snake.SnakeConfigurator   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Snake     5   	     � Title$  Snake Configurator��5   	   $	��500��6$   $	��800��61   $	��300��5	   	   $	��300��6      BackgroundColor#��[  5
   	     	TextColor#��[ 5   	     MainFont#��[ 5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ Assets/icon.ico��5   	   .��5      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� -   5        $
��Exit��5      $��0,0,0,15q�67   $
��Left=�6I   $	��Top=�6d   $��4(�6|   �� 5      -   5         ��Name$ OverlayText��5      $��Wybierz kolor��5      $��6(�5      $��Center=�5      $��Center=�5      $
��Wrap=�5      
������5      � 5       $��1��6    � ColumnDefinitions 5"      �� 5#      $��* �6'   �� 5$      $
��Auto �6'   �� 5%      $
��Auto �6'   �� 5&      $
��Auto �6'   �� 5'      $��* �6'   .+�5*      �� -   5        
��� � �$��20��5*   F   $��20��6Q   $��5q�6]   �� 5+      -   5        
��� ���$��20��5+   H   $��20��6S   $��5q�6_   $��1��6j   �� 5,      -   5        
���� ��$��20��5,   H   $��20��6S   $��5q�6_   $��2��6j   5-      5.      5/      50      