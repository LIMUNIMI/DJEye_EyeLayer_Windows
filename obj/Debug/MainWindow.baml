   M S B A M L   `   `   `  ����  	BlankADMI    DJeye_Wrapper.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  DJeye mouse wrapper��5   	    � WindowStyle$ SingleBorderWindow=�6%    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�6.   $	��384��6D   $	��433��6P   .��5	      � 
���   �.+�5
   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��1* �6    .+�5      �� $��0��6    �� Orientation$ Vertical=�6&   .+�5      �� $��DJeye mouse wrapper��6   $��Magneto)�66   $��20(�6K   
�������6Y   �� 5      $H��BUse this application to control the mouse through your eye tracker��6   
�������$��Italic$�6x   5      �� 5      $��1��6   $ Vertical=�6&   .+�5      �� �� 5      -   5        $��
cbxEnabled��5       d� 	IsChecked$ FalseY�6-   $��Enabled��6?   
�������$��3,3,3,3q�6d   6�   �� 5      $ 
Horizontal=�6   .+�5      �� -   5        $��
btnSmoothM��5      $��-��6/   $��30��6;   $
��Left=�6F   $��3,3,3,3q�6a   6r   �� 5      -   5        $��	txtSmooth��5       $��0��61   $
��Auto��6:   $
��30px��6H   �� 5      -   5        $��
btnSmoothP��5      $��+��6/   $��30��6;   $
��Left=�6F   $��3,3,3,3q�6a   6r   �� 5      $��Smoothing filter weight��6   5      �� 5      $ 
Horizontal=�6   .+�5      �� -   5        $��btnWinkThreshM��5      $��-��63   $��30��6?   $
��Left=�6J   $��3,3,3,3q�6e   6v   �� 5       -   5        $��txtWinkThresh��5        $��0��65   $
��Auto��6>   $
��30px��6L   �� 5!      -   5        $��btnWinkThreshP��5!      $��+��63   $��30��6?   $
��Left=�6J   $��3,3,3,3q�6e   6v   �� 5"      $&�� One eye wink threshold (samples)��6   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� -	   5        $��btnBlinkThreshM��5%      $��-��64   $��30��6@   $
��Left=�6K   $��3,3,3,3q�6f   6w   �� 5&      -
   5        $��txtBlinkThresh��5&       $��0��66   $
��Auto��6?   $
��30px��6M   �� 5'      -   5        $��btnBlinkThreshP��5'      $��+��64   $��30��6@   $
��Left=�6K   $��3,3,3,3q�6f   6w   �� 5(      $(��"Two eyes blink threshold (samples)��6   5)      �� 5*      $ 
Horizontal=�6   .+�5+      �� -   5        $��btnScrollDeadzoneM��5+      $��-��67   $��30��6C   $
��Left=�6N   $��3,3,3,3q�6i   6z   �� 5,      -   5        $��txtScrollDeadzone��5,       $��0��69   $
��Auto��6B   $
��30px��6P   �� 5-      -   5        $��btnScrollDeadzoneP��5-      $��+��67   $��30��6C   $
��Left=�6N   $��3,3,3,3q�6i   6z   �� 5.      $��Scrolling deadzone��6   5/      �� 50      $ 
Horizontal=�6   .+�51      �� -   5        $��btnScrollSpeedM��51      $��-��64   $��30��6@   $
��Left=�6K   $��3,3,3,3q�6f   6w   �� 52      -   5        $��txtScrollSpeed��52       $��0��66   $
��Auto��6?   $
��30px��6M   �� 53      -   5        $��btnScrollSpeedP��53      $��+��64   $��30��6@   $
��Left=�6K   $��3,3,3,3q�6f   6w   �� 54      $$��Scrolling speed (milliseconds)��6   55      �� 56      �� 57      $��Guide��6   $
��Bold"�6(   �� 58       �� TextAlignment$
 Left=�6   $��5,0,0,0q�61   $
��Left=�6B   $����Left eye wink will trigger a single click
Two eyes blink will trigger a double click
Right eye wink, then head up/down will scroll mouse wheel��6]   �� 59      �� 5:      $y�Visible=�6   $
 Left=�62   $��5,0,0,0q�6G   $
��Left=�6X   $2��,Use E to force enable
Use D to force disable��6s   �� 5;      -   5        $��txtTest��5;      $y�Hidden=�6+   $
 Left=�6@   $��5,0,0,0q�6U   $
��Left=�6f   $�� ��6�   �� 5<      -   5        $��btnTest��5<      $y�Hidden=�6(   $
��Test��6<   $��30��6K   $
��Left=�6V   $��3,3,3,3q�6q   6�   5>      5?      5@      5A      