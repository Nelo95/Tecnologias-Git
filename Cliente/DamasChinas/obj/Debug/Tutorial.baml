   M S B A M L   `   `   `  ����F  BDamasChinas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DamasChinasDamasChinas  5   	       DamasChinas.Tutorial   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DamasChinas     5   	     � Title$  Tutorial��5   	   $��477.305��6   $��741.134��6+   .��5	      � $��0,0,-6.333,-9q�6   ��5
   
   �� 5       �� ImageSource$ recursos/wood2.jpg��6   .+�5   
   �� $��34,39,376,282q�6   $��recursos/wood 4.jpg��6'   $
��Fill=�6D    J� OpacityMask 5      �� 5      $ recursos/wood 4.jpg��6   5      �� 5   
   -   5         ��Name$ objetivo��5      $
��Left=�6&   $��	72,77,0,0q�6A   $
��Wrap=�6T   $	��Top=�6h   $��65��6�   $	��245��6�   �� 6�   $�Objetivo del juego:��6�   �� 6�   $M�G Llevar las fichas del triángulo correspondiente al triángulo opuesto��6�   �� 6  �� 6  6   �� 5   
   $��367,39,36,282q�6   $��recursos/wood 5.jpg��6'   $
��Fill=�6D   �� 5   
   -   5        $ reglas��5      $
��Left=�6$   $��
410,77,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   $��65��6   $	��272��6�   �� 6�   $�Reglas del juego:��6�   �� 6�   $� ��6�   �� 6�   �� 6�   $�El juego soporta 2��6�   �� 6�   $� ��6�   �� 6  $�	jugadores��6  �� 6  �� 6$  $7�1El jugador sólo podrá mover una ficha por turno��6(  6b  �� 5   
   $��34,211,379,87q�6   $��recursos/wood 6.jpg��6'   $
��Fill=�6D    5      �� 5      $ recursos/wood 4.jpg��6   5      �� 5   
   $��367,211,23,87q�6   $��recursos/wood 7.jpg��6'   $
��Fill=�6D   �� 5   
   -   5        $ movimientos��5      $
��Left=�6)   $��
63,232,0,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $	��102��6�   $	��245��6�   �� 6�   $�Movimientos válidos:��6�   �� 6�   �� 6�   $3�-Mover una ficha a una casilla adyacente libre��6�   �� 6  $�.��6  �� 6  �� 6"  $���Mover ficha saltando una casilla adyacente ocupada por otra ficha y posandola en la siguiente casilla (con la misma dirección, en caso de que esté vacía)��6&  �� 6�  �� 6�  �� 6�  �� 6�  6�  �� 5   
   -   5        $ puntos��5      $
��Left=�6$   $��394,232,0,0q�6?   $
��Wrap=�6T   $	��Top=�6h   $	��111��6�   $	��276��6�   �� 6�   $�Puntos:��6�   �� 6�   �� 6�   $0�*Mover una ficha a un sitio vacío: +20 pts��6�   �� 6�   �� 6�   $�Saltar una ficha: +40 pts��6  �� 6%  �� 61  $#�Terminar de mover las fichas:��65  �� 6\  �� 6h  $,�&1er lugar: +100pts; 2do lugar: +80 pts��6l  �� 6�  �� 6�  $�3er lugar: +60 pts��6�  �� 6�  $�; 4to lugar: +40 pts��6�  �� 6�  �� 6�  $�5to lugar: +20 pts��6�  �� 6  �� 6"  �� 6(  �� 64  �� 6:  �� 6F  �� 6L  �� 6X  6_  �� 5   
   -   5         ��Name$ Volver��5      $��Volver al menú principal��6!   $
��Left=�6D   $��562,408,0,0q�6_   $	��Top=�6t   $	��137��6�    � Cursor$
 Hand��6�   �� 5   
   -   5        $ Idioma��5      $
��Left=�6$   $��
45,386,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g    J� RenderTransformOrigin$ 0.482,0.157&�6   �� 6�   $�Idioma��6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $	 Esp��5      $
��Left=�6!   $��
34,410,0,0q�6<   $
��Wrap=�6P   $	��Top=�6d   �� 6�   $�es MX��6�   �� 6�   �� 6�   6�   �� 5    
   -   5        $	 Eng��5       $
��Left=�6!   $��
81,410,0,0q�6<   $
��Wrap=�6P   $	��Top=�6d   �� 6�   $�en US��6�   �� 6�   �� 6�   6�   5"      5#      