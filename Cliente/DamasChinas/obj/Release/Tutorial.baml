   M S B A M L   `   `   `  ���� F  BDamasChinas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DamasChinasDamasChinas      DamasChinas.Tutorial   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:DamasChinas       � Title$  Tutorial��$��477.305��$��741.134��.��� $��0,0,-6.333,-9q�����  �� ImageSource$ recursos/wood2.jpg��.+��� $��34,39,376,282q�$��recursos/wood 4.jpg��$
��Fill=� J� OpacityMask �� $ recursos/wood 4.jpg���� -    ��Name$ objetivo��$
��Left=�$��	72,77,0,0q�$
��Wrap=�$	��Top=�$��65��$	��245���� $�Objetivo del juego:���� $M�G Llevar las fichas del triángulo correspondiente al triángulo opuesto���� �� �� $��367,39,36,282q�$��recursos/wood 5.jpg��$
��Fill=��� -   $ reglas��$
��Left=�$��
410,77,0,0q�$
��Wrap=�$	��Top=�$��65��$	��272���� $�Reglas del juego:���� $� ���� �� $�El juego soporta 2���� $� ���� $�	jugadores���� �� $7�1El jugador sólo podrá mover una ficha por turno���� $��34,211,379,87q�$��recursos/wood 6.jpg��$
��Fill=� �� $ recursos/wood 4.jpg���� $��367,211,23,87q�$��recursos/wood 7.jpg��$
��Fill=��� -   $ movimientos��$
��Left=�$��
63,232,0,0q�$
��Wrap=�$	��Top=�$	��102��$	��245���� $�Movimientos válidos:���� �� $3�-Mover una ficha a una casilla adyacente libre���� $�.���� �� $���Mover ficha saltando una casilla adyacente ocupada por otra ficha y posandola en la siguiente casilla (con la misma dirección, en caso de que esté vacía)���� �� �� �� �� -   $ puntos��$
��Left=�$��394,232,0,0q�$
��Wrap=�$	��Top=�$	��111��$	��276���� $�Puntos:���� �� $0�*Mover una ficha a un sitio vacío: +20 pts���� �� $�Saltar una ficha: +40 pts���� �� $#�Terminar de mover las fichas:���� �� $,�&1er lugar: +100pts; 2do lugar: +80 pts���� �� $�3er lugar: +60 pts���� $�; 4to lugar: +40 pts���� �� $�5to lugar: +20 pts���� �� �� �� �� �� �� �� �� -    ��Name$ Volver��$��Volver al menú principal��$
��Left=�$��562,408,0,0q�$	��Top=�$	��137�� � Cursor$
 Hand���� -   $ Idioma��$
��Left=�$��
45,386,0,0q�$
��Wrap=�$	��Top=� J� RenderTransformOrigin$ 0.482,0.157&��� $�Idioma���� �� �� -   $	 Esp��$
��Left=�$��
34,410,0,0q�$
��Wrap=�$	��Top=��� $�es MX���� �� �� -   $	 Eng��$
��Left=�$��
81,410,0,0q�$
��Wrap=�$	��Top=��� $�en US���� �� 