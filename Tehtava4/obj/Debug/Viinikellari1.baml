   M S B A M L   `   `   `  ����C  ?Tehtava4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Tehtava4Tehtava4  5   	       Tehtava4.Viinikellari1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tehtava4     5   	     � Title$  XMLViinikellari��5   	   $��557.763��6!   $	��525��62   $��16(�6>   .��5	      �  � 	Resources 5
   
      wineData � Source � XPath��%L   &	        � 5      $ Viinit1.xml?�6/   $ viinikellari/wine��6D   5      .+�5   
   �� -   5         ��Name$ buttonSearch��5      $��
Hae viinit��6'   $
��Left=�6<   $��	10,10,0,0q�6W   $	��Top=�6j   $	��153��6�   $��16(�6�   6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6^   $��
168,10,0,0q�6y   $	��Top=�6�   $	��142��6�   $��16(�6�   ��6%   ��  �� Source# [  ��5      �� 5      .R�5      �� ��6    ��  �� XPath$	 maa��5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      	 � DataContext#	 [  6%   
   AutoGenerateColumns
 .  $��10,42,10,48q�6�   $	��438��6�   $��Center=�6�   $��1q�6�   ��6M   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Viini��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� $
 nimi��  5      $	 Maa��6%    62   �� $	 maa��  5      $ Pisteet��6%    66   �� $ arvio��5      �� 5   
   $��43��6   $
��10,0q�6    $��Bottom=�6.   $��16(�6I   .@�5      �� -   5         ��Name$ 
statusText��5      5      5       5!      