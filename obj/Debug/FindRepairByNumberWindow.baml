   M S B A M L   `   `   `  ����K  GServiceCentreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ServiceCentreWPFServiceCentreWPF  5   	   /    )ServiceCentreWPF.FindRepairByNumberWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ServiceCentreWPF     5   	     � Title$1  +Поиск ремонта по номеру��5   	   $	��120��6)   $	��360��66    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X    � 	Resources 5	       �� 
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
   �� -   5        	 ��Name$	 label1FindRepairByNumber��5$      $/��)Введите номер ремонта:��62   $��0��6S   $��0��6`   $
��Left=�6p   $��Center=�6�   $��26��6�   $��0,1,0,2q�6�   $	��211��6�   �� 5%   
   -   5        
 ��Name$,
 &textBox_NumberRepairFindRepairByNumber��5%      $��0��6B   $
��Left=�6R   $��22��6m   $	��5,4q�6y   $��1��6�    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��264��6�   �� 5&   
   -   5         ��Name$ bt_OKFindRepairByNumber��5&      $��Искать��62   $��1��6C   $��Center=�6S   $��Center=�6p   $��75��6�   $��74��6�   $��2��6�   6�   5(      5)      