   M S B A M L   `   `   `  ����F  BDamasChinas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DamasChinasDamasChinas  5   	   #    DamasChinas.AdministrarCuenta   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DamasChinas     5   	     � Title$  Información de la cuenta��5   	   $��387.981��6*   $��523.558��6;   ��5	      �� 5
   
    �� ImageSource$ recursos/wood2.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��153* �6   .+�5   
   �� -   5         ��Name$ Informacion��5      $
��Left=�6)   $��	57,35,0,0q�6D   $
��Wrap=�6W   $	��Top=�6k   $	��148��6�   $��2��6�   �� 6�   $�Información ��6�   �� 6�   $�personal��6�   6�   �� 5   
   -   5        $ Nombre��5      $
��Left=�6$   $��	57,98,0,0q�6?   $
��Wrap=�6R   $��Nombre��6f   $	��Top=�6t   $��2��6�   �� 5   
   -   5        $ Usuario��5      $
��Left=�6%   $��
57,136,0,0q�6@   $
��Wrap=�6T   $	��Top=�6h   $��14��6�   $��2��6�   �� 6�   $�Usuario��6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $ Contraseña��5      $
��Left=�6(   $��
57,176,0,0q�6C   $
��Wrap=�6W   $��Contraseña��6k   $	��Top=�6}   $��2��6�   �� 5   
   -   5         ��Name$ actualizarInformacion��5      $��Actualizar información��60   $
��Left=�6Q   $��37.623,213,0,0q�6l   $	��Top=�6�   $	��129��6�   $��1��6�    � Cursor$
 Hand��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5        $
 Baja��5      $��Darse de baja��6   $
��Left=�67   $��295.667,213,0,0q�6R   $	��Top=�6k   $��95��6�   $��1��6�   $
 Hand��6�   �� 5   
   -   5        $ regresarBttn��5      $��Regresar��6'   $��295.667,255,68.667,0q�6:   $	��Top=�6X   $��1��6p   $
 Hand��6�   �� 5   
   -   5        $ Idioma��5      $
��Left=�6$   $��
29,276,0,0q�6?   $
��Wrap=�6S   $��Idioma��6g   $	��Top=�6u   $��2��6�   $��94��6�   �� 5   
   -	   5        $	 Esp��5      $
��Left=�6!   $��
29,297,0,0q�6<   $
��Wrap=�6P   $��es MX��6d   $	��Top=�6q   $��2��6�   $��69��6�   6�   �� 5   
   -
   5        $	 Eng��5      $��1��6!   $
��Left=�61   $��40.667,297,0,0q�6L   $
��Wrap=�6d   $��en US��6x   $	��Top=�6�   G� 5   
   $��1��6   $
��Left=�6&   $��129.2,176,0,0q�6A   $	��Top=�6X   $	��120��6p    G� Password$ edwin��6|   {�.  6�   �� 5   
   $��1��6   $
��Left=�6"   $��23��6=   $��129.2,84,0,0q�6I    �� TextWrapping$
 Wrap=�6_   $��Edwin��6s   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   $��1��6   $
��Left=�6"   $��23��6=   $��129.2,127,0,0q�6I   $
 Wrap=�6`   $��Edwin��6t   $	��Top=�6�   $	��120��6�   {�.  6�   5      5       