
namespace EjerciciosPractica1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBoton = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoton.Location = new System.Drawing.Point(94, 224);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(138, 45);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Hacer Click";
            this.btnBoton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.White;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DimGray;
            this.lbl.Location = new System.Drawing.Point(94, 148);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 22);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Primer App";
            this.lbl.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Location = new System.Drawing.Point(94, 327);
            this.txtBox.MaxLength = 20;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(138, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(339, 510);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnBoton);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer Aplicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBoton;
		private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtBox;
    }
}

