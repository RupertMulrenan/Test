   M S B A M L   `   `   `  ����H  DScreenCapture, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ScreenCaptureScreenCapture  5   	       ScreenCapture.Feedback   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ScreenCapture     5   	     � Title$  Send Feedback��5   	    � SizeToContent$ WidthAndHeight=�6    � 
ResizeMode$ NoResize=�6>   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0 3 3 3q�6   $��Enter your comments:��6.   6O   �� 5   
   $��1��6   $��3q�6    �� MinLines$ 3��6*    �� MaxLines$ 10��67    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6Z   $��hello��6n   " �� VerticalScrollBarVisibility$
 Auto=�6{   $	��300��6�   �� 5   
   -   5        $��2��5      $��3q�6    	 d� 	IsChecked$
	 TrueY�6+   $��Include Screenshot��6<   6Y   � 5   
   $��3q�6   $��3��6   $
��Left=�6'   .+�5      �� $��1q�6   
���iii�._�5      �� -   5        
 ��Name$
 Image��5      $
��Left=�6(   $	��300��6C   $	��200��6O    �� BitmapScalingMode$ HighQuality=�6\   5      5      �� 5   
   $��4��6   $��0 3 3 3q�6   $<��6Your feedback will be used to improve the application.��6.   6q   �� 5!   
   $��5��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5"      �� -   5         �� 	IsDefault . $
��Send��5"   &   $��3q�65   $��3q�6A   $��60��6L   $��Right=�6Z   $��Center=�6v   6�   �� 5#      -   5         �� IsCancel . $��Cancel��5#   %   $��3q�66   $��3q�6B   $��60��6M   $��Right=�6[   $��Center=�6w   6�   5$      5'      5(      