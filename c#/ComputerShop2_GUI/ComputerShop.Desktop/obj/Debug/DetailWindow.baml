   M S B A M L   `   `   `  ����O  KComputerShop.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ComputerShop.DesktopComputerShop.Desktop  5   	   '    !ComputerShop.Desktop.DetailWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ComputerShop.Desktop     5   	     � Title$  DetailWindow��5   	   $	��325��6   $	��425��6+   $	��325��67   $	��425��6G   .��5	      � .+�5
   
   �� -   5         ��Name$ 	NameLabel��5
      $��Computer Details��6#   $��Center=�6>   $��0,20,0,0q�6[   $	��Top=�6m   $��24(�6�   
���   �
�������
�������6�   � 5   
   $��Center=�6   $	��160��6,   $��0,67,0,0q�69   $	��Top=�6K   $	��230��6c    � RowDefinitions 5      �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $	��230 �6#   61   .+�5      �� -   5         ��Name$ 
ComputerID��5      $��0��6,   $��0��69   $�� ��6I   
���   � J� OpacityMask
 �����
�������6�   �� 5      -   5        $ ComputerManufacturer��5      $��1��66   $��0��6C   $�� ��6S   
���   �
 �����
�������6�   �� 5      -   5        $ ComputerModel��5      $��2��6/   $��0��6<   $�� ��6L   
���   �
 �����
�������6�   �� 5      -   5        $ ComputerCPU��5      $��3��6-   $��0��6:   $�� ��6J   
���   �
 �����
�������6�   �� 5       -   5        $ ComputerGraphicCard��5       $��4��65   $��0��6B   $�� ��6R   
���   �
 �����
�������6�   �� 5!      -   5        $ ComputerRAM��5!      $��5��6-   $��0��6:   $�� ��6J   
���   �
 �����
�������6�   �� 5"      $��6��6   $��0��6%   
���   �
 �����
���������65   �� *Model+6�   �� 5#      $��7��6   $��0��6%   
���   �
 �����
���������65   �� *DateWhenAddedString+6�   5$      5&      5'      