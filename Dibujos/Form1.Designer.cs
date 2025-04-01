using System.ComponentModel;

namespace RectanglesFactoryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CajaColor = new System.Windows.Forms.PictureBox();
            this.btnCREATOR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CajaColor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(53, 22);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(45, 20);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(53, 59);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(45, 20);
            this.txtY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 219);
            this.panel1.TabIndex = 4;
            // 
            // CajaColor
            // 
            this.CajaColor.Location = new System.Drawing.Point(53, 96);
            this.CajaColor.Name = "CajaColor";
            this.CajaColor.Size = new System.Drawing.Size(52, 34);
            this.CajaColor.TabIndex = 5;
            this.CajaColor.TabStop = false;
            // 
            // btnCREATOR
            // 
            this.btnCREATOR.Location = new System.Drawing.Point(104, 25);
            this.btnCREATOR.Name = "btnCREATOR";
            this.btnCREATOR.Size = new System.Drawing.Size(109, 46);
            this.btnCREATOR.TabIndex = 6;
            this.btnCREATOR.Text = "CREAR";
            this.btnCREATOR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCREATOR);
            this.Controls.Add(this.CajaColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.CajaColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CajaColor;
        private System.Windows.Forms.Button btnCREATOR;
    }
}

