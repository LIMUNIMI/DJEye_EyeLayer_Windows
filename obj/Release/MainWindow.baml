   M S B A M L   `   `   `  ����   DJeyeMouseWrapper"    DJeyeMouseWrapper.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    >d2http://schemas.microsoft.com/expression/blend/2008    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  DJeye mouse wrapper�� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ Normal=�$	��384��$	��433��.��� 
���   � � ColumnDefinitions �� $
��299* ��� $	��85* �.+�� $��2�� � RowDefinitions �� $
��Auto ��� $��1* �.+��� $��0�� �� Orientation$ Vertical=�.+��� $��DJeye mouse wrapper��$��Magneto)�$��20(�
��������� $H��BUse this application to control the mouse through your eye tracker��
�������$��Italic$��� $��1��$ Vertical=�.+��� �� -   $��
cbxEnabled�� d� 	IsChecked$ FalseY�$��Enabled��
�������$��3,3,3,3q��� $ 
Horizontal=�.+��� -   $��
btnSmoothM��$��-��$��30��$
��Left=�$��3,3,3,3q��� -   $��	txtSmooth��$��0��$
��Auto��$
��30px���� -   $��
btnSmoothP��$��+��$��30��$
��Left=�$��3,3,3,3q��� $��Smoothing filter weight���� $ 
Horizontal=�.+��� -   $��btnWinkThreshM��$��-��$��30��$
��Left=�$��3,3,3,3q��� -   $��txtWinkThresh��$��0��$
��Auto��$
��30px���� -   $��btnWinkThreshP��$��+��$��30��$
��Left=�$��3,3,3,3q��� $&�� One eye wink threshold (samples)���� $ 
Horizontal=�.+��� -	   $��btnBlinkThreshM��$��-��$��30��$
��Left=�$��3,3,3,3q��� -
   $��txtBlinkThresh��$��0��$
��Auto��$
��30px���� -   $��btnBlinkThreshP��$��+��$��30��$
��Left=�$��3,3,3,3q��� $(��"Two eyes blink threshold (samples)���� $ 
Horizontal=�.+��� -   $��btnScrollDeadzoneM��$��-��$��30��$
��Left=�$��3,3,3,3q��� -   $��txtScrollDeadzone��$��0��$
��Auto��$
��30px���� -   $��btnScrollDeadzoneP��$��+��$��30��$
��Left=�$��3,3,3,3q��� $��Scrolling deadzone���� $ 
Horizontal=�.+��� -   $��btnScrollSpeedM��$��-��$��30��$
��Left=�$��3,3,3,3q��� -   $��txtScrollSpeed��$��0��$
��Auto��$
��30px���� -   $��btnScrollSpeedP��$��+��$��30��$
��Left=�$��3,3,3,3q��� $$��Scrolling speed (milliseconds)���� �� $��Guide��$
��Bold"��� 	 �� TextAlignment$
	 Left=�$��5,0,0,0q�$
��Left=�$����Left eye wink will trigger a single click
Two eyes blink will trigger a double click
Right eye wink, then head up/down will scroll mouse wheel���� �� $y�Visible=�$
	 Left=�$��5,0,0,0q�$
��Left=�$2��,Use E to force enable
Use D to force disable���� -   $��txtTest��$y�Hidden=�$
	 Left=�$��5,0,0,0q�$
��Left=�$�� ���� -   $��btnTest��$y�Hidden=�$
��Test��$��30��$
��Left=�$��3,3,3,3q�