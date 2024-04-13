namespace SistemaPI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_listar = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomePrt = new System.Windows.Forms.TextBox();
            this.lblNomeDaPartida = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCriarPrt = new System.Windows.Forms.Button();
            this.lblJogador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblidSorteado = new System.Windows.Forms.Label();
            this.lblJogadorID = new System.Windows.Forms.Label();
            this.lblJogadorSenha = new System.Windows.Forms.Label();
            this.txtidJogador = new System.Windows.Forms.TextBox();
            this.txtsenhaJogador = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblSorteado = new System.Windows.Forms.Label();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.lblCartaID = new System.Windows.Forms.Label();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblCartaJogada = new System.Windows.Forms.Label();
            this.lblValorCartaJogada = new System.Windows.Forms.Label();
            this.lblCartaApostada = new System.Windows.Forms.Label();
            this.lblValorCartaApostada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.ForeColor = System.Drawing.Color.Black;
            this.btn_listar.Location = new System.Drawing.Point(12, 42);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(110, 23);
            this.btn_listar.TabIndex = 4;
            this.btn_listar.Text = "Listar partidas";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(12, 66);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(191, 160);
            this.lstPartidas.TabIndex = 6;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Location = new System.Drawing.Point(263, 89);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(132, 108);
            this.lstJogadores.TabIndex = 20;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.Black;
            this.lblVersao.Location = new System.Drawing.Point(801, 446);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(41, 15);
            this.lblVersao.TabIndex = 11;
            this.lblVersao.Text = "label4";
            // 
            // txtNomePrt
            // 
            this.txtNomePrt.Location = new System.Drawing.Point(3, 269);
            this.txtNomePrt.Name = "txtNomePrt";
            this.txtNomePrt.Size = new System.Drawing.Size(110, 20);
            this.txtNomePrt.TabIndex = 14;
            // 
            // lblNomeDaPartida
            // 
            this.lblNomeDaPartida.AutoSize = true;
            this.lblNomeDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDaPartida.ForeColor = System.Drawing.Color.White;
            this.lblNomeDaPartida.Location = new System.Drawing.Point(3, 250);
            this.lblNomeDaPartida.Name = "lblNomeDaPartida";
            this.lblNomeDaPartida.Size = new System.Drawing.Size(108, 16);
            this.lblNomeDaPartida.TabIndex = 13;
            this.lblNomeDaPartida.Text = "Nome da partida";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(3, 292);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(55, 292);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(58, 20);
            this.txtSenha.TabIndex = 16;
            // 
            // btnCriarPrt
            // 
            this.btnCriarPrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPrt.ForeColor = System.Drawing.Color.Black;
            this.btnCriarPrt.Location = new System.Drawing.Point(119, 269);
            this.btnCriarPrt.Name = "btnCriarPrt";
            this.btnCriarPrt.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPrt.TabIndex = 17;
            this.btnCriarPrt.Text = "Criar Partida";
            this.btnCriarPrt.UseVisualStyleBackColor = true;
            this.btnCriarPrt.Click += new System.EventHandler(this.btnCriarPrt_Click);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.ForeColor = System.Drawing.Color.White;
            this.lblJogador.Location = new System.Drawing.Point(260, 70);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(123, 16);
            this.lblJogador.TabIndex = 18;
            this.lblJogador.Text = "Lista de Jogadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(586, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Budapeste";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(260, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 16);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Id da Partida: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(358, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(43, 20);
            this.txtID.TabIndex = 23;
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(263, 219);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(132, 20);
            this.txtJogador.TabIndex = 24;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(272, 203);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 16);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnEntrarPartida.Location = new System.Drawing.Point(263, 245);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(104, 23);
            this.btnEntrarPartida.TabIndex = 26;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblidSorteado
            // 
            this.lblidSorteado.AutoSize = true;
            this.lblidSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidSorteado.ForeColor = System.Drawing.Color.Black;
            this.lblidSorteado.Location = new System.Drawing.Point(132, 346);
            this.lblidSorteado.Name = "lblidSorteado";
            this.lblidSorteado.Size = new System.Drawing.Size(41, 15);
            this.lblidSorteado.TabIndex = 27;
            this.lblidSorteado.Text = "label4";
            this.lblidSorteado.Visible = false;
            // 
            // lblJogadorID
            // 
            this.lblJogadorID.AutoSize = true;
            this.lblJogadorID.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorID.ForeColor = System.Drawing.Color.Transparent;
            this.lblJogadorID.Location = new System.Drawing.Point(206, 296);
            this.lblJogadorID.Name = "lblJogadorID";
            this.lblJogadorID.Size = new System.Drawing.Size(91, 16);
            this.lblJogadorID.TabIndex = 29;
            this.lblJogadorID.Text = "Id do Jogador";
            // 
            // lblJogadorSenha
            // 
            this.lblJogadorSenha.AutoSize = true;
            this.lblJogadorSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblJogadorSenha.Location = new System.Drawing.Point(315, 296);
            this.lblJogadorSenha.Name = "lblJogadorSenha";
            this.lblJogadorSenha.Size = new System.Drawing.Size(119, 16);
            this.lblJogadorSenha.TabIndex = 30;
            this.lblJogadorSenha.Text = "Senha do Jogador";
            // 
            // txtidJogador
            // 
            this.txtidJogador.Location = new System.Drawing.Point(226, 315);
            this.txtidJogador.Name = "txtidJogador";
            this.txtidJogador.Size = new System.Drawing.Size(88, 20);
            this.txtidJogador.TabIndex = 31;
            // 
            // txtsenhaJogador
            // 
            this.txtsenhaJogador.Location = new System.Drawing.Point(334, 315);
            this.txtsenhaJogador.Name = "txtsenhaJogador";
            this.txtsenhaJogador.Size = new System.Drawing.Size(88, 20);
            this.txtsenhaJogador.TabIndex = 32;
            // 
            // btnIniciar
            // 
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(485, 42);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(91, 23);
            this.btnIniciar.TabIndex = 33;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblSorteado
            // 
            this.lblSorteado.AutoSize = true;
            this.lblSorteado.BackColor = System.Drawing.Color.Transparent;
            this.lblSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorteado.ForeColor = System.Drawing.Color.White;
            this.lblSorteado.Location = new System.Drawing.Point(3, 346);
            this.lblSorteado.Name = "lblSorteado";
            this.lblSorteado.Size = new System.Drawing.Size(123, 16);
            this.lblSorteado.TabIndex = 34;
            this.lblSorteado.Text = "Jogador Sorteado: ";
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(459, 89);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(147, 329);
            this.lstCartas.TabIndex = 36;
            this.lstCartas.Visible = false;
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(281, 369);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(102, 20);
            this.txtIdCarta.TabIndex = 37;
            // 
            // lblCartaID
            // 
            this.lblCartaID.AutoSize = true;
            this.lblCartaID.BackColor = System.Drawing.Color.Transparent;
            this.lblCartaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaID.ForeColor = System.Drawing.Color.Transparent;
            this.lblCartaID.Location = new System.Drawing.Point(295, 350);
            this.lblCartaID.Name = "lblCartaID";
            this.lblCartaID.Size = new System.Drawing.Size(72, 16);
            this.lblCartaID.TabIndex = 38;
            this.lblCartaID.Text = "Id da Carta";
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(263, 395);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(58, 24);
            this.btnJogarCarta.TabIndex = 39;
            this.btnJogarCarta.Text = "Jogar";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(340, 394);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(55, 24);
            this.btnApostar.TabIndex = 40;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblCartaJogada
            // 
            this.lblCartaJogada.AutoSize = true;
            this.lblCartaJogada.BackColor = System.Drawing.Color.Transparent;
            this.lblCartaJogada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaJogada.ForeColor = System.Drawing.Color.White;
            this.lblCartaJogada.Location = new System.Drawing.Point(206, 431);
            this.lblCartaJogada.Name = "lblCartaJogada";
            this.lblCartaJogada.Size = new System.Drawing.Size(143, 16);
            this.lblCartaJogada.TabIndex = 41;
            this.lblCartaJogada.Text = "Valor da carta jogada: ";
            // 
            // lblValorCartaJogada
            // 
            this.lblValorCartaJogada.AutoSize = true;
            this.lblValorCartaJogada.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaJogada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaJogada.ForeColor = System.Drawing.Color.Black;
            this.lblValorCartaJogada.Location = new System.Drawing.Point(360, 431);
            this.lblValorCartaJogada.Name = "lblValorCartaJogada";
            this.lblValorCartaJogada.Size = new System.Drawing.Size(41, 15);
            this.lblValorCartaJogada.TabIndex = 42;
            this.lblValorCartaJogada.Text = "label4";
            this.lblValorCartaJogada.Visible = false;
            // 
            // lblCartaApostada
            // 
            this.lblCartaApostada.AutoSize = true;
            this.lblCartaApostada.BackColor = System.Drawing.Color.Transparent;
            this.lblCartaApostada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaApostada.ForeColor = System.Drawing.Color.White;
            this.lblCartaApostada.Location = new System.Drawing.Point(206, 459);
            this.lblCartaApostada.Name = "lblCartaApostada";
            this.lblCartaApostada.Size = new System.Drawing.Size(155, 16);
            this.lblCartaApostada.TabIndex = 43;
            this.lblCartaApostada.Text = "Valor da carta apostada:";
            // 
            // lblValorCartaApostada
            // 
            this.lblValorCartaApostada.AutoSize = true;
            this.lblValorCartaApostada.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaApostada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaApostada.ForeColor = System.Drawing.Color.Black;
            this.lblValorCartaApostada.Location = new System.Drawing.Point(367, 460);
            this.lblValorCartaApostada.Name = "lblValorCartaApostada";
            this.lblValorCartaApostada.Size = new System.Drawing.Size(41, 15);
            this.lblValorCartaApostada.TabIndex = 44;
            this.lblValorCartaApostada.Text = "label4";
            this.lblValorCartaApostada.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 492);
            this.Controls.Add(this.lblValorCartaApostada);
            this.Controls.Add(this.lblCartaApostada);
            this.Controls.Add(this.lblValorCartaJogada);
            this.Controls.Add(this.lblCartaJogada);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogarCarta);
            this.Controls.Add(this.lblCartaID);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.lblSorteado);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtsenhaJogador);
            this.Controls.Add(this.txtidJogador);
            this.Controls.Add(this.lblJogadorSenha);
            this.Controls.Add(this.lblJogadorID);
            this.Controls.Add(this.lblidSorteado);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtJogador);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnCriarPrt);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeDaPartida);
            this.Controls.Add(this.txtNomePrt);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btn_listar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomePrt;
        private System.Windows.Forms.Label lblNomeDaPartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCriarPrt;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblidSorteado;
        private System.Windows.Forms.Label lblJogadorID;
        private System.Windows.Forms.Label lblJogadorSenha;
        private System.Windows.Forms.TextBox txtidJogador;
        private System.Windows.Forms.TextBox txtsenhaJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblSorteado;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.Label lblCartaID;
        private System.Windows.Forms.Button btnJogarCarta;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblCartaJogada;
        private System.Windows.Forms.Label lblValorCartaJogada;
        private System.Windows.Forms.Label lblCartaApostada;
        private System.Windows.Forms.Label lblValorCartaApostada;
    }
}

