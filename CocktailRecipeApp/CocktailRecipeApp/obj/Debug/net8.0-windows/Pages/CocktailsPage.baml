   M S B A M L   `   `   `  ����L  HCocktailRecipeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CocktailRecipeApp.ConvertersCocktailRecipeApp.Converters  5      +    %CocktailRecipeApp.Pages.CocktailsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      <local*clr-namespace:CocktailRecipeApp.Converters     5        N� Title$  Cocktails Page��5       � 	Resources 5
      6   0CocktailRecipeApp.Converters.NullToBoolConverter   NullToBoolConverter5   /CocktailRecipeApp.Converters.PathToUriConverter  PathToUriConverter��%:   &	        &	        5   
   6$     5   
   6#   5      .��5      � $��10q�6   .+�5   
   �� $��	Cocktails��6   $��24(�5      $
��Bold"�5      $��Center=�5      $	��Top=�5      $��0,10,0,0q�5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5      $	��Top=�5      $��0,50,0,0q�5      .+�5      � $	��200��6   $��30��6   .+�5      �� -   5         ��Name$ SearchPlaceholder��5      $"��Search by name or ingredient��5       
�������$��Center=�5"      $��5,0,0,0q�5#       J� IsHitTestVisible$ False��5$      $y�Visible=�5%      �� 5(      -   5         ��Name$ SearchTextBox��5(      $��Center=�5)      $��0q�5-      5.      �� 5/      -   5        $��Search��5/      $	��100��50      $��30��51      $��10,0,0,0q�52      53      54      �� 57   
   -   5         ��Name$ CocktailsListView��57      $��10,100,10,150q�6.   ��58      �� 59      .R�5:      �� $ 
Horizontal=�6!   $��5q�6:   .+�5;      �� $��50��6l   $��50��6w   $��5q�6�   ��6    �� *	ImagePath+ �� 	Converter# [ 6�   �� 5<      .+�5=      �� $
��Bold"�6F   $��14(�6X   ��6(   �� *CocktailName+6X   �� 5>      $��12(�6C   
���������6(   �� *	GlassType+6Q   �� 5?      $��12(�6M   
���������6(   �� *CocktailDescription+6[   �� 5@      $��12(�6D   
���������6(   �� *
Ingredient+6R   �� 5A      $��12(�6F   
���������6(   �� *Instructions+6T   5B      �� 5C      $��	Favourite��6#   $��10,0,0,0q�6Y   $��Center=�6k    d� 	IsChecked 67   �� *IsFavourite+6k   �� 5D      $��12(�6?   
���������6$   �� *	DateAdded+6M   5E      5F      5H      �� 5L   
   $ 
Horizontal=�6   $��Center=�5M      $��Bottom=�5N      $��0,0,0,10q�5O      .+�5P      �� -   5        $��Add New��5P      $	��100��5Q      $��40��5R      $��10q�5S      5T      �� 5U      -   5        $��
EditButton��5U      $
��Edit��5V      $	��100��5W      $��40��5X      $��10q�5Y      {�5[      �� 	 �� ElementName$	 CocktailsListView��
 �� Path$
 SelectedItem�# [  �� 5\      -   5        $��DeleteButton��5\      $��Delete��5]      $	��100��5^      $��40��5_      $��10q�5`      {�5b      �� $	 CocktailsListView��$
 SelectedItem�# [  �� 5c      -   5        $��
RateButton��5c      $
��Rate��5d      $	��100��5e      $��40��5f      $��10q�5g      {�5i      �� $	 CocktailsListView��$
 SelectedItem�# [  5j      5k      5l      