   M S B A M L   `   `   `  ����M  IHotel Reservations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hotel_ReservationsHotel_Reservations  5   	   '    !Hotel_Reservations.RMConfirmation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Hotel_Reservations     5   	   -   5          �Name$  winRMConfirmation��5   	    � Title$ Confirm Changes��5   	   $	��350��6!   $	��525��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   ��5	      �� 5
   
    �� ImageSource$ images/RMbackground.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ recBackground��5      $
��Left=�6+   $	��321��6F   
���   �$	��Top=�6b   $	��519��6z    J� RenderTransformOrigin$ 0.672,0.554&�6�   ��5      �� 5       �� Color$ 	#FF3A464D��6"    �� Opacity$	 0.6Q�64   	 J� OpacityMask	 5      �� 5      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0.053Q�61   � 5      $ White��6#   $ 0.647Q�61   5      5      �� 5   
   -   5         ��Name$ btnRMConfirm��5      $��Confirm��6'   $
��Left=�69   $��295,276,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ 	btnRMEdit��5      $
��Edit��6$   $
��Left=�63   $��420,276,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5         ��Name$ lblConfirmationLabel��5      $��Room Change Confirmation��6.   $��Center=�6Q   $��22,26,277,0q�6n   $	��Top=�6�   
�������$��14(�6�   $	��220��6�   �� 5   
   -   5        $ lblRoom��5      $�� ��6!   $
��Left=�6-   $	��Top=�6H   $��
139,97,0,0q�6`   $	��244��6t   �� 5   
   -   5        $ lblRoomQuantityLabel��5      $��
Quantity: ��6.   $
��Left=�6C   $	��Top=�6^   $��139,154,0,0q�6v   $��80��6�   �� 5   
   -   5        $ lblRoomPriceLabel��5      $��Price: ��6+   $
��Left=�6=   $	��Top=�6X   $��139,201,0,0q�6p   $��80��6�   �� 5   
   -	   5        $ lblRoomPrice��5      $�� ��6&   $
��Left=�62   $	��Top=�6M   $��224,201,0,0q�6e   $��80��6z   �� 5    
   -
   5        $ lblRoomQuantity��5       $�� ��6)   $
��Left=�65   $	��Top=�6P   $��224,154,0,0q�6h   $��80��6}   5"      5#      