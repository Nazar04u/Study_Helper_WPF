   M S B A M L   `   `   `  ����  StudyHelperApp&     StudyHelperApp.Views.GradeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Grades��5   	   $	��750��6   $	��900��6%    � WindowStartupLocation$ CenterScreen=�5   	   ���#F9F9F9.��5      ]� $��	0,0,0,-16q�6   .+�5
   
   ]� $	��Top=�6   ���#4B0082$��70��6>   .+�5      �� $��Study Helper��6   
�������$��28(�5      $
��Bold"�5      $��Center=�5      $��15,0,0,0q�5      $
��Left=�5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Center=�6N   $��0,0,10,0q�6i   .+�5      �� -   5        $
��Home��5      $	��106��6A   �� 5      -   5        $��Notes��5      $	��101��6C   �� 5      -   5        $��
To-Do List��5      $��95��6G   �� 5      -   5        $��Login��5      $��91��6C   �� 5      -   5        $��Logout��5      $��97��6E   5      5      � 5   
   $��20q�6    � RowDefinitions 5       �� 5!      $
��Auto �6    �� 5"      $��2* �6    �� 5#      $��3* �6    .+�5'      �� $��Your Grades Overview��6   $��24(�5(      $
��Bold"�6&   ���#4B0082$��	10,0,0,10q�5)      $	��Top=�6+   �� 5,      $��1��6    �� CornerRadius$ 10��6"   
����������#4B0082$��2q�6]    �� Padding$ 10q�6q   ._�5-      �� -   5        $��GradesListView��5-       �� View 5.      �� 5/      .P�50      �� $��Subject��6-    �� Width$	 200��6k    �� DisplayMemberBinding 6>   �� *SubjectName+6k   �� 51      $��Grade��6-   $	 100��6c    6<   �� *Value+6c   �� 52      $
��Date��6-   $	 200��6f    6;   �� *	CreatedAt+6f   53      55      56      �� 59      $��2��6   $ 10��6"   
����������#4B0082$��2q�6]   $ 10q�6q   $��0,10,0,0q�6~   ._�5:      �� .+�5;      �� $��Average Grades by Subject��6    $��20(�5<       $
��Bold"�6.   ���#4B0082$��0,0,0,10q�5=       �� 5@      $	��100��6#   $
��Auto=�60   .��5A      �� -   5        $��AverageGradesListView��5A   #    5B      �� 5C   "   .P�5D   &   �� $��Subject��65   $	 200��6s    6F   �� *SubjectName+6s   �� 5E   &   $��Average Grade��65   $	 150��6z    6L   �� *AverageGrade+6z   5F   #   5H      5I      �� 5L      $��25q�6!   .+�5M      �� -   5        	 ��Name$	 BarChartCanvas��5M   !   $	��116��69   ���#E6E6FA6F   5N      5O      5P      5Q      5R      5S      