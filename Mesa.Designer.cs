namespace SistemaPI
{
    partial class panelCarta
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
            this.lblJogadas = new System.Windows.Forms.Label();
            this.txtidJogador = new System.Windows.Forms.TextBox();
            this.txtsenhaJogador = new System.Windows.Forms.TextBox();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJogadas
            // 
            this.lblJogadas.AutoSize = true;
            this.lblJogadas.Location = new System.Drawing.Point(63, 610);
            this.lblJogadas.Name = "lblJogadas";
            this.lblJogadas.Size = new System.Drawing.Size(76, 13);
            this.lblJogadas.TabIndex = 1;
            this.lblJogadas.Text = "Carta Jogada: ";
            this.lblJogadas.Visible = false;
            // 
            // txtidJogador
            // 
            this.txtidJogador.Location = new System.Drawing.Point(49, 455);
            this.txtidJogador.Name = "txtidJogador";
            this.txtidJogador.Size = new System.Drawing.Size(100, 20);
            this.txtidJogador.TabIndex = 2;
            // 
            // txtsenhaJogador
            // 
            this.txtsenhaJogador.Location = new System.Drawing.Point(49, 493);
            this.txtsenhaJogador.Name = "txtsenhaJogador";
            this.txtsenhaJogador.Size = new System.Drawing.Size(100, 20);
            this.txtsenhaJogador.TabIndex = 3;
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(49, 533);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarta.TabIndex = 4;
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(64, 559);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(75, 23);
            this.btnJogarCarta.TabIndex = 5;
            this.btnJogarCarta.Text = "button1";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click_1);
            // 
            // panelCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnJogarCarta);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.txtsenhaJogador);
            this.Controls.Add(this.txtidJogador);
            this.Controls.Add(this.lblJogadas);
            this.Name = "panelCarta";
            this.Text = "Mao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJogadas;
        private System.Windows.Forms.TextBox txtidJogador;
        private System.Windows.Forms.TextBox txtsenhaJogador;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.Button btnJogarCarta;
    }
}