   M S B A M L   `   `   `  ����J  FFurniture Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Furniture_StoreFurniture_Store  5   	       Furniture_Store.MainPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Furniture_Store     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MainPage��5	   	    � Icon$ Assets/logo.png��6   $	��600��61   $
��1024��6>    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ NoResize=�6p    � WindowStyle$
 None=�6�   .��5
      � -   5        ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��Nice design��6    $��Center=�63   $��20(�6N   $
��20 0q�6\   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5         ��Name$
 Cart��5      $��30��6+   $��30��66   $��0q�6o   
���������6B   Z� ��6X   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$
 Cart=�62   5      �� 5      -   5        $ 
ButtonExit��5      $��30��61   $��30��6<   $��0q�6u   
���������6H   Z� ��6^   Z� .��5        $ Power=�62   5      5!      5"      5#       � 5%   
   -   5          �Name$ 	MainFrame��5%      $��1��6#   $��Stretch=�60   	  � NavigationUIVisibility$	 Hidden=�6N   $��Stretch=�6n   $��250 55 0 10q�6�   � 5@   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5A      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        
  Name$
 TransitioningContentSlide��5A   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5B      � -   5         �Name$ 
GridCursor��5B      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5C      �� 5D      -   5         ��Name$ ListViewMenu��5D      $��0 100q�6-   
������� �� SelectedIndex$ 0��6�   .@�5F      �� $��60��6   .��5G      �� $ 
Horizontal=�6!   .+�5H        $ Chair=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5I      $��Мебель��6$   $��24(�62   $��Center=�6@   $
��20 0q�6[   5J      5K      �� 5M      $��60��6   .��5N      �� $ 
Horizontal=�6!   .+�5O        $ Paper=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5P      $��Заказы��6$   $��24(�62   $��Center=�6@   $
��20 0q�6[   5Q      5R      �� 5T      $��60��6   .��5U      �� $ 
Horizontal=�6!   .+�5V        $ Account=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5W      $��Аккаунт��6$   $��24(�63   $��Center=�6A   $
��20 0q�6\   5X      5Y      �� 5[      $��60��6   .��5\      �� $ 
Horizontal=�6!   .+�5]        $ About=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5^      $��О программе��6$   $��24(�67   $��Center=�6E   $
��20 0q�6`   5_      5`      �� 5b      -   5         ��Name$ 
adminPanel��5b      $y�Hidden=�63   $��60��6G   .��5c      �� $ 
Horizontal=�6!   .+�5d        $ Grade=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5e      $��Админ Панель��6$   $��22(�68   $��Center=�6F   $
��20 0q�6a   5f      5g      5i      5j      5k      5l      