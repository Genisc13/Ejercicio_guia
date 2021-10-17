
namespace Conversor_Fahrenheit_Celsius
{
    partial class Conversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.CF = new System.Windows.Forms.RadioButton();
            this.FC = new System.Windows.Forms.RadioButton();
            this.Enviar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(111, 101);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(186, 93);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(111, 233);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(186, 102);
            this.Desconectar.TabIndex = 1;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // CF
            // 
            this.CF.AutoSize = true;
            this.CF.Location = new System.Drawing.Point(376, 233);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(163, 29);
            this.CF.TabIndex = 2;
            this.CF.TabStop = true;
            this.CF.Text = "Pasar de ºC a ºF";
            this.CF.UseVisualStyleBackColor = true;
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Location = new System.Drawing.Point(376, 297);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(163, 29);
            this.FC.TabIndex = 3;
            this.FC.TabStop = true;
            this.FC.Text = "Pasar de ºF a ºC";
            this.FC.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(570, 205);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(112, 34);
            this.Enviar.TabIndex = 4;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(376, 163);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(150, 31);
            this.numero.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(322, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recuerde conectarse al servidor antes de usar el conversor";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.FC);
            this.Controls.Add(this.CF);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.RadioButton CF;
        private System.Windows.Forms.RadioButton FC;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
    }
}

