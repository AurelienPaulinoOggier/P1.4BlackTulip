   M S B A M L   `   `   `  ����I  EP1.4BlackTulip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:P1._4BlackTulipP1._4BlackTulip  5          P1._4BlackTulip.UCProduct   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:P1._4BlackTulip     5      .��5
      � -   5          �Name$  GridProduct��5
      $	��758��6    $	��369��6,   ���	#FFF9EAEA.+�5   
   �� -   5         ��Name$ btnToevoegen��5      $��	Toevoegen��6'   $��Center=�6;   $��10,0,413,10q�6X   $��Bottom=�6m   $	��335��6�   $��32��6�    J� RenderTransformOrigin$ 0.415,0.503&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Product��5      $��Right=�6$   $	��309��6@   $	��189��6M   $��	0,50,10,0q�6Y   $	��Top=�6l      AutoGenerateColumns .     CanUserAddRows .  ��5      �� 5       �� ImageSource$ BlackTulipR.jpg��6      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   ClipboardContentBinding 6)   Z� 	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 plaatje��6$   $��50��6S   $��50��6^   ��65   �� *
afbeelding+6^   5      5      0  *System.Windows.Controls.DataGridTextColumn  5         Header$
 Naam��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *product_naam+   ClipboardContentBinding 6F   Z� 6i     5      $	 Cat��6u    6%   �� *producttype.omschrijving+ 6R   Z� 6u     5      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b   5      �� 5!   
   -   5         ��Name$ 	txtZoeken��5!      $��Right=�6%   $��23��6A   $��	0,14,65,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��134��6�   �� 5"   
   -   5        $ 	btnZoeken��5"      $��Zoeken��6$   $��Right=�65   $��	0,10,10,0q�6Q   $	��Top=�6d   $��50��6|   $��35��6�   6�     5$   
   -   5        $ 	dgProduct��5$      $
��Left=�6&   $	��312��6A   $	��335��6N   $��	10,10,0,0q�6Z   $	��Top=�6m    .   .   5%        5'       6)   Z� 	 5(      �� 5)      .R�5*      �� $
 plaatje��6$   $��50��6S   $��50��6^   ��65   �� *
afbeelding+6^   5+      5-        5/      $
 Naam��6i    6%   �� *product_naam+ 6F   Z� 6i     50      $	 Cat��6u    6%   �� *producttype.omschrijving+ 6R   Z� 6u     51      $ prijs��6b    6%   �� *prijs+ 6?   Z� 6b     53      	 54      �� 55      .R�56      �� $ btnWijzigen��6%   -   5        $��Wijzigen��56   :   6M   57      59        5;      	 5<      �� 5=      .R�5>      �� $ btnVerwijderen��6%   -   5        $��Delete��5>   =   6N   5?      5A      5D      � 5E   
   -	   5        $
  gPwt��5E      $
��Left=�6   $	��196��68   $	��309��6D   $��
355,50,0,0q�6Q   $	��Top=�6e   ��5F      �� 5G      $ BlackTulipR.jpg��6   5I      5K      5L      