   M S B A M L   `   `   `  ����C  ?Proyecto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProyectoProyecto  5   	       Proyecto.padrinoWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Proyecto     5   	     � Title$0  *Adopta un Amigo - Información del Padrino��5   	   $	��720��6;   $
��1080��6H    � WindowState$ 	Maximized=�6U    � 
ResizeMode$ 	CanResize=�6m   $
��1080��6�   $	��720��6�   .��5	      � ��5
   
   �� 5       �� ImageSource$ Images/fondo_usuario.png��6   .+�5   
   �� $��Datos Personales��6   $��330,10,28.6,334.4q�5      $��346.4��5      $	��715��6"   �� 5   
   $��Datos Financieros��6   $��37,361,28.6,135.4q�5      $��194.4��5      $
��1008��6"   �� 5   
   $��Nombre��6   $��380,44,580.6,604.4q�5      $��42��5      $	��113��6   �� 5   
   $��	Apellidos��6   $��380,124,321.6,525.4q�5      $
��40.8��5      $	��372��6   �� 5   
   $��Correo Electrónico��6   $��380,261,488.6,390.4q�5      $
��39.2��5       $��204.8��6   �� 5"   
   $��Telefono��6   $��380,193,488.6,458.4q�5#      $
��39.2��5$      $��204.8��6   �� 5&   
   $��
Nº Cuenta��6   $��36��5'      $	��232��6   $��66,400,775.6,254.4q�5(      �� 5*   
   $��Ayuda��6   $��42��5+      $	��224��6   $��66,472,783.6,176.4q�5,      �� 5.   
   $��Tipo de Pago��6   $��40��5/      $	��254��6   $��559,400,260.6,250.4q�50      �� 53   
   $��28��54      $	��392��6   $��402,86,279.6,576.4q�55       �� TextWrapping$
 Wrap=�56       � ToolTip$  Nombre del padrino/madrina��57      ��58      �� *nombre+�� 5:   
   $��23��5;      $	��392��6   $��402,165,279.6,502.4q�5<      $
 Wrap=�5=      $# Apellidos del padrino/madrina��5>      ��5?      �� *	apellidos+�� 5A   
   $��23��5B      $	��392��6   $��402,232,279.6,435.4q�5C      $
 Wrap=�5D      $# Apellidos del padrino/madrina��5E      ��5F      �� *
telefono+�� 5H   
   $��23��5I      $	��392��6   $��402,300,279.6,367.4q�5J      $
 Wrap=�5K      $  E-mail del padrino/madrina��5L      ��5M      �� *correo+�� 5O   
   $��31��5P      $	��331��6   $��97,436,645.6,223.4q�5Q      $* $Numero de cuenta del padrino/madrina��5R      $
 Wrap=�5S      ��6!   �� *cuenta+�� 5U   
   $��31��5V      $	��331��6   $��97,507,645.6,152.4q�5W      $* $Ayuda económica del padrino/madrina��5X      $
 Wrap=�5Y      ��6!   �� *ayuda+�� 5[   
   $��31��5\      $	��321��6   $��584,436,168.6,223.4q�5]      $&  Tipo de pago del padrino/madrina��5^      $
 Wrap=�5_      ��6!   �� *pago+�� 5a   
   $��Stretch=�6   $��Stretch=�6.   $��66,66,816.6,390.4q�5b      $��234.4��5c      $	��191��6   $��Images/Cogo.jpg��5d      $
��Fill=�6)   �� 5f   
   -   5         ��Name$ btnInfo��5f      $��66,617,966.6,37.4q�6"    J� RenderTransformOrigin$ 
2.27,0.475&�6=   $��36��6`   $
��40.8��6l   ���	#00707070��5g      �� 5h      $ Images/ayuda.png��6    j� Stretch$ Uniform=�5i      5k      �� 5m   
   -   5        $ 	btnApagar��5m      $��938,605,56,25q�6$   $ 0.5,0.5&�6;   $��36��6[   $
��40.8��6g   ���	#00707070��5n      �� 5o      $ Images/apagar.png��6   $ Uniform=�5p      5r      5w      	 � 	Resources	 5y      
 �� 
TargetType �� Property �� Value��%  '��       '�� �     '�� �    '�� �    �� 5z   
   "
 ��6   .�5{      ��  � ��$ 18(�6)   �� 5|       � ��$ SemiBold"�6+   �� 5}       � ��$ Stretch=�64   �� 5~       � ��$ Stretch=�62   5      �� 5�   
   "
 ��6   .�5�      ��  � �� �	#7FFFFFFF6+   �� 5�       � ��
 �   �6,   �� 5�       � ��$ Stretch=�64   �� 5�       � ��$ Stretch=�62   5�      �� 5�   
   "
 ��6   .�5�      ��  � ��$ 22(�6)   �� 5�       � �� �	#660807076+   �� 5�       � �� �	#FFFC00006,   �� 5�       � ��
 �����6+   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��$ Stretch=�64   �� 5�       � ��$ Stretch=�62   5�      �� 5�   
   "
 ��6   .�5�      ��  � ��$ Stretch=�64   �� 5�       � ��$ Stretch=�62   �� 5�       � ��$ 14(�6)   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��$
 60.8��6'   �� 5�       � ��$ 152.8��6&   5�      5�      5�      