﻿namespace Suma_Con_Get_Set
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(165, 68);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 20);
            this.txtv1.TabIndex = 1;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(165, 108);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 20);
            this.txtv2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(165, 148);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 20);
            this.txtresult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(165, 210);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 289);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSumar;
    }
}

