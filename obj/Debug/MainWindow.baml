   M S B A M L   `   `   `  ����P  LSQLStatementGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SQLStatementGeneratorSQLStatementGenerator  5   	   &     SQLStatementGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SQLStatementGenerator     5   	     � Title$  SQL Statement Generator��5   	   $	��800��6)   $
��1280��66   ���	#FF787878.��5	      � .+�5
   
   �� -   5        $��
OutputText��5
   �   $
��Left=�6   $	��449��6-   $��
10,310,0,0q�6:    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $
��1252��6�   6�   �� 5   
   $��
Table name��6   $
��Left=�6%   $��	16,21,0,0q�6@   $	��Top=�6S   �� 5   
   -   5        $��TableTextBox��5   �   $
��Left=�6   $��23��6-   $��
110,21,0,0q�69   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�    J� RenderTransformOrigin$ 0.264,-0.188&�6�   6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��116��6T   $��	10,66,0,0q�6a   $	��Top=�6t   $
��1252��6�   ._�5      �� -   5        $��Random full name��5      $
��Left=�60   $	��Top=�6K   $	��107��6c   ���	#FF09969C$��6,13,0,0q�6�   
 J� Uid$ GetFullName��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 2Q�6'   5      5      �� 5   
   -   5        $��
Department��5      $
��Left=�6&   $��
132,80,0,0q�6A   $	��Top=�6U   $��76��6m   ���	#FF09969C$ GetDepartment��6�    5        5      $ 2Q�6#   5      �� 5   
   -   5        $��	City name��5      $
��Left=�6%   $��
218,80,0,0q�6@   $	��Top=�6T   $��76��6l   ���	#FF09969C$ GetCity��6�    5        5      $ 2Q�6#   5      �� 5   
   -   5        $��Address/Street��5      $
��Left=�6*   $��
303,80,0,0q�6E   $	��Top=�6Y   $��98��6q   ���	#FF09969C$ 
GetAddress��6�    5        5       $ 2Q�6#   5"      �� 5#   
   -   5        $��Country��5#      $
��Left=�6#   $��
410,80,0,0q�6>   $	��Top=�6R   $��76��6j   ���	#FF09969C$ 
GetCountry��6�    5$        5%      $ 2Q�6#   5'      �� 5(   
   -   5        $
��Date��5(      $
��Left=�6    $��
495,80,0,0q�6;   $	��Top=�6O   $��76��6g   ���	#FF09969C$ GetDate��6�    5)        5*      $ 2Q�6#   5,      �� 5-   
   -	   5        $��Description��5-      $
��Left=�6'   $��
581,80,0,0q�6B   $	��Top=�6V   $��76��6n   ���	#FF09969C$ GetDescription��6�    5.        5/      $ 2Q�6#   51      �� 52   
   -
   5        $��	Job title��52      $
��Left=�6%   $��
667,80,0,0q�6@   $	��Top=�6T   $��76��6l   ���	#FF09969C$ GetJobTitle��6�    53        54      $ 2Q�6#   56      �� 57   
   -   5        $��Amateur/Pro��57      $
��Left=�6'   $��
754,80,0,0q�6B   $	��Top=�6V   $��76��6n   ���	#FF09969C$ 
GetJobType��6�    58        59      $ 2Q�6#   5;      �� 5<   
   -   5        $��Course name��5<      $
��Left=�6'   $��
842,80,0,0q�6B   $	��Top=�6V   $��76��6n   ���	#FF09969C$ 	GetCourse��6�    5=        5>      $ 2Q�6#   5@      �� 5B   
   -   5        $��NumberLength��5B   �   $
��Left=�6   $��20��6-   $��1029,88,0,0q�69   $
 Wrap=�6N   $��4��6b   $	��Top=�6k   $��48��6�   6�   �� 5C   
   $��length��6   $
��Left=�6!   $��1029,62,0,0q�6<   $	��Top=�6Q   $ 3.841,1.827&�6i   �� 5D   
   -   5        $��Number��5D      $
��Left=�6"   $��
930,80,0,0q�6=   $	��Top=�6Q   $��76��6i   ���	#FF09969C$ 	GetNumber��6�    5E        5F      $ 2Q�6#   5H      �� 5J   
   -   5        $��Reset��5J      $
��Left=�6!   $��1170,80,0,0q�6<   $	��Top=�6Q   $��76��6i   ���	#FFDA6969 5K        5L      $ 2Q�6#   5N      �� 5O   
   $+��%One of the values separated by comma:��6   $
��Left=�6@   $��
16,113,0,0q�6[   $	��Top=�6o   �� 5P   
   -   5        $��MoreValues1��5P   �   $
��Left=�6   $��23��6-   $��246,117,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��893��6�   6�   �� 5Q   
   -   5        $	��Set��5Q      $
��Left=�6   $��1171,117,0,0q�6:   $	��Top=�6P   $��75��6h   $ GetCustomValue1��6�   �� 5S   
   $+��%One of the values separated by comma:��6   $
��Left=�6@   $��
16,139,0,0q�6[   $	��Top=�6o   �� 5T   
   -   5        $��MoreValues2��5T   �   $
��Left=�6   $��23��6-   $��246,140,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��893��6�   6�   �� 5U   
   -   5        $	��Set��5U      $
��Left=�6   $��1171,142,0,0q�6:   $	��Top=�6P   $��75��6h   $ GetCustomValue2��6�   �� 5W   
   -   5         ��Name$ CustomPreview��5W   �   $
��Left=�6   $��
12,218,0,0q�6/   $
��Wrap=�6C   $�� ��6W   $	��Top=�6_   $
��1237��6w   6�   �� 5Y   
   -   5        $��SQLPreview_��5Y   �   $
��Left=�6   $��
10,250,0,0q�6/   $
��Wrap=�6C   $��INSERT INTO ��6W   $	��Top=�6k   $
��1239��6�   6�   �� 5Z   
   $��Number of generations:��6   $
��Left=�61   $��
12,273,0,0q�6L   $	��Top=�6`   �� 5[   
   -   5        $"��NumberOfGenerationsTextField��5[   �   $
��Left=�6   $��23��6-   $��155,276,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $��58��6�   6�   �� 5\   
   -   5        $��Generate��5\      $
��Left=�6$   $��235,277,0,0q�6?   $	��Top=�6T   $��75��6l   6w   5^      5_      