   M S B A M L   `   `   `  ����I  EFishController, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FishControllerFishController  5          FishController.FishGrid   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:FishController     5        N� Title$  FishGrid��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      .+�5   
   �� .+�5      �� -   5         ��Name$ 
TBFishType��5   *   $��Вид рыбы: ��6   6*   �� 5      -   5        $ TBMaxTemperature��5   1   $��Max Temperature: ��6   61   �� 5      -   5        $ TBMinTemperature��5   1   $��Min Temperature: ��6   61   �� 5      -   5        $ TBDate��5   &   $��
Дата: ��6   6&   �� 5      -   5        $ TBTemperatureArray��5   -   $��Температура: ��6   6-   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DGFishData��5   A      
IsReadOnly$
 True��6      AutoGenerateColumns$ False��6%   $��1��6U   $��2��6b   $��0��6s   $��3��6�   $��5q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%   	   Header$	 
Время��62   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *Date+6\     5       $
 auto 6%   $	 Факт��62   
 6@   �� *Fact+6[     5!      $
 auto 6%   $	 
Норма��62   
 6A   �� *Normal+6^     5"      $
 auto 6%   $*	 $Отклонение от нормы��62   
 6O   �� *	Deviation+6o   5$      5%      5&      