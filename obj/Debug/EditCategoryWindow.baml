   M S B A M L   `   `   `  ����K  GServiceCentreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ServiceCentreWPFServiceCentreWPF  5   	   )    #ServiceCentreWPF.EditCategoryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ServiceCentreWPF     5   	   -   5          � Title$5  /Редактирование категории��5   	   $	��210��6*   $	��290��67    � 
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
   �� 5      $	��274 �6    � RowDefinitions 5   
   �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5'   
   �� -   5        	 ��Name$	 label1EditCategory��5'      $<��6Выберите категорию из списка:��6,   $��0��6T   $��0��6a   $
��Left=�6q   $��Center=�6�   $��26��6�   $	��0,2q�6�   $	��211��6�   �� 5(   
   -   5        
 ��Name$
 comboBox1EditCategory��5(      $��0��62   $
��Left=�6B   $��22��6]   $��5,4,5,4q�6i   $��1��6z   $��Center=�6�   $	��264��6�   �� 5)   
   -   5         ��Name$ bt_EditEditCategory��5)      $��Изменить��6.   $��Center=�6A   $��2��6^   $��Center=�6k   $��75��6�   6�   �� 5*   
   -   5        $	 label2EditCategory��5*      $%��Новое имя бренда:��6,   $��3��6H   $��0��6U   $
��Left=�6e   $��Center=�6�   $��26��6�   $	��0,2q�6�   $	��211��6�   �� 5+   
   -   5         ��Name$ textBox1EditCategory��5+      $��0��60   $
��Left=�6@   $��22��6[   $��5,4,5,4q�6g   $��4��6x   $��Center=�6�   $	��264��6�   �� 5,   
   -   5        $ bt_SaveEditCategory��5,      $��Сохранить��6.   $��Center=�6B   $��5��6_   $��Center=�6l   $��75��6�   6�   5/      50      