   M S B A M L   `   `   `  ����J  FFurniture Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Furniture_StoreFurniture_Store  5           Furniture_Store.AdminPanel   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Furniture_Store     5        N� Title$  
AdminPanel��5	      .��5      � .+�5   
   �� $��20 0 0 0q�6    �� Orientation$ Vertical=�6'   .+�5      �� $��Center=�6   $!��Добавить товар��65   $��30(�6K   �� 5      $ 
Horizontal=�6   .+�5      �� $	��170��6   $��22(�6(   $��Название: ��66   �� 5      -   5         ��Name$ 	prodTitle��5      $	��200��6-   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��170��6   $��22(�6(   $��
Цена: ��66   �� 5      -   5        $ 	prodPrice��5      $	��200��6-   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��170��6   $��22(�6(   $��Поставщик: ��66   �� 5      -   5        $ prodProvider��5      $	��200��60   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��170��6   $��22(�6(   $��Тип: ��66   �� 5       -   5        $ prodType��5       $	��200��6,   5!      �� 5#      $ 
Horizontal=�6   .+�5$      �� $	��170��6   $��22(�6(   $��Рейтинг: ��66   �� 5%      -   5        $ 
prodRating��5%      $	��200��6.   5&      �� 5(      $��0 10 0 0q�6   $ 
Horizontal=�6+   .+�5)      �� $	��170��6   $��22(�6(   $��Картинка: ��66   �� 5*      -   5         ��Name$ 	uploadImg��5*      $"��Выберите файл...��6,   6G   5+      �� 5-      -   5         ��Name$ filePath��5-   &   $��15(�6   6&   �� 5/      -   5        $ 
addProduct��5/      $!��Добавить товар��6)   $��
100 30 0 0q�6B   $	��150��6V   $
��Left=�6b   6}   �� 51      -	   5        $ toXml��51      $��ITEMS_TO_XML��6$   $��100 20q�6;   $	��150��6K   $
��Left=�6W   6r   �� 53      -
   5        $ fromXml��53   O   $
��Left=�6   $��	100 5 0 0q�60   $	��150��6C   $��XML_TO_ITEMS��6`   6w   56      57      58      