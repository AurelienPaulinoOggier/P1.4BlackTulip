   M S B A M L   `   `   `  ����I  EP1.4BlackTulip, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:P1._4BlackTulipP1._4BlackTulip  5          P1._4BlackTulip.UCKlant   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:P1._4BlackTulip     5      .��5
      � -   5          �Name$  	GridKlant��5
      $	��758��6   $	��369��6*   ���	#FFF9EAEA.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgKlant��5      $
��Left=�6$   $	��312��6?   $	��263��6L   $��	10,10,0,0q�6X   $	��Top=�6k      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ klant��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *naam+   ClipboardContentBinding 6>   Z� 6a     5      $
 stad��6a    6%   �� *stad+ 6>   Z� 6a   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 btnWijzigen��6%   -   5        $��Wijzigen��5   :   6M   5      5        5       5      �� 5      .R�5      �� $	 btnVerwijderen��6%   -   5        $��Delete��5   =   6N   5      5      5#      �� 5$   
   -   5        $	 btnToevoegen��5$      $��	Toevoegen��6'   $��Center=�6;   $��10,0,485,10q�6X   $��Bottom=�6m   $	��263��6�   $��32��6�   
 J� RenderTransformOrigin$
 0.415,0.503&�6�   6�     5%   
   -   5        $ Klant��5%      $��Right=�6"   $	��309��6>   $	��269��6K   $��	0,50,10,0q�6W   $	��Top=�6j    .   .  ��5&      �� 5'       �� ImageSource$ BlackTulipR.jpg��6    5)        5*      $ klant��6a    6%   �� *naam+ 6>   Z� 6a     5+      $
 stad��6a    6%   �� *stad+ 6>   Z� 6a     5,      $	 mob��6j    6%   �� *mobielenummer+ 6G   Z� 6j     5-      $ e-mail��6c    6%   �� *e_mail+ 6@   Z� 6c   50      �� 52   
   -   5         ��Name$ 	txtZoeken��52      $��Right=�6%   $��23��6A   $��	0,14,82,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��197��6�   �� 53   
   -   5        $	 	btnZoeken��53      $��Zoeken��6$   $��Right=�65   $��	0,10,10,0q�6Q   $	��Top=�6d   $��67��6|   $��35��6�   6�   � 54   
   -	   5        $
  gPwt��54      $
��Left=�6   $	��196��68   $	��309��6D   $��
278,50,0,0q�6Q   $	��Top=�6e   ��55      �� 56      $ BlackTulipR.jpg��6   58      5:      5;      