   M S B A M L   `   `   `  ����C  ?Proyecto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProyectoProyecto  5   	       Proyecto.userWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Proyecto     5   	     � Title$0  *Adopta un Amigo - Información del Usuario��5   	   $	��720��6;   $
��1080��6H    � WindowState$ 	Maximized=�6U    � 
ResizeMode$ 	CanResize=�6m   $
��1080��6�   $	��720��6�   .��5	      � ��5
   
   �� 5       �� ImageSource$ Images/fondo_usuario.png��6   .+�5   
   �� $��Datos Personales��6   $	��320��6.   $��330,10,28.6,360.4q�6;   $	��715��6W   �� 5   
   $��Último acceso��6   $	��140��6+   $��37,361,28.6,189.4q�68   $
��1008��6T   .��5      �� $��40��64   $��49,32,51,31.2q�6@   $	��896��6X    � ToolTip$0 *Fecha del último acceso del administrador��6d   ��6   �� *FechaAcceso+6d   5      �� 5   
   $��Nombre��6   $��445,44,515.6,604.4q�5      $��42��5      $	��113��6   �� 5   
   $��	Apellidos��6   $��445,119,256.6,530.4q�5      $
��40.8��5      $	��372��6   �� 5   
   $��Correo Electrónico��6   $��445,204,423.6,447.4q�5      $
��39.2��5      $��204.8��6   �� 5    
   $��454,86,227.6,576.4q�5!      $��28��5"      $	��392��6    �� TextWrapping$
 Wrap=�5#      $ Nombre del administrador��5$      $��Stretch=�5%      $��Stretch=�5&      ��5'      �� *Nombre+�� 5)   
   $��454,165,227.6,502.4q�5*      $��23��5+      $	��392��6   $
 Wrap=�5,      $! Apellidos del administrador��5-      $��Stretch=�5.      $��Stretch=�5/      ��50      �� *	Apellidos+�� 52   
   $��454,243,227.6,424.4q�53      $��23��54      $	��392��6   $
 Wrap=�55      $ E-mail del administrador��56      $��Stretch=�57      $��Stretch=�58      ��59      �� *Correo+�� 5;   
   -   5         ��Name$ btnGestionListadoPerros��5;      $��Gestión Listado Perros��62   $��104,549,816.6,80.4q�5<      $8 2Pulse para gestionar los animales de la protectora��5?      �� 5A   
   -   5        $ btnGestionVoluntarios��5A      $��Gestión Voluntarios��60   $��346,549,574.6,80.4q�5B      $; 5Pulse para gestionar los voluntarios de la protectora��5D      �� 5F   
   -   5        $ btnGestionSocios��5F      $��Gestión Socios��6+   $��581,549,339.6,80.4q�5G      $6 0Pulse para gestionar los socios de la protectora��5I      �� 5K   
   -   5        $ btnGestionAvisos��5K      $��Gestión Avisos��6+   $��813,549,107.6,80.4q�5L      $? 9Pulse para gestionar los avisos de animales desaparecidos��5N      �� 5P   
   $��Stretch=�6   $��Stretch=�6.   $��66,66,816.6,390.4q�5Q      $��234.4��5R      $	��191��6   $��Images/Carlos.jpeg��5S      $
��Fill=�6,   �� 5U   
   -   5        $ btnInfo��5U      $��28,626,1004.6,28.4q�6"    J� RenderTransformOrigin$ 
2.27,0.475&�6>   $��36��6a   $
��40.8��6m   ���	#00707070��5V      �� 5W      $ Images/ayuda.png��6    j� Stretch$ Uniform=�5X      5Z      �� 5\   
   -   5        $ 	btnApagar��5\      $��1004,626,28.6,28.4q�6$   $ 0.5,0.5&�6@   $��36��6`   $
��40.8��6l   ���	#00707070��5]      �� 5^      $ Images/apagar.png��6   $ Uniform=�5_      5a      5c      	 � 	Resources	 5e      
 �� 
TargetType �� Property �� Value��%  '��       '�� �     '�� �    '�� �    �� 5f   
   "
 ��6   .�5g      ��  � ��$ 18(�6)   �� 5h       � ��$ SemiBold"�6+   �� 5i       � ��$ Stretch=�64   �� 5j       � ��$ Stretch=�62   5k      �� 5m   
   "
 ��6   .�5n      ��  � �� �	#7FFFFFFF6+   �� 5o       � ��
 �   �6,   �� 5p       � ��$ Stretch=�64   �� 5q       � ��$ Stretch=�62   5r      �� 5t   
   "
 ��6   .�5u      ��  � ��$ 22(�6)   �� 5v       � �� �	#660807076+   �� 5w       � �� �	#FFFC00006,   �� 5x       � ��
 �����6+   �� 5y       � ��$ SemiBold"�6+   �� 5z       � ��$ Stretch=�64   �� 5{       � ��$ Stretch=�62   5|      �� 5~   
   "
 ��6   .�5      ��  � ��$ Stretch=�64   �� 5�       � ��$ Stretch=�62   �� 5�       � ��$ 14(�6)   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��$
 60.8��6'   �� 5�       � ��$ 152.8��6&   5�      5�      5�      