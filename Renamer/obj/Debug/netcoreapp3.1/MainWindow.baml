   M S B A M L   `   `   `  ����B  >Renamer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RenamerRenamer  5   	       Renamer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Renamer     5   	     � Title$  
MainWindow��5   	   $	��501��6   $	��550��6)   .��5	      � $	��486��6   $
��Left=�6   $	��576��63    � ColumnDefinitions 5
   
   �� 5      $
��280* �6   �� 5      $��3* �6   .+�5   
   �� $��Enter list of names��6   $
��Left=�6.   $��	40,47,0,0q�6I   $	��Top=�6\   $	��120��6t   �� 5   
   -   5        $��NameList��5       �� AcceptsReturn$
 True��6"    �� TextWrapping$
 Wrap=�6A   $	��120��6U   $��40,71,400,33q�6a   �� 5   
   $��Enter folder path��6   $
��Left=�6,   $��
199,47,0,0q�6G   $	��Top=�6[   $	��200��6s   �� 5   
   -   5        $��
FolderPath��5      $�� ��6$   $
 Wrap=�6,   $	��200��6@   $��25��6L   $��199,71,161,390q�6X   �� 5   
   $��Enter prefix (optional)��6   $
��Left=�62   $��199,100,0,0q�6M   $	��Top=�6b   $	��200��6z   �� 5   
   -   5        $��PrefixInput��5      $
 Wrap=�6%   $	��200��69   $��25��6E   $��199,126,161,334q�6Q   �� 5   
   $��Enter suffix (optional)��6   $
��Left=�62   $��199,161,0,0q�6M   $	��Top=�6b   $	��200��6z   �� 5   
   -   5        $��SuffixInput��5      $
 Wrap=�6%   $	��200��69   $��25��6E   $��199,185,161,276q�6Q   �� 5   
   -   5         ��Name$ 	NameOrder��5      $
��Left=�6'   $��	192,0,0,0q�6B   $7��1Are the names in the list in "Last, First" order?��6U   $
��Wrap=�6�   $��Center=�6�   $��36��6�   $	��232��6�   	� 5   
   -   5         	�Name$ NameOrderButtonYes��5       	� 	GroupName$ NameOrderCheck��62   $	��Yes��6M   $
��Left=�6[   $��192,278,0,0q�6v   $	��Top=�6�   	� 5   
   -   5        $ NameOrderButtonNo��5      $ NameOrderCheck��61   $��No��6L   $
��Left=�6Y   $��334,278,0,0q�6t   $	��Top=�6�   �� 5   
   -   5        $ 	FileOrder��5      $
��Left=�6'   $��192,338,0,0q�6B   $?��9Do the files contain part of the first name or last name?��6W   $
��Wrap=�6�   $	��Top=�6�   $��36��6�   $	��232��6�   	� 5   
   -	   5        $ FileOrderFirst��5      $ FileOrderCheck��6.   $��First��6I   $
��Left=�6Y   $��192,382,0,0q�6t   $	��Top=�6�   	� 5    
   -
   5        $ FileOrderLast��5       $ FileOrderCheck��6-   $
��Last��6H   $
��Left=�6W   $��334,382,0,0q�6r   $	��Top=�6�   �� 5!   
   -   5         ��Name$ RenameButton��5!      $��Rename��6'   $
��Left=�68   $��192,420,0,0q�6S   $	��Top=�6h   $��32��6�   $	��236��6�   6�   5"      5#      