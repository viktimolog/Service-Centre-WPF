   M S B A M L   `   `   `  ����K  GServiceCentreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ServiceCentreWPFServiceCentreWPF  5   	   (    "ServiceCentreWPF.FindByOtherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ServiceCentreWPF     5   	     � Title$-  'Поиск по другим полям��5   	   $	��120��6'   $	��360��64    � 
ResizeMode$ NoResize=�6@    � WindowStartupLocation$ CenterScreen=�6V    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� 2    �� 5
   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 � ���63   �� 5       � ��
 ��  �63   5      �� 5   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 �����63   �� 5       � ��
 �����63   5      �� 5   
   " ��6   .�5      ��  � ��$ Verdana)�63   �� 5       � ��
 �����63   �� 5       � ��
 �   �63   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��264 �6   �� 5      $��79 �6    � RowDefinitions 5   
   �� 5       �� 5!      .+�5$   
   �� -   5        	 ��Name$	 label1FindByOther��5$      $4��.Введите текст для поиска:��6+   $��0��6O   $��0��6\   $
��Left=�6l   $��Center=�6�   $��26��6�   $��0,1,0,2q�6�   $	��211��6�   �� 5%   
   -   5        
 ��Name$
 textBox_FindFindByOther��5%      $��0��63   $
��Left=�6C   $��22��6^   $	��5,4q�6j   $��1��6w    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��264��6�   �� 5&   
   -   5         ��Name$ bt_OKFindByOther��5&      $��Искать��6+   $��1��6<   $��Center=�6L   $��Center=�6i   $��75��6�   $��74��6�   $��2��6�   6�   5(      5)      