   M S B A M L   `   `   `  ����T  PNewEraDepoTemplateCreater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:NewEraDepoTemplateCreaterNewEraDepoTemplateCreater  5   	   0    *NewEraDepoTemplateCreater.WindowRafOlustur   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:NewEraDepoTemplateCreater     5   	   -   5          � Title$  WindowRafOlustur��5   	   $	��367��6"   $	��500��6/    � WindowStyle$ 
ToolWindow=�6;    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� $��	RAF ADI :��6   $��Stretch=�6$   $��Stretch=�6@   $��20(�6^   $��
10,10,10,5q�6l   $
��Bold"�5      $��Center=�6"   $��Center=�6D   $��0��6h   $��0��6x   
�������$��1q�5      
���   �6:   �� 5   
   -   5         ��Name$ 	LblRenkAd��5      $
��Aqua��6%   $��20(�64   $
��Bold"�6B   $��0��6T   $��2��6d   
�������$��	10,5,10,5q�6�   $��Stretch=�5      $��Center=�6-   $��Stretch=�6O   $��Center=�6m   $��1q�5      
���   �6;   �� 5   
   $��RAF ALİAS :��6   $��20(�6)   $
��Bold"�67   $��0��6I   $��1��6Y   
�������$��	10,5,10,5q�6   $��Stretch=�5      $��Center=�6-   $��Stretch=�6O   $��Center=�6m   $��1q�5      
���   �6;   �� 5    
   -   5         ��Name$ 	TextRafAd��5       $��20(�6%   $
��Bold"�63   $��1��6E   $��0��6U    �� TextAlignment$
 Left=�6b   
�������$��Stretch=�5!      $��Stretch=�6.   $��
10,10,10,5q�6M   $��1q�6a   
���   �6�   �� 5#   
   -   5        $ TextRafAdAdlias��5#      $��20(�6+   $
��Bold"�69   $��1��6K   $��1��6[   $
 Left=�6h   
�������$��Stretch=�5$      $��Stretch=�6.   $��
10,10,10,5q�6M   $��1q�6a   
���   �6�   �� 5&   
   -   5        $ LblRenk��5&      $��1��6"   $��2��62   $��Stretch=�6?   $��Stretch=�6[   $��	10,5,10,5q�6y   
����� �$��1q�5'   B   
���   �6l   �� 5)   
   -   5         ��Name$ 	BtnKaydet��5)      $	��250��6$   $��50��60   $��20(�6<   $
��Bold"�6J   $��0��6\   $��2��6l   $��3��6�   $
��EKLE��5*      $��
10,5,10,10q�6    $��1q�64   
���   �6v   �� 5+   
   -   5        $ BtnGuncelle��5+      $y�Hidden=�6&   $	��250��6:   $��50��6F   $��20(�6R   $
��Bold"�6`   $��0��6r   $��2��6�   $��3��6�   $��	GÜNCELLE��5,      $��
10,5,10,10q�6$   $��1q�68   
���   �6z   �� 5-   
   -   5        $ BtnSil��5-      $	��250��6!   $��50��6-   $��20(�69   $
��Bold"�6G   $��0��6Y   $��2��6i   $��4��6}   $
��SİL��5.      $��
10,5,10,10q�6   $��1q�63   
���   �6u   5/      50      