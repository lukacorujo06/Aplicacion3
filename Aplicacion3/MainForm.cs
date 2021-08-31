using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacion3{

	public partial class MainForm : Form{
		
		public MainForm(){

			InitializeComponent();

		}
		
		void Btn_mostrar_imagenClick(object sender, EventArgs e)
		{
			
			pic_foto.Image = Image.FromFile ("C:\\Users\\LAB03\\Downloads\\ford-mustang-gt350-2020_3840x2683_xtrafondos.com.jpg");
			
		}
	}
}
