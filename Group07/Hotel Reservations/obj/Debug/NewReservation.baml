   M S B A M L   `   `   `  ����M  IHotel Reservations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hotel_ReservationsHotel_Reservations  5   	   '    !Hotel_Reservations.NewReservation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Hotel_Reservations     5   	   -   5          �Name$  winNewReserv��5   	    � Title$ New Reservation��5   	   $	��350��6!   $	��525��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_   ��5	      �� 5
   
    �� ImageSource$ images/NRbackground.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ recBackground��5      $
��Left=�6+   $	��319��6F   
���   �$	��Top=�6b   $	��517��6z    J� RenderTransformOrigin$ 0.672,0.554&�6�   ��5      �� 5       �� Color$ 	#FF3A464D��6"   	 �� Opacity$		 0.6Q�64   
 J� OpacityMask
 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0.053Q�61   � 5      $ White��6#   $ 0.647Q�61   5      5      �� 5   
   -   5         ��Name$ 	imgNRIcon��5      $
��Left=�6#   $��47��6>   $	��Top=�6J   $��54��6b   $��
441,11,0,0q�6m   $��images/NRIcon.png��6�    J� Opacity$
 0.89Q�6�   �� 5   
   -   5         ��Name$ lblNewReserv��5      $��New Reservation��6&   $
��Left=�6@   $	��Top=�6[   $��	10,10,0,0q�6s   ���	#FC56C1AE$
��Bold"�6�   $��20(�6�   $��37��6�   $	��169��6�   �� 5    
   -   5         ��Name$ txbNRDescrip��5       $
��Left=�6*   $
��Wrap=�6E   $	��Top=�6Y   $��	21,45,0,0q�6q   
�������$��40��6�   $	��266��6�   $c��]Please select room type, number of room, check-in date and check-out date to get price quote.��6�   �� 5!   
   -   5        $ lblRoomType��5!      $��
Room Type:��6%   $
��Left=�6:   $	��Top=�6U   $��
15,101,0,0q�6m   
�������$��26��6�   $��72��6�   �� 5"   
   -   5         ��Name$ cmbRoomType��5"      $
��Left=�6(   $	��Top=�6C   $	��120��6[   $��135,105,0,0q�6g   $ 0.523,0.032&�6|    �� SelectedIndex$ 1��6�   $��22��6�   .@�5#      �� $��-Select-��6   �� 5$      $��One King��6   �� 5%      $��One King Deluxe��6   �� 5&      $��	Two Queen��6   �� 5'      $��Two Queen Deluxe��6   �� 5(      $��One King Suite��6   �� 5)      $!��One King Presidential Suite��6   5*      �� 5+   
   -   5        $ lblNumOfRoom��5+      $��Number of Room:��6&   $
��Left=�6@   $	��Top=�6[   $��
15,132,0,0q�6s   
�������$��26��6�   $	��105��6�   �� 5,   
   -	   5         ��Name$ txbNumOfRoom��5,      $
��Left=�6(   $��22��6C    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��135,135,0,0q�6�   $��2��6�   �� 5-   
   -
   5        $ 
lblCheckIn��5-      $��Check-In Date:��6$   $
��Left=�6=   $	��Top=�6X   $��
15,162,0,0q�6p   
�������$��26��6�   $��87��6�   (  "System.Windows.Controls.DatePicker  5.   
   -   5          Name$ 
dtpCheckIn��5.      $
��Left=�6)   $	��Top=�6D   $��135,162,0,0q�6\   $	��120��6q   $��24��6}   �� 5/   
   -   5        $ lblCheckOut��5/      $��Check-Out Date:��6%   $
��Left=�6?   $	��Top=�6Z   $��
15,188,0,0q�6r   
�������$��26��6�   $��97��6�     50   
   -   5        $ dtpCheckOut��50      $
��Left=�6*   $	��Top=�6E   $��135,190,0,0q�6]   $	��120��6r   $��24��6~   �� 51   
   -   5         ��Name$ 	btnSearch��51      $��Search��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��
21,234,0,0q�6s   $��20��6�   6�   �� 52   
   -   5        $ btnClear��52      $��Clear��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��180,233,0,0q�6q   $��20��6�   �� 53   
   -   5        $ lblQuote��53      $��Price Quote:��6"   $
��Left=�69   $	��Top=�6T   $��
292,74,0,0q�6l   
�������$��26��6�   $��91��6�   �� 54   
   -   5        $ txbQuote��54      $
��Left=�6$   $	��166��6?   $
 Wrap=�6L   $	��Top=�6`   $	��190��6x   $��292,105,0,0q�6�   ��.  $����Number of Night:            2                               
Rate per Night:                $179
Subtotal:                          $358
Tax:                                  $383.06
Convenience Fee:            $20
Total:                               $403.06
��6�   �� 55   
   -   5        $ btnContinue��55      $��Continue��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��292,289,0,0q�6w   $��20��6�   �� 56   
   -   5        $ 	btnNRBack��56      $
��Back��6$   $
��Left=�63   $	��Top=�6N   $��75��6f   $��407,289,0,0q�6q   $��20��6�   58      59      