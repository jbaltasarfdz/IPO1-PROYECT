   M S B A M L   `   `   `  ����C  ?Proyecto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProyectoProyecto  5   	       Proyecto.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Proyecto     5   	   Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  Adopta un Amigo - Login��5	   	   $	��500��6)   $	��800��66    � WindowState$ 	Maximized=�6B    � 
ResizeMode$ 	CanResize=�6Z   $	��800��6q   $	��500��6�    � 	Resources 5
         plantillaFeedbackError��%  &	        �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      �� .v�5      �� 
���  ��$��Right=�5       $��Bottom=�5       $��0,0,3,3q�5       $��7(�5       ��5       �� *[0].ErrorContent+5       5      5      5      5      .��5      � $��
0,0,-0.4,0q�6   ��5   
   �� 5       �� ImageSource$V PImages/depositphotos_318003308-stock-illustration-silver-line-paw-print-icon.jpg��6   .+�5   
   �� ���	#FF010103$��Stretch=�5      $��Stretch=�62   $	��296��5       $	��255��6!   $	��296��6-   $	��255��6=   $��419,62,120,112.4q�5!      
���   � J� Opacity$	 0.7Q�5"   #    �� RadiusY$ 5��5#       �� RadiusX$ 5��6    �� 5&   
   
���   �$��Stretch=�5'      $��Stretch=�62   $	��243��5(      $	��196��6"   $	��243��6.   $	��196��6>   $��87,88,511,139.4q�5)      
���   �$	 0.7Q�5*   $   $ 5��5+      $ 5��6    �� 5.   
   -   5         ��Name$ lblContraseña��5.        lblContraseña#���  6'   $��Stretch=�5/      $��Stretch=�6.   $��443,173,274,269.4q�50      
�������$��28��52      $��77��6   $��28��6'   $��77��66   �� 55   
   -   5        $ lblLogin��55        lblLogin#���  6"   $��Stretch=�56      $��Stretch=�6.   $��432,78,237,357.4q�57      
�������$��18(�58   #   $��Segoe UI Semibold)�61   $��35��59      $	��125��6   $��35��6(   $	��125��67   �� 5<   
   -   5        $ 
lblUsuario��5<        
lblUsuario#���  6$   $��Stretch=�5=      $��Stretch=�6.   $��443,113,298,329.4q�5>      
�������$��28��5@      $��53��6   $��28��6'   $��53��66   �� 5C   
   -   5        $ lblNombreEmpresa��5C      $��Adopta un Amigo��6*   $��Stretch=�5D      $��Stretch=�6.   $��108,258,527,178.4q�5E      
�������$��Segoe UI Semibold)�5F   #   $��18(�6B   $��34��5G      $	��159��6   $��33��6(   $	��159��67   &   System.Windows.Media.TextOptions	   TextHintingMode$	 Fixed=�5H      �� 5K   
   -   5        
 ��Name$
 
txtUsuario��5K      $��Stretch=�5L      $��Stretch=�60   $��443,142,172,297.4q�5M       �� TextWrapping$
 Wrap=�5N       �� SelectionBrush �	#FF888888���	#FF888888���	#FF433B3B$��31��5P      $	��179��6   $��31��6*   $	��179��69    � ToolTip$ Introduzca su usuario��5Q       =� ErrorTemplate# [  5R   /   .��6r   ��5S      �� 5T       �� Path$ Usuario�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6F    �� ValidationRules 5U      +  %Proyecto.ReglaRangoLongitudCaracteres  5V         MinimoCaracteres$ 4��5W   )      MaximoCaracteres$ 4��5X   )   5Z      .��5[      5\      �� 5^   
   -   5         ��Name$ btnLogin��5^        btnLogin#���  6#   $��Stretch=�5_      $��Stretch=�6/   $��483,262,195,178.4q�5`      ���	#FFCB0A0A
�������$��Segoe UI Semibold)�5b   ;   $��30��5c      $	��116��6   $��30��6)   $	��116��68   $  Pulse para iniciar sesión��5d      �� 5g   
   -   5        $ btnSettings��5g      $��Right=�5h      $	��Top=�6-   $��739,10,10,415.4q�5i      $��45��5k      $��45��6   $��44��6(   $��44��67   $ Ajustes��5l      ���	#00707070��5m      �� 5n      $ Images/settings.png��6    j� TileMode$ FlipX=�6?    j� Stretch$ Uniform=�6P   5p      �� 5r   
   $��Images/OIP.jpg��6   $��Stretch=�5s      $��Stretch=�6.   $��128,123,550,231.4q�5t      $	��116��5u      $	��116��6   $	��116��6)   $	��116��69   G� 5w   
   -   5        $��txtContrasena��5w      $��Stretch=�5x      $��443,201,172,236.4q�5y      $��Stretch=�5z       G� SelectionBrush �	#FF888888���	#FF888888���	#FF433B3B$	��179��5|      $��33��5}       G� PasswordChar$ *��5~      $ Introduzca su contraseña��5      �� 5�   
   -	   5         ��Name$ 	cbIdiomas��5�      $��Right=�5�      $	��Top=�6)   $��Center=�5�      $��34��5�      $��94��6   $��	0,16,67,0q�5�      .@�5�      �� -
   5        $��cbiEspaniol��5�      $��Center=�6.   .��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� $��Images/spain.png��6   $��15��66   $��15��6A   �� 5�      $��Center=�6      cbiEspaniol#���  6;   $	��5,0q�6`   5�      5�      �� 5�      -   5        $��	cbiIngles��5�      $��Center=�6,   .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Images/uk.png��6   $��15��63   $��15��6>   �� 5�      $��Center=�6      	cbiIngles#���  6;   $	��5,0q�6^   5�      5�      5�      �� 5�   
   -   5        $ 	lblEstado��5�      $��Estado de la Aplicación��6#   $��Bottom=�5�      $��Center=�5�      $��Center=�64   $��	0,0,0,0.4q�5�      ���	#FFF7F6F6$	 0.3Q�5�      $
��Bold"�6   $��46��60   5�      5�      