   M S B A M L   `   `   `  ����P  LNewEra.DepoSimulasyon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:NewEra.DepoSimulasyonNewEra.DepoSimulasyon  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   %    NewEra.DepoSimulasyon.WindowRaf   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:NewEra.DepoSimulasyon     5   	   e aDevExpress.Xpf.Carousel.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxca6http://schemas.devexpress.com/winfx/2008/xaml/carousel  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	     � Title$  	WindowRaf��5   	   $	��500��6   $	��800��6(    � 	Resources 5      ��%    5      .��5      � -   5         �Name$ MyGrid��5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   .+�5   
   � -   5        $ GridRafOran��5       � ShowGridLines .  $��0��6:   $��0��6J    5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��2* �6     5!      �� 5"      $��1* �6#   �� 5#      $��2* �6#   �� 5$      $��1* �6#   �� 5%      $	��15* �6#   .+�5(      �� -   5         ��Name$ BtnBack��5(   %   $��GERİ��6   $��Stretch=�67   $��Stretch=�6S   $��1,1,1,1q�5)      $��15(�6"   $
��Bold"�60   $��Center=�6W   $
��Left=�6y   $��0��5*      $��0��6!   $��3��6.   �� 5,      -   5         ��Name$ lblDepoDoluluk��5,   B   $y�Hidden=�6   $��DEPO DOLULUK = ��6(   $��Stretch=�6Z   $��Stretch=�6v   $��5,5,5,5q�6�   $��1��5-      $��0��6(   $��2��65   $��15(�6F   $
��Bold"�6T   $��Center=�6f   $��Center=�6�   
�������5.      �� 5/      -   5        $ lblDepoDolulukOran��5/   7   $y�Hidden=�6   $
��%50 ��6(   $��Stretch=�6S   $��Stretch=�6o   $��5,5,5,5q�6�   $��2��50      $��0��6(   $��2��65   $��Center=�6G   $��Center=�6i   $��15(�6�   $
��Bold"�6�   
���2͚�51      �� 53      -   5        $ lblKatDoluluk��53   A   $y�Hidden=�6   $��KAT DOLULUK = ��6(   $��Stretch=�6X   $��Stretch=�6t   $��5,5,5,5q�6�   $��1��54      $��2��6(   $��Center=�65   $��Center=�6W   $��15(�6{   $
��Bold"�6�   
�������55      �� 56      -   5        $ lblKatDolulukOran��56   7   $y�Hidden=�6   $
��%50 ��6(   $��Stretch=�6R   $��Stretch=�6n   $��5,5,5,5q�6�   $��2��57      $��2��6(   $��Center=�66   $��Center=�6X   $��15(�6}   $
��Bold"�6�   
���2͚�58      �� 5>      -   5        $��	rectangle��5>       K� ZIndex$ -1��6)   $
��auto��6;   $
��auto��6H   
����İ�$��3��6m   $��0��6}   $��3��6�   $��Stretch=�5?      $��Stretch=�64   6T   5A      �� 5H   
   
�������$��Stretch=�6+   $��Stretch=�6I   $��0��6e   $��2��6u   $��2��6�   6�   2  ,DevExpress.Xpf.Carousel.CarouselItemsControl  5K   
   -	   5        	  Name$	 carouselItemsControl1��5K   �   
�������$��Stretch=�6<   $��Stretch=�6Z   $��0��6v   $��1��6�   ��5L      �� 5M      .R�5O      +  %DevExpress.Xpf.Carousel.CarouselPanel  
  Name$
 carousel��5S      $��	0,-50,0,0q�5P         ActivateItemOnClick .  �� BitmapScalingMode$ HighQuality=�5R         AnimationTime$	 400Q�5T         PathPadding$ 10, 20, 10, 20q�5U      }�.    IsInvertedDirection .    PathVisible .     ItemSize$ 170,150��5Y      $��35��5Z      $��50��5[         IsAutoSizeItem .    VisibleItemCount$ 9��5^         AttractorPointIndex$ 4��5_         ItemMovingPath 5a      B� 5b      $����M300.0925,100 C400.0925,0.5 600.5,60.794373 600.5,110.5 C600.5,160.20563 400.0925,200.5 300,200.5 C200.9075,200.5 0.5,160.20563 0.5,110.5 C0.5,60.794373 200.9075,0.5 300,100C�6+   5d      5f      ��5l      �� 5n      .R�5p      �  5q      �� 5r   "   $��1* �60   6>   �� 5s   "   $��1* �60   6>    5u      �� 5w   "   $��1* �63   6A   .+�5z      �� $
��Fill=�6    $��Stretch=�6J   $��Stretch=�6f   $��0��5{       $��0��60   ��5z   0   �� *Img+5{   0   �� 5|      $
��btn1��6�   -
   5        $��20(�5|   %   $
��Bold"�63   
�������$��0��6�   $��1��6�   
 � Tag 6E   �� *Id+��6�   �� *Name+6�   5}      5�      5�      5�      5�      