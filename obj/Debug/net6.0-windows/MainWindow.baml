   M S B A M L   `   `   `  ����[  W22-03-2023_WPF_kable_lisp_circle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:_22_03_2023_WPF_kable_lisp_circle!_22_03_2023_WPF_kable_lisp_circle  5   	   2    ,_22_03_2023_WPF_kable_lisp_circle.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:_22_03_2023_WPF_kable_lisp_circle     5   	     � Title$  U-83_F_22-03-2023��5   	   $	��250��6#   $	��293��60    � WindowStartupLocation$ CenterScreen=�6<    � ToolTip$� zввод диаметра кабеля и его имя. получаем lisp файл для загрузки в autocad��6a   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� -   5        $��save_b��5      $��собрать файл��6   $��6��66   $��2��6C   $��3��6S   $��3q�5      6   �� 5    
   -   5        $��textbox1��5       $��3��6"    �� TextWrapping$
 Wrap=�66   " �� VerticalScrollBarVisibility$
 Auto=�5!       �� AcceptsReturn$
 True��5"      $��	-701-1-K2��6'   $��3q�68   $��0��5#      $��1��6"   $��5��6/   5$      �� 5%   
   -   5        $��textbox2��5%      $��3��6"   $
 Wrap=�66   $
 Auto=�5&      $
 True��5'      $��10��6'   $��3q�61   $��4��5(      $��1��6"   $��5��6/   5)      �� 5*   
   $
��Wrap=�6   $��Имя кабеля��6(   $��0��6:   $��3��6J   $��3q�6^   �� 5+   
   $
��Wrap=�6   $!��Диаметр кабеля��6(   $��4��6>   $��3��6N   $��3q�6b   5-      5.      