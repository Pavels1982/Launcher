   M S B A M L   `   `   `  ����E  ARTLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RTLauncher
RTLauncher  5   	   %    RTLauncher.Views.MainWindowView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RTLauncher     5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��350��5
   	   $	��525��6     � WindowStyle$
  None=�6"      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � ShowInTaskbar .    MaterialDesignPaper#���  5   	     MaterialDesignFont#��[ 5   	    � 	Resources 5        MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 40Q�63     5      $ 0:0:0.2��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.2��6'   $ 40Q�69   5       5!      5"      	 � Triggers	 5$      :� 5%   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5&      �� #��[ 6   5'      :� 5(   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5)      �� #��[ 6   5*      .��50      �   PrimaryHueMidBrush#���  6    � RowDefinitions 51   
   �� 52      $��40 �6   �� 53      $��* �6    � ColumnDefinitions 55   
   �� 56      $��40 �6   �� 57      $��* �6   .+�5:   
   � -   5        $��1��5<      $��0��5=      .+�5?      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $	��Top=�6N   .+�5@      �� -   5        $��20��5@   F   $��20��6Q   ��6   Z� ��6/   Z� .��5A      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$ WindowMinimize=�5C      $��	-14 0 0 0q�5D      5E      �� 5G      -   5        $��20��5G   F   $��20��6Q   ��6   Z� ��6/   Z� .��5H        
�������$��
-14 -4 0 0q�5J      ��5K      �� 5L       �� 
TargetType"  6$   .�5M   "   ��  �� Property �@ Kind �� Value$ WindowMaximize=�69    �� Triggers 5N   "   �� 5O   &    �� Binding 62   �� *IsWindowMaximize+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ WindowL� �� Value True6�   .a�5P   *   ��  �@ Kind$ WindowRestore=�6A   5Q   '   5S      5U      5V      �� 5X      $��20��6F   $��20��6Q   ��6   Z� ��6/   Z� ��6]   �� *CloseAppCommand+.��5Z        
�������$ WindowClose=�5\      $��
-14 -4 0 0q�6,   5^      5a      5c      �� 5f   
   $��1��5g      $��1��5h      $
��Auto=�5i      .��5j      �� #���  5k      ��5l      �� *SelectedControl.View+5m      � 5o   
   -   5         �Name$ GridMenu��5q      $
��Left=�5p      $��2��5r      $��2��5s      $��40��5t      #���  5u       5v      �� 5w      $
��Auto �6    �� 5x      $��1* �6    .+�5z      �� $��1��5{      ��5|      �� *ControlList+ �� Mode$ TwoWay=� �� SelectedItem 5}      �� *SelectedControl+$ TwoWay=� 5       " MaterialDesignScrollBarMinimal �� BasedOn��%0   '��       7  �� 5�      " ��6   8   63   5�      ��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   .+�5�        $��4 4 0 0 q�5�   !    5�   !   ��  �� Path$
 Icon��� 5�      $��	32 0 32 0q�5�      
�������$��18(�5�      ��5�      �� $ Title�5�      5�      5�      �� 5�      -   5         ��Name$ ButtonCloseMenu��5�      $��0��5�      $	��Top=�5�      $��Right=�5�      $��40��5�      $��40��5�      ��5�      Z� ��5�      Z� ��5�      �� *
MenuAction+��5�      �� 5�      " ��6   .�5�      ��  � y�$ 	Collapsed=�67    5�      �� 5�       6*   �� *
IsMenuOpen+ True6I   .a�5�   "   ��  � y�$ Visible=�6?   5�      5�      .��5�        $ 	ArrowLeft=�6*   
�������$��20��6N   $��20��6Y   5�      �� 5�      -   5        $ ButtonOpenMenu��5�      $��0��5�      $	��Top=�5�      $��Right=�5�      $��40��5�      $��40��5�      ��5�      Z� ��5�      Z� ��5�      �� *
MenuAction+��5�      �� 5�      " ��6   .�5�      ��  � y�$ 	Collapsed=�67    5�      �� 5�       6*   �� *
IsMenuOpen+	 False6I   .a�5�   "   ��  � y�$ Visible=�6?   5�      5�      .��5�        $
 Menu=�6*   
�������$��20��6I   $��20��6T   5�      5�      5�      5�      