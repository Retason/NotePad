   M S B A M L   `   `   `  ����B  >NotePad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NotePad.ViewNotePad.View  5   	   5clr-namespace:NotePad.ViewModelNotePad.ViewModel  5   	       NotePad.View.FontWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:NotePad.View     5   	   .vmclr-namespace:NotePad.ViewModel     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
FontWindow��5
   	   $	��120��6   $	��230��6)    	  TB_BG#���   65   ��6Z   Z�  � DataContext 5      "  NotePad.ViewModel.SettingsVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $	��120��6W   $��	10,12,0,0q�6c   $��25��6v   $	��Top=�6�   $
��Left=�6�   $��1��6�   ��6   �� *Fonts+ �� SelectedItem 61   �� *SelectedFont+6�   �� 5   
    �� TextWrapping$
 Wrap=�6   $��	31,42,0,0q�6q   $��25��6�   $	��Top=�6�   $
��Left=�6�   $��28��6�   $��1��6�   #���   6�    	 TB_FG#���  6  ��6&   �� *
FontSize+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6  �� 5   
   $��+��63   $��	59,42,0,0q�6?   $��25��6R   $	��Top=�6^   $
��Left=�6v   $��21��6�   $��1��6�   ��6   �� *FontUpCommand+6�   �� 5   
   $��-��65   $��	10,42,0,0q�6A    J� RenderTransformOrigin$ 1.119,0.521&�6T   $��25��6x   $	��Top=�6�   $
��Left=�6�   $��21��6�   $��1��6�   ��6   �� *FontDownCommand+6�   �� 5   
     	LANG_Font#���  6   $��0,2,11,0q�66   $��37��6H   $	��Top=�6T   #���  6l   �� 5   
     LANG_FontSize#���  6   $��	0,40,11,0q�6:   $��37��6M   $	��Top=�6Y   #���  6q   5      5      