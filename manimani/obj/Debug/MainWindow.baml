   M S B A M L   `   `   `  ����C  ?manimani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:manimanimanimani  5   	       manimani.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:manimani     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��3* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  $��2��6   $��Stretch=�6)   $��Stretch=�6G   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 grid��5      $��5��6   $��1��6,   6R   �� 5   
   $��1��6   $��Имя записи��6    $��Stretch=�65   $��1��6S   $	��Top=�6`   �� 5   
   -   5         ��Name$ 
nameOfNote��5      $��1��6&   $��Stretch=�66   $��1��6T   $��Bottom=�6a   �� 5   
   -   5         ��Name$ 
typeOfNote��5      $��1��6$   $��Тип записи��64   $��Stretch=�6I   $��2��6g   $	��Top=�6t   �� 5   
   -   5         ��Name$ types��5      $��1��6"   $��Stretch=�62   $��2��6P   $��Bottom=�6]   �� 5   
   -   5        $��1��5      $��Добавить тип��6!   $��Stretch=�68   $��3��6V   $��Stretch=�6c   6   �� 5    
   $��1��6   $��Сумма денег��6    $��Stretch=�66   $��4��6T   $	��Top=�6a   �� 5!   
   -   5        $ money��5!      $��1��6!   $��Stretch=�61   $��4��6O   $��Bottom=�6\   �� 5"   
   $��1��6   $#��Добавить запись��6!   $��Stretch=�6;   $��5��6Y   $��Bottom=�6f   �� 5#   
   -   5         ��Name$ addNote��5#      $��1��6"   $#��Добавить запись��62   $��Stretch=�6L   $��5��6j   $��Bottom=�6w   6�   �� 5$   
   -   5        $ change��5$      $��1��6!   $��Изменить��61   $��Stretch=�6D   $��6��6b   $��Stretch=�6o   �� 5%   
   -	   5        $ delete��5%      $��1��6!   $!��Удалить запись��61   $��Stretch=�6J   $��7��6h   $��Stretch=�6u   6�   �� 5&   
   $��
Итог: ��6   $��Stretch=�6!   $��6��6?   $��2��6L   $��Center=�6]   5'      5(      