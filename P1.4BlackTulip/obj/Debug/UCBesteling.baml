   M S B A M L   `   `   `  ����I  EP1.4BlackTulip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:P1._4BlackTulipP1._4BlackTulip  5      !    P1._4BlackTulip.UCBesteling   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:P1._4BlackTulip     5      .��5	      � -   5          �Name$  GridBesteling��5	      $	��758��6"   $	��369��6.   ���	#FFF9EAEA.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgFactuur��5
      $
��Left=�6&   $	��254��6A   $��
427,42,0,0q�6N   $	��Top=�6b   $	��321��6z      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   ClipboardContentBinding 6)   Z�    CellTemplate 5      �� 5      .R�5      ��  ��Name$ plaatje��6$   $��50��6S   $��50��6^   ��65   �� *
afbeelding+6^   5      5      0  *System.Windows.Controls.DataGridTextColumn  5         Header$ Product��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *product_naam+   ClipboardContentBinding 6F   Z� 6i     5      $	 Cat��6u    6%   �� *producttype.omschrijving+ 6R   Z� 6u     5      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b     5      $ Hoeveelheid��6L    6)   Z�  5      �� 5      .R�5      �� $ aantal��6$   $��50��65   $��50��6@   5      5      5       �� 5!   
   -   5        	 ��Name$	 cmbKlant��5!      $
��Left=�6B   $��
427,10,0,0q�6]   $	��Top=�6q   $	��321��6�   $��27��6�   
 �� DisplayMemberPath$

 naam��6�   ��6%   �� *naam+6�     5"   
   -   5        $ 	dgProduct��5"      $
��Left=�6&   $	��349��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��248��6y      AutoGenerateColumns .     CanUserAddRows .   5#        5$       6)   Z�  5%      �� 5&      .R�5'      �� $ plaatje��6$   $��50��6S   $��50��6^   ��65   �� *
afbeelding+6^   5(      5*        5,      $ Product��6i    6%   �� *product_naam+ 6F   Z� 6i     5-      $	 Cat��6u    6%   �� *producttype.omschrijving+ 6R   Z� 6u     5.      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b   51      �� 52   
   -   5         ��Name$ txtDatum��52      $
��Left=�6$   $��25��6?   $��427,301,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��137��6�   �� 53   
   -   5         ��Name$ 
btnOpslaan��53      $��Opslaan��6%   $
��Left=�67   $��427,331,0,0q�6R   $	��Top=�6g   $	��321��6   $��28��6�   6�   �� 54   
   -   5        $ 	txtTprijs��54      $
��Left=�6%   $��23��6@   $��569,301,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��116��6�   �� 55   
   $
��Left=�6   $��690,301,0,0q�6/   $
��Wrap=�6D   $��
     Prijs��6X   $	��Top=�6j   $��23��6�   $��58��6�   ���	#FFEE7B7B6�   56      57      