   M S B A M L   `   `   `  ����B  >CleanUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CleanUICleanUI  5   	   !    CleanUI.AuthorizationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CleanUI     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 none=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #ffffff��6'    � Offset$	 0.0Q�67   � 5      $ #808080��6'   $ 1Q�67   5      5      �� 5      $��Right=�6   .+�5      �� -   5        $��17��5      $��10��6$   $��10q�6/   $'��!images/free-icon-close-122264.png��6;    J� RenderTransformOrigin$ -0.202,0.767&�6�   5      �� 5      $��center=�6   .+�5       �� $��Images/logo.png��6   $��80��61   �� 5!      $N��HТольяттинский политехнический колледж��6   $��Light"�5"      $��	helvetica)�5#      $��18(�5$      
���   �$��Center=�5&      5'      �� 5(      $��1��6   .+�5)      �� 	 �� Orientation$	 
Horizontal=�6   .+�5*      �� -   5        
 ��Name$
 	loginuser��5*      $��	Helvetica)�61   $��Light"�5+      $��login��5,      $��20(�5-      $��Center=�5.      
�������
������ $��0q�51      $	��235��52      $
��Left=�53       J� Opacity$	 0.5Q�54      $��25��55      $��63,0,0,0q�56      4  .System.Windows.Automation.AutomationProperties   Name$ 	loginuser��62   6v   57      �� 58      $	��250��6   $��2��59      
�������$	 0.5Q�5;      �� 5<      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5=      G� -   5         G�Name$ txtPass��5=   "   $��	Helvetica)�63   $��Light"�5>       G� Password$ Password��5?      $��20(�5@      $��Center=�5A      
�������
������ $��0q�5D      $	��235��5E      $
��Left=�5F      $	 0.5Q�5G      $��25��5H      $��63,0,0,0q�5I      $ txtPass��60   6p   5J      �� 5K      $	��250��6   $��2��5L      
�������$	 0.5Q�5N      �� 5Q      $	 
Horizontal=�6   $��0,40,0,0q�66   .+�5R      �� -   5        $	��260��5R      $��40��6)   $$��Вход как учитель��65   $��	60,0,60,0q�6P   6c   5S      �� 5T      $	 
Horizontal=�6   $��0,10,0,0q�66   .+�5U      �� -   5        $	��100��5U      $��40��6)   $��Вход��65   $��	60,0,60,0q�6D   6W   �� 5V      $	��100��6   $��40��6)   $��Регистрация��65   5W      5X      5Y      5Z      5[      