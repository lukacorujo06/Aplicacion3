/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 30/8/2021
 * Time: 8:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Aplicacion3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic_foto = new System.Windows.Forms.PictureBox();
			this.btn_mostrar_imagen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_foto
			// 
			this.pic_foto.Location = new System.Drawing.Point(50, 36);
			this.pic_foto.Name = "pic_foto";
			this.pic_foto.Size = new System.Drawing.Size(176, 134);
			this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_foto.TabIndex = 0;
			this.pic_foto.TabStop = false;
			// 
			// btn_mostrar_imagen
			// 
			this.btn_mostrar_imagen.Location = new System.Drawing.Point(80, 204);
			this.btn_mostrar_imagen.Name = "btn_mostrar_imagen";
			this.btn_mostrar_imagen.Size = new System.Drawing.Size(125, 23);
			this.btn_mostrar_imagen.TabIndex = 1;
			this.btn_mostrar_imagen.Text = "Mostrar imagen";
			this.btn_mostrar_imagen.UseVisualStyleBackColor = true;
			this.btn_mostrar_imagen.Click += new System.EventHandler(this.Btn_mostrar_imagenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_mostrar_imagen);
			this.Controls.Add(this.pic_foto);
			this.Name = "MainForm";
			this.Text = "Aplicacion3";
			((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_mostrar_imagen;
		private System.Windows.Forms.PictureBox pic_foto;
	}
}
