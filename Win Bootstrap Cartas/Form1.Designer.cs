
namespace Win_Bootstrap_Cartas
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
            this.butAceptar = new System.Windows.Forms.Button();
            this.butSacarCarta = new System.Windows.Forms.Button();
            this.butCartaR = new System.Windows.Forms.Button();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.butNumCartas = new System.Windows.Forms.Button();
            this.listCartas = new System.Windows.Forms.ListBox();
            this.butListaCartas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(552, 360);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(126, 46);
            this.butAceptar.TabIndex = 0;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            // 
            // butSacarCarta
            // 
            this.butSacarCarta.Location = new System.Drawing.Point(394, 360);
            this.butSacarCarta.Name = "butSacarCarta";
            this.butSacarCarta.Size = new System.Drawing.Size(126, 46);
            this.butSacarCarta.TabIndex = 1;
            this.butSacarCarta.Text = "Sacar Carta";
            this.butSacarCarta.UseVisualStyleBackColor = true;
            this.butSacarCarta.Click += new System.EventHandler(this.butSacarCarta_Click);
            // 
            // butCartaR
            // 
            this.butCartaR.Location = new System.Drawing.Point(235, 360);
            this.butCartaR.Name = "butCartaR";
            this.butCartaR.Size = new System.Drawing.Size(126, 46);
            this.butCartaR.TabIndex = 3;
            this.butCartaR.Text = "1 Random Card";
            this.butCartaR.UseVisualStyleBackColor = true;
            this.butCartaR.Click += new System.EventHandler(this.butCartaR_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(78, 315);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(122, 21);
            this.chkRandom.TabIndex = 5;
            this.chkRandom.Text = "Randomizador";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // butNumCartas
            // 
            this.butNumCartas.Location = new System.Drawing.Point(78, 360);
            this.butNumCartas.Name = "butNumCartas";
            this.butNumCartas.Size = new System.Drawing.Size(126, 46);
            this.butNumCartas.TabIndex = 6;
            this.butNumCartas.Text = "Numero de cartas";
            this.butNumCartas.UseVisualStyleBackColor = true;
            this.butNumCartas.Click += new System.EventHandler(this.butNumCartas_Click);
            // 
            // listCartas
            // 
            this.listCartas.FormattingEnabled = true;
            this.listCartas.ItemHeight = 16;
            this.listCartas.Location = new System.Drawing.Point(573, 12);
            this.listCartas.Name = "listCartas";
            this.listCartas.Size = new System.Drawing.Size(173, 324);
            this.listCartas.TabIndex = 7;
            // 
            // butListaCartas
            // 
            this.butListaCartas.Location = new System.Drawing.Point(394, 12);
            this.butListaCartas.Name = "butListaCartas";
            this.butListaCartas.Size = new System.Drawing.Size(126, 46);
            this.butListaCartas.TabIndex = 8;
            this.butListaCartas.Text = "Actualizar lista cartas";
            this.butListaCartas.UseVisualStyleBackColor = true;
            this.butListaCartas.Click += new System.EventHandler(this.butListaCartas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butListaCartas);
            this.Controls.Add(this.listCartas);
            this.Controls.Add(this.butNumCartas);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.butCartaR);
            this.Controls.Add(this.butSacarCarta);
            this.Controls.Add(this.butAceptar);
            this.Name = "Form1";
            this.Text = "Juego de Cartas Freak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butSacarCarta;
        private System.Windows.Forms.Button butCartaR;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Button butNumCartas;
        private System.Windows.Forms.ListBox listCartas;
        private System.Windows.Forms.Button butListaCartas;
    }
}

