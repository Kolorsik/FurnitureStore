   M S B A M L   `   `   `  ����J  FFurniture Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Furniture_StoreFurniture_Store  5   	       Furniture_Store.LoginForm   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Furniture_Store     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	LoginForm��5	   	   $	��450��6   $	��380��6(    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � Icon$ Assets/logo.png��6    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5      � -   5        .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	LightBlue��6'   	 � Offset$		 0.0Q�69   � 5      $ 	#FF4B4BEE��6'   $	 1Q�69   5      5      �� 5      $	��Top=�6   $��30��61   .+�5      �� -   5        
 ��Name$
 exitBut��5      $��Right=�6*   $��0 0 10 0q�6F   $��30��6X   $��30��6c   $��0q�6�   
���������6o   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Power=�6.   5       5!      �� 5#      $��Center=�6   .+�5$      �� $��Assets/logo.png��6   $��80��61   �� 5%      $��Furniture store��6   $��Light"�63   $��	helvetica)�6F   $��22(�6]   
���   �$��Center=�6~   5&      �� 5(      $��1��6   .+�5*      ��  �� Orientation$ 
Horizontal=�6   .+�5,      �� -   5         ��Name$ loginBox��5,   _   $��	helvetica)�6q   $��Light"�6�   $��
Логин��6�   $��20(�6�   $��Center=�6�   
�������
������ $	��235��6�   $
��Left=�5-       J� Opacity$	 0.5Q�6<   $��30��6J   $��63 0 0 0q�6V     5.      $ Account=�6.   $��Center=�6=   $��Center=�6X   
�������6u   5/      �� 51      $ 
Horizontal=�6   $��0 20 0 0q�66   .+�53      G� -   5         G�Name$ passwordBox��53   f   $��	helvetica)�6{   $��Light"�6�    G� Password$ Password��6�   $��20(�6�   $��Center=�6�   
�������
������ $	��235��6  $
��Left=�54      $	 0.5Q�6<   $��30��6J   $��63 0 0 0q�6V     55      $ TextboxPassword=�6.   $��Center=�6E   $��Center=�6`   
�������6}   56      �� 59      $ 
Horizontal=�6   $��0 50 0 0q�66   .+�5:      �� -   5        $
 loginBut��5:      $	��100��6/   $��40��6;   $��LOGIN��6G   
�������
������ $��	60 0 60 0q�6�   6�   �� 5;      -   5        $
 registerBut��5;      $	��100��62   $��40��6>   $��REGISTER��6J   
�������
������ 6�   5<      5>      5A      5C      5D      