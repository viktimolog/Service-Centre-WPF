   M S B A M L   `   `   `  ����K  GServiceCentreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ServiceCentreWPFServiceCentreWPF  5   	   %    ServiceCentreWPF.AddBrandWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ServiceCentreWPF     5   	   -   5          � Title$4  .Добавление нового бренда��5   	   $	��160��6*   $	��380��67    � 
ResizeMode$ NoResize=�6C    � WindowStartupLocation$ CenterScreen=�6Y    � 	Resources 5	       �� 
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
   �� 5      $	��92* �6   �� 5      $	��30* �6    � RowDefinitions 5   
   �� 5       �� 5!      �� 5"      �� 5#      .+�5&   
   �� -   5        	 ��Name$	 label1AddBrand��5&      $3��-Введите название Бренда:��6(   $��0��6K   $��0��6X   $
��Left=�6h   $��Center=�6�   $��26��6�   $	��0,2q�6�   $	��211��6�   �� 5'   
   -   5        
 ��Name$
 textBox1AddBrand��5'      $��0��6,   $
��Left=�6<   $��22��6W   $��5,4,0,4q�6c   $��1��6t    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��264��6�   �� 5(   
   -   5        $	 label2AddBrand��5(      $<��6Выберите категорию из списка:��6(   $��2��6P   $��0��6]   $
��Left=�6m   $��Center=�6�   $��26��6�   $��0,1,0,2q�6�   $	��211��6�   �� 5)   
   -   5         ��Name$! comboBox_CategoriesAddBrand��5)      $��0��68   $
��Left=�6H   $��22��6c   $��5,4,0,4q�6o   $��3��6�   $��Center=�6�   $	��264��6�    �� DisplayMemberPath$ NameCategory��6�   ��6�   �� *NameCategory+�� 5*   
   -   5         ��Name$ bt_AddBrandAddBrand��5*      $��Добавить��6.   $��1��6A   $��Center=�6Q   $��Center=�6n   $��74��6�   $	��110��6�   $��4��6�   $��8,2,8,2q�6�   6�   5,      5-      