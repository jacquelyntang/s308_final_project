   M S B A M L   `   `   `  ����M  IHotel Reservations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hotel_ReservationsHotel_Reservations  5   	   '    !Hotel_Reservations.PIConfirmation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Hotel_Reservations     5   	     � Title$  PIConfirmation��5   	   $	��348��6    $	��525��6-    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ NoResize=�6^   ��5	      �� 5
   
    �� ImageSource$ images/NRbackground.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ recBackground��5      $
��Left=�6+   $	��319��6F   
���   �$	��Top=�6b   $	��517��6z    J� RenderTransformOrigin$ 0.672,0.554&�6�   $��0,0,0,-2q�6�   ��5      �� 5       �� Color$ 	#FF3A464D��6"    �� Opacity$	 0.6Q�64    J� OpacityMask 5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0.053Q�61   � 5      $ White��6#   $ 0.647Q�61   5      5      �� 5   
   -   5         ��Name$ txtPIConfirm��5      $
��Left=�6(   $	��191��6C    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��457��6|   $��681,105,-619,0q�6�   $����First Name:                           James
Last Name:                           John
Credit Card Type:                 American Express
Credit Card Number:            3400 0000 0000 009
Phone                                   541-754-3010 
Email:                                    johnj@indiana.edu        

��6�   �� 5   
   -   5         ��Name$ btnPIConfirm��5      $��Confirm��6'   $
��Left=�69   $��295,276,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ 	btnPIEdit��5      $
��Edit��6$   $
��Left=�63   $��420,276,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5         ��Name$ lblConfirmationLabel��5      $��Reservation Confirmation��6.   $��Center=�6Q   $��23,26,240,0q�6n   $	��Top=�6�   
�������$��14(�6�   $	��256��6�   �� 5   
   -   5        $ lblFirstName��5      $��First Name:��6&   $
��Left=�6<   $	��Top=�6W   $��	23,60,0,0q�6o   �� 5   
   -   5        $ txtFirstName��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��
129,63,0,0q�6�   �� 5   
   -   5        $ lblLastName��5      $��
Last Name:��6%   $
��Left=�6:   $	��Top=�6U   $��	23,86,0,0q�6m   �� 5    
   -	   5        $ txtLastName��5       $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��
129,89,0,0q�6�   �� 5!   
   -
   5        $ 	lblCCType��5!      $��Credit Card Type:��6#   $
��Left=�6?   $	��Top=�6Z   $��
23,112,0,0q�6r   �� 5"   
   -   5        $ 	txtCCType��5"      $
��Left=�6%   $��23��6@   $
 Wrap=�6L   $	��Top=�6`   $	��120��6x   $��129,115,0,0q�6�   �� 5#   
   -   5        $ lblCCNumber��5#      $��Credit Card Number:��6%   $
��Left=�6C   $	��Top=�6^   $��
23,138,0,0q�6v   �� 5$   
   -   5        $ textBox��5$      $
��Left=�6#   $��23��6>   $
 Wrap=�6J   $	��Top=�6^   $	��120��6v   $��147,143,0,0q�6�   �� 5%   
   -   5        $ lblPhone��5%      $��Phone:��6"   $
��Left=�63   $	��Top=�6N   $��
23,164,0,0q�6f   �� 5&   
   -   5        $ txtPhone��5&      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��147,168,0,0q�6�   �� 5'   
   -   5        $ lblEmail��5'      $��Email:��6"   $
��Left=�63   $	��Top=�6N   $��
23,190,0,0q�6f   �� 5(   
   -   5        $ txtEmail��5(      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��147,196,0,0q�6�   �� 5)   
   -   5        $ lblRoomType��5)      $��
Room Type:��6%   $
��Left=�6:   $	��Top=�6U   $��
23,216,0,0q�6m   �� 5*   
   -   5        $ txtRoomType��5*      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��147,220,0,0q�6�   �� 5+   
   -   5        $ lblNumberOfRoom��5+      $��Number Of Room:��6)   $
��Left=�6C   $	��Top=�6^   $��
23,242,0,0q�6v   �� 5,   
   -   5        $ txtNumberOfRoom��5,      $
��Left=�6+   $��23��6F   $��147,245,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5-   
   -   5        $ lblCheckInDate��5-      $��Check-in Date: ��6(   $
��Left=�6B   $	��Top=�6]   $��
306,60,0,0q�6u   �� 5.   
   -   5        $ txtCheckInDate��5.      $
��Left=�6*   $��23��6E   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   $��
397,60,0,0q�6�   50      51      