   M S B A M L   `   `   `  ����  CocktailRecipeApp+    %CocktailRecipeApp.AddEditCocktailPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Add/Edit Cocktail��5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0,0,0,20q�6   $��0��6'   .+�5      �� $��Cocktail Name:��6   $
��Bold"�6.   �� 5      -   5         ��Name$ NameTextBox��5      $��0,5,0,15q�6+   �� 5      $��Glass Type:��6   $
��Bold"�6+   �� 5      -   5         ��Name$ GlassTypeComboBox��5      $��0,5,0,15q�62   .@�5      �� $��Martini��6   �� 5      $��Highball��6   �� 5      $��Coupe��6   �� 5      $��Rocks��6   �� 5      $	��Gin��6   �� 5      $��Lowball��6   5      �� 5      $��Ingredients:��6   $
��Bold"�6,   �� 5      -   5        $ IngredientsTextBox��5      $��0,5,0,15q�62   �� 5      $��Instructions:��6   $
��Bold"�6-   �� 5      -   5        $ InstructionsTextBox��5       �� AcceptsReturn$
 True��63   $	��100��6H   $��0,5,0,15q�6U   �� 5       $��Cocktail Description:��6   $
��Bold"�65   �� 5!      -   5        $ DescriptionTextBox��5!      $��0,5,0,15q�62   �� 5#      $��Image:��6   $
��Bold"�6&   �� 5$       �� Orientation$ 
Horizontal=�6   $��0,5,0,15q�62   .+�5%      �� -   5        $ ImagePathTextBox��5%      $	��300��64    �� 
IsReadOnly$
 True��6@   �� 5&      -   5        $��	Browse...��5&      $��10,0,0,0q�6H   5'      �� 5)      $��
Favourite:��6   $
��Bold"�6*   �� 5*      -   5         ��Name$ FavouriteCheckBox��5*      $��0,5,0,15q�62   5.      �� 51   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�52      �� -	   5        $
��Save��52      $	��100��6$   $��40��60   $��10q�6U   �� 53      -
   5        $��Cancel��53      $	��100��6&   $��40��62   $��10q�6Y   54      55      56      