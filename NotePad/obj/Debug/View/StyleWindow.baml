   M S B A M L   `   `   `  ����B  >NotePad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NotePad.ViewNotePad.View  5   	   5clr-namespace:NotePad.ViewModelNotePad.ViewModel  5   	       NotePad.View.StyleWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:NotePad.View     5   	   .vmclr-namespace:NotePad.ViewModel     5   	     � Title$  Style��5	   	   $	��130��6   $	��351��6$    � 
ResizeMode$ NoResize=�60    	  TB_BG#���   6F    � DataContext 5
      "  NotePad.ViewModel.SettingsVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6     
LANG_Style#���  6    $
��auto��6G   $��	0,12,10,0q�6U   $	��Top=�6h   $
��Left=�6�   $��26��6�    	 TB_FG#���  6�   �� 5   
   $��
29,12,30,0q�6Y   $��1��6m   $��26��6}   $	��Top=�6�   ��6   �� *Themes+ �� SelectedItem 62   �� *SelectedTheme+6�   �� 5   
   $��0��6     LANG_Language#���  6    $
��auto��6J   $��	0,56,10,0q�6X   $	��Top=�6k   $
��Left=�6�   $��26��6�   #���   6�   #���  6�   �� 5   
   $��
29,56,30,0q�6_   $��1��6s   $��26��6�   $	��Top=�6�   ��6   �� *	Languages+ 65   �� *SelectedLanguage+6�   5      5      