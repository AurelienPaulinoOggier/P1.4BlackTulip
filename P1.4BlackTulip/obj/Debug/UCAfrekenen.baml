   M S B A M L   `   `   `  ����I  EP1.4BlackTulip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:P1._4BlackTulipP1._4BlackTulip  5      !    P1._4BlackTulip.UCAfrekenen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:P1._4BlackTulip     5      .��5	      � -   5          �Name$  GridAfrekenen��5	      $	��758��6"   $	��369��6.   ���	#FFF9EAEA.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgProducten��5
      $��Right=�6(   $	��311��6D   $��	0,48,10,0q�6Q   $	��Top=�6d   $	��303��6|      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ product��6q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *product.product_naam+   ClipboardContentBinding 6N   Z� 6q     5      $ Datum��6n    6%   �� *bestelling.datum+ 6K   Z� 6n     5      $ Aantal��6m    6%   �� *item.hoeveelheid+ 6J   Z� 6m     5      $ Totaal��6m    6%   �� *item.hoeveelheid+ 6J   Z� 6m   5        5   
   -   5        $ 	dgklanten��5      $
��Left=�6&   $	��317��6A   $��	10,48,0,0q�6N   $	��Top=�6a   $	��246��6y    .   .   5        5      $ Klant��6a    6%   �� *naam+ 6>   Z� 6a   5      �� 5   
   -   5         ��Name$ 	txtZoeken��5      $
��Left=�6%   $��23��6@   $��	10,14,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��175��6�   �� 5   
   -   5        
 ��Name$
 	btnZoeken��5      $��Zoeken��6$   $
��Left=�65   $��
189,10,0,0q�6P   $	��Top=�6d   $��67��6|   $��35��6�   6�   �� 5   
   -   5        $ 
txtZoekenB��5      $
��Left=�6&   $��23��6A   $��
445,14,0,0q�6M   $
	 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��232��6�   �� 5   
   -   5        $
 
btnZoekenB��5      $��Zoeken��6%   $��35��66   $
��Left=�6B   $��	682,8,0,0q�6]   $	��Top=�6p   $��67��6�   6�   5      5      