   M S B A M L   `   `   `  ����E  Askylum_com, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:skylum_com
skylum_com  5   	       skylum_com.MainWindow   5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:skylum_com     5   	   -   5           MaterialDesignFont#���   5   	     � Title$  
MainWindow��5
   	   $	��591��5   	   $
��1024��6    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    J� 	AllowDrop .  � 	Resources 5       �� 
TargetType  BtnTitle  MaterialDesignFlatButton �� BasedOn	 �� Property
 �� Value'  !MaterialDesignThemes.Wpf.PackIcon  Pack��%�  &	       7  &	 �     �� 5   
   " ��6   8   .�5      �� 	 � ��

 ���� 6+   �� 5      	 � ��
 �#8b90966+   �� 5      	 � ��$
 0q�6(   �� 5      	 � ��$
 0, -5, 5, 0q�6'   5      �� 5   
   "  6   .�5      �� 	 � ��

 ���� 6+   �� 5      	 � ��
 �#8b90966+   �� 5      	 � ��$
 Center=�64   �� 5      	 � ��$

 auto��6&   �� 5       	 � ��$

 auto��6'   5!      5#      .��5(      � ���#212121 � RowDefinitions 5*   
   �� 5+      $��20 �6   �� 5,      .+�5/   
   � -   5         �Name$ 	TitleForm��51      $��0��5/      ���#212121$��Stretch=�52      $
��auto��53      $
��left=�54       � ColumnDefinitions 57      �� 58      $��1* �6#   �� 59      $
��auto �6#   �� 5:      $
��auto �6#   �� 5;      $
��auto �6#   .+�5>      �� -   5         ��Name$ BtnMinTitle��5A      #��[ 5?      $��1��5@      $��0 0 5 0q�5B      ��5>      0  *MaterialDesignThemes.Wpf.PackIconExtension  *WindowMinimize+5C      �� 5E      -   5        $ BtnMaxTitle��5H      #��[ 5F      $��2��5G      ��5E        *WindowMaximize+5I      �� 5K      -   5        $ BtnCloseTitle��5M      #��[ 5L      $��3��5N      ��5K        *Close+5O      5P      � 5R   
   -   5        $ OneImg��5R      $��1��6   $y�Hidden=�6,    5S      �� 5T      $��3* �6#   �� 5U      $��1* �6#   .+�5X      �� -   5         ��Name$ 	OneImgImg��5X   $   $��0��6   $��Center=�5Z      $
��auto��5[      $
��auto��6!   $��Uniform=�5\      ��5Y      �� *	CurrImage+5\      � 5^      $��1��6    5_      �� 5`      $��1* �6$   �� 5a      $��1* �6$   �� 5b      $��1* �6$   .+�5e        -   5        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ ArrowUpBoldCircle=�5e   *   #��[ 5f   *   �� 5h      -	   5        $��Center=�5h      $��Center=�66   $
��auto��5i      $��50��6&   $��1��62   $��30(�5k        MaterialDesignRaisedButton#��[ 5l       � ToolTip$ Back to gallery��5m      $
��Back��60     5o      -
   5        $ ArrowDownBoldCircle=�5o   *   $��2��6E   #��[ 5q   *   5r      5s      �� 5w   
   -   5         ��Name$ AllPic��5w      $��1��6#   $��Center=�5x      ��5{      �� 5|      .R�5}      A�  A� Columns$ 4��6#   $��Stretch=�6/   5~      ��5�      �� 5�      .R�5�      �� $
��Left=�69   $	��Top=�5�      $��Uniform=�5�      $	��225��5�      $	��225��5�      ��5�      �� *	ImagePath+5�      5�      5�      5�      5�      