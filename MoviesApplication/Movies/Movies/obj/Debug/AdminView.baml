   M S B A M L   `   `   `  ����
  Movies    Movies.AdminView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Admin View��5   	   $	��600��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ Admin_ID��5      $
��Left=�6$   $��21��6?   $��	75,21,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��130��6�   6�   �� 5   
   -   5        $ 
Admin_Sold��5      $
��Left=�6&   $��21��6A   $��
270,18,0,0q�6M   $
 Wrap=�6a   $
��5000��6u   $	��Top=�6�   $	��130��6�   6�   �� 5	   
   -   5        $ Admin_Title��5	       �� 	MaxLength$ 32��6'   $
��Left=�66   $��20��6Q   $��	75,51,0,0q�6]   $
 Wrap=�6p   $��	Title box��6�   $	��Top=�6�   $	��130��6�   6�   �� 5
   
   -   5        $ Admin_Rating��5
      $ 3��6(   $
��Left=�66   $��20��6Q   $��
290,51,0,0q�6]   $
 Wrap=�6q   $	��1.1��6�   $	��Top=�6�   $��25��6�   6�   �� 5   
   -   5        $ Admin_Genre��5      $
��Left=�6'   $��20��6B   $��	75,76,0,0q�6N   $
 Wrap=�6a   $��	Genre Box��6u   $	��Top=�6�   $	��130��6�   6�   �� 5   
   -   5        $ Admin_Picture��5      $
��Left=�6)   $��21��6D   $��
75,105,0,0q�6P   $
 Wrap=�6d   $@��:C:\Users\roman\Documents\gbc\LabTest4\pictures\default.jpg��6x   $	��Top=�6�   $	��390��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   {�.  6�   �� 5   
   -   5        $ Admin_Trailer��5      $
��Left=�6)   $��20��6D   $��
75,135,0,0q�6P   $
 Wrap=�6d   $��http://niceme.me��6x   $	��Top=�6�   $	��470��6�   6�   �� 5   
   -   5        $ Admin_Description��5      $
��Left=�6-   $	��105��6H   $��557,105,0,0q�6U   $
 Wrap=�6j   $+��%Limpa Lumpus wasawdasdasd asdasdsafas��6~   $	��Top=�6�   $	��213��6�   �� 5   
   -	   5         ��Name$ 
Button_Add��5      $	��Add��6%   $
��Left=�63   $��18��6N   $��
45,192,0,0q�6Z   $	��Top=�6n   $��60��6�   6�   �� 5   
   -
   5        $ Buton_Delete��5      $��Delete��6'   $
��Left=�68   $��18��6S   $��125,192,0,0q�6_   $	��Top=�6t   $��60��6�   6�   �� 5   
   -   5        $ Button_Edit��5      $
��Edit��6&   $
��Left=�65   $��18��6P   $��210,192,0,0q�6\   $	��Top=�6q   $��70��6�   6�   �� 5   
   -   5        $ Button_Refresh��5      $��Clear��6)   $
��Left=�69   $��18��6T   $��310,192,0,0q�6`   $	��Top=�6u   $��60��6�   6�   �� 5   
   -   5        $ Button_Close��5      $��Close��6'   $
��Left=�67   $��21��6R   $��712,524,0,0q�6^   $	��Top=�6s   $��58��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Admin_MovieList��5   .      AutoGenerateColumns . |�.  $
��Left=�6Y   $	��294��6t   $��
10,225,0,0q�6�   $	��Top=�6�   $	��760��6�   �� 5   
   $��Title:��6   $
��Left=�6!   $��24��6<   $��	25,43,0,0q�6H   $	��Top=�6[   $��45��6s   �� 5   
   $��Genre:��6   $
��Left=�6!   $��23��6<   $��	25,72,0,0q�6H   $	��Top=�6[   $��45��6s   �� 5   
   $��Release Date��6   $
��Left=�6'   $��26��6B   $��
405,13,0,0q�6N   $	��Top=�6b   $	��110��6z   $ 0.5,0.5&�6�   �� 5   
   $��Sold:��6   $
��Left=�6    $��25��6;   $��
210,17,0,0q�6G   $	��Top=�6[   $��40��6s   �� 5   
   $��Description:��6   $
��Left=�6'   $��30��6B   $��
557,74,0,0q�6N   $	��Top=�6b   $��75��6z   �� 5   
   $��Picture:��6   $
��Left=�6#   $��25��6>   $��
25,101,0,0q�6J   $	��Top=�6^   $��50��6v   �� 5   
   $	��ID:��6   $
��Left=�6   $��25��69   $��	25,14,0,0q�6E   $	��Top=�6X   $��45��6p   �� 5   
   $��Rating: (n.n)��6   $
��Left=�6(   $��28��6C   $��
210,47,0,0q�6O   $	��Top=�6c   $��75��6{   �� 5   
   $��Trailer:��6   $
��Left=�6#   $��24��6>   $��
25,131,0,0q�6J   $	��Top=�6^   $��45��6v   �� 5   
   -   5        $ Button_Browse��5      $��	Browse...��6(   $
��Left=�6<   $��21��6W   $��465,105,0,0q�6c   $	��Top=�6x   $��80��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 Admin_ReleaseDate��5      $
��Left=�6l   $��24��6�   $��
405,43,0,0q�6�   $	��Top=�6�   $	��110��6�   
   DisplayDate$
 
1999-01-01��6�   |�.     DisplayDateEnd$ 
2015-01-12X�6�      DisplayDateStart$ 
1900-01-01X�6  5       5!      