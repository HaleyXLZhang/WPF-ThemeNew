   M S B A M L   `   `   `  ����G  CCSATSkin.WPF, Version=2.5.0.8, Culture=neutral, PublicKeyToken=nullS9clr-namespace:CSATSkin.WPF.Controls;assembly=CSATSkin.WPFCSATSkin.WPF.Controls  5      M ICSATSkin.WPF.Demos, Version=2.5.0.7, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CSATSkin.WPF.Demos.ViewsCSATSkin.WPF.Demos.Views 5      M+clr-namespace:CSATSkin.WPF.Demos.ViewModelsCSATSkin.WPF.Demos.ViewModels 5	      (   "CSATSkin.WPF.Demos.Views.PageAbout   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Ncontrols9clr-namespace:CSATSkin.WPF.Controls;assembly=CSATSkin.WPF     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:CSATSkin.WPF.Demos.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      B
viewmodels+clr-namespace:CSATSkin.WPF.Demos.ViewModels     5	        N� Title$  	PageAbout��5
       � DataContext 5      6  0CSATSkin.WPF.Demos.ViewModels.PageAboutViewModel  5   
    � 	Resources 5         
ThemeColor �� Color  	MenuColor  MenuSelectColor��%�   &	        &	 #     &	 F     �� 5   
   $ 	#FF009FA5��6-   �� 5   
   $ 	#FF262A34��6,   �� 5   
   $ #0EBF9C��62   5      .��5      �� $��Center=�6   $��Center=�6.   .+�5   
   �� $	��200��6   $	��200��6   ._�5      A� $	��200��5      $	��200��5       �� BitmapScalingMode$
 Fant=�5      ��5      �� 5       �� ImageSource$ ../Images/user.jpg��6!   5!      5"      �� 5#   
   $��0,10,0,0q�5$      $��Center=�5%      $��40(�5&      #��[  5'      $��Automation Tool��5(      �� 5)   
   $��0,10,0,0q�5*      $��Center=�5+      $��Center=�5,      $��22(�5-      #��[  5.      $��	ChinaSoft��5/      *   $CSATSkin.WPF.Controls.CSATLinkButton  50   
   $��0,10,0,0q�51      $��Center=�52      $��Center=�53      $ ��http://www.chinasofti.com/��56        TransparentColor,   &CSATSkin.WPF.Controls.CSATSystemButton!   CSATSystemButtonHoverColor# [ 57      &   CSATSystemButtonHoverForeground$ 	RoyalBlue��58      $��22(�59      #��[ 5:      ��54      �� *OpenLinkCommand+��55      ��  �� RelativeSource �� 	 �� Mode$
	 Self=�
 �� Path$
 Content�5:      5=      5>      