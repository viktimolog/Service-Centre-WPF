   M S B A M L   `   `   `  ����K  GServiceCentreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ServiceCentreWPFServiceCentreWPF  5   	   (    "ServiceCentreWPF.AddCategoryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ServiceCentreWPF     5   	     � Title$8  2Добавление новой категории��5   	   $	��120��6,   $	��360��69    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6[    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� 2    �� 5
   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 � ���63   �� 5       � ��
 ��  �63   5      �� 5   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 ����63   �� 5       � ��
 �**��63   5      �� 5   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 �����63   �� 5       � ��
 �   �63   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��264 �6   �� 5      $��79 �6    � RowDefinitions 5   
   �� 5       �� 5!      .+�5$   
   �� -   5        	 ��Name$	 label1AddCategory��5$      $D��>Введите название новой категории:��6+   $��0��6W   $��0��6d   $
��Left=�6t   $��Center=�6�   $��26��6�   $��0,1,0,2q�6�   $	��211��6�   �� 5%   
   -   5        
 ��Name$
 textBox1AddCategory��5%      $��0��6/   $
��Left=�6?   $��22��6Z   $	��5,4q�6f   $��1��6s    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��264��6�   �� 5&   
   -   5         ��Name$ button1AddCategory��5&      $��Добавить��6-   $��1��6@   $��Center=�6P   $��Center=�6m   $��75��6�   $��75��6�   $��2��6�   6�   5(      5)      