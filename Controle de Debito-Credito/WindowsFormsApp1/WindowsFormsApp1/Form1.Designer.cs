namespace WindowsFormsApp1
{
    partial class Caixa
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnSalvarXML = new System.Windows.Forms.Button();
            this.btnCarregarXML = new System.Windows.Forms.Button();
            this.groupXML = new System.Windows.Forms.GroupBox();
            this.btnTotalizarCredito = new System.Windows.Forms.Button();
            this.btnTotalizarDebito = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupOperaçoes = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.comboPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.checkPeriodo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.checkMes = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupOperaçoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 28);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(6, 51);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 28);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(6, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 28);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(126, 17);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 28);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar ";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(6, 166);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(214, 28);
            this.btnGerarRelatorio.TabIndex = 4;
            this.btnGerarRelatorio.Text = "Gerar Relatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnSalvarXML
            // 
            this.btnSalvarXML.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvarXML.Location = new System.Drawing.Point(8, 17);
            this.btnSalvarXML.Name = "btnSalvarXML";
            this.btnSalvarXML.Size = new System.Drawing.Size(142, 28);
            this.btnSalvarXML.TabIndex = 5;
            this.btnSalvarXML.Text = "Salvar XML";
            this.btnSalvarXML.UseVisualStyleBackColor = false;
            this.btnSalvarXML.Click += new System.EventHandler(this.btnSalvarXML_Click);
            // 
            // btnCarregarXML
            // 
            this.btnCarregarXML.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarregarXML.Location = new System.Drawing.Point(8, 51);
            this.btnCarregarXML.Name = "btnCarregarXML";
            this.btnCarregarXML.Size = new System.Drawing.Size(142, 28);
            this.btnCarregarXML.TabIndex = 6;
            this.btnCarregarXML.Text = "Carregar XML";
            this.btnCarregarXML.UseVisualStyleBackColor = false;
            this.btnCarregarXML.Click += new System.EventHandler(this.btnCarregarXML_Click);
            // 
            // groupXML
            // 
            this.groupXML.Controls.Add(this.btnSalvarXML);
            this.groupXML.Controls.Add(this.btnCarregarXML);
            this.groupXML.Location = new System.Drawing.Point(12, 419);
            this.groupXML.Name = "groupXML";
            this.groupXML.Size = new System.Drawing.Size(156, 89);
            this.groupXML.TabIndex = 7;
            this.groupXML.TabStop = false;
            this.groupXML.Text = "Salvar e Recuperar Dados";
            // 
            // btnTotalizarCredito
            // 
            this.btnTotalizarCredito.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTotalizarCredito.Location = new System.Drawing.Point(6, 266);
            this.btnTotalizarCredito.Name = "btnTotalizarCredito";
            this.btnTotalizarCredito.Size = new System.Drawing.Size(214, 28);
            this.btnTotalizarCredito.TabIndex = 8;
            this.btnTotalizarCredito.Text = "Totalizar Crédito";
            this.btnTotalizarCredito.UseVisualStyleBackColor = false;
            this.btnTotalizarCredito.Click += new System.EventHandler(this.btnTotalizarCredito_Click);
            // 
            // btnTotalizarDebito
            // 
            this.btnTotalizarDebito.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTotalizarDebito.Location = new System.Drawing.Point(6, 232);
            this.btnTotalizarDebito.Name = "btnTotalizarDebito";
            this.btnTotalizarDebito.Size = new System.Drawing.Size(214, 28);
            this.btnTotalizarDebito.TabIndex = 9;
            this.btnTotalizarDebito.Text = "Totalizar Débito";
            this.btnTotalizarDebito.UseVisualStyleBackColor = false;
            this.btnTotalizarDebito.Click += new System.EventHandler(this.btnTotalizarDebito_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSaldo.Location = new System.Drawing.Point(6, 300);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(214, 28);
            this.btnSaldo.TabIndex = 10;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 70);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(603, 319);
            this.dgvDados.TabIndex = 11;
            // 
            // groupOperaçoes
            // 
            this.groupOperaçoes.Controls.Add(this.btnAdicionar);
            this.groupOperaçoes.Controls.Add(this.btnOrdenar);
            this.groupOperaçoes.Controls.Add(this.btnExcluir);
            this.groupOperaçoes.Controls.Add(this.btnAlterar);
            this.groupOperaçoes.Location = new System.Drawing.Point(621, 70);
            this.groupOperaçoes.Name = "groupOperaçoes";
            this.groupOperaçoes.Size = new System.Drawing.Size(227, 94);
            this.groupOperaçoes.TabIndex = 12;
            this.groupOperaçoes.TabStop = false;
            this.groupOperaçoes.Text = "Operações de Registro";
           
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOrdenar.Location = new System.Drawing.Point(126, 51);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(94, 28);
            this.btnOrdenar.TabIndex = 25;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Info;
            this.txtPesquisa.Location = new System.Drawing.Point(253, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(81, 22);
            this.txtPesquisa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 392);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(13, 13);
            this.lblMensagem.TabIndex = 24;
            this.lblMensagem.Text = "...";
            this.lblMensagem.Visible = false;
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.FormattingEnabled = true;
            this.comboPesquisa.Location = new System.Drawing.Point(115, 18);
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(121, 21);
            this.comboPesquisa.TabIndex = 25;
            this.comboPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboPesquisa_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.comboPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 52);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Pesquisa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaldo);
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnTotalizarDebito);
            this.groupBox2.Controls.Add(this.btnTotalizarCredito);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnGerarRelatorio);
            this.groupBox2.Location = new System.Drawing.Point(621, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 338);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de Relatorio e Totalização";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAtualizar.Location = new System.Drawing.Point(6, 198);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(214, 28);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar Dados Exibidos";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFinal);
            this.groupBox4.Controls.Add(this.lblDataFinal);
            this.groupBox4.Controls.Add(this.dtpInicial);
            this.groupBox4.Controls.Add(this.lblDataInicial);
            this.groupBox4.Controls.Add(this.checkPeriodo);
            this.groupBox4.Location = new System.Drawing.Point(102, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 148);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(20, 101);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(79, 22);
            this.dtpFinal.TabIndex = 28;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(24, 85);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(58, 13);
            this.lblDataFinal.TabIndex = 29;
            this.lblDataFinal.Text = "Data Final";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(20, 58);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(79, 22);
            this.dtpInicial.TabIndex = 28;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(21, 39);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(61, 13);
            this.lblDataInicial.TabIndex = 2;
            this.lblDataInicial.Text = "Data Incial";
            // 
            // checkPeriodo
            // 
            this.checkPeriodo.AutoSize = true;
            this.checkPeriodo.Location = new System.Drawing.Point(20, 19);
            this.checkPeriodo.Name = "checkPeriodo";
            this.checkPeriodo.Size = new System.Drawing.Size(66, 17);
            this.checkPeriodo.TabIndex = 1;
            this.checkPeriodo.Text = "Período";
            this.checkPeriodo.UseVisualStyleBackColor = true;
            this.checkPeriodo.CheckedChanged += new System.EventHandler(this.checkPeriodo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboMes);
            this.groupBox3.Controls.Add(this.checkMes);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 148);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(6, 42);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(78, 21);
            this.comboMes.TabIndex = 1;
            // 
            // checkMes
            // 
            this.checkMes.AutoSize = true;
            this.checkMes.Location = new System.Drawing.Point(19, 19);
            this.checkMes.Name = "checkMes";
            this.checkMes.Size = new System.Drawing.Size(47, 17);
            this.checkMes.TabIndex = 0;
            this.checkMes.Text = "Mês";
            this.checkMes.UseVisualStyleBackColor = true;
            this.checkMes.CheckedChanged += new System.EventHandler(this.checkMes_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(466, 392);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 22);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.Visible = false;
          
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(253, 19);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(81, 22);
            this.dtpData.TabIndex = 29;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 513);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupOperaçoes);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.groupXML);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.groupXML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupOperaçoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnSalvarXML;
        private System.Windows.Forms.Button btnCarregarXML;
        private System.Windows.Forms.GroupBox groupXML;
        private System.Windows.Forms.Button btnTotalizarCredito;
        private System.Windows.Forms.Button btnTotalizarDebito;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.GroupBox groupOperaçoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        public System.Windows.Forms.DataGridView dgvDados;
        public System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboPesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        public System.Windows.Forms.CheckBox checkPeriodo;
        public System.Windows.Forms.CheckBox checkMes;
        public System.Windows.Forms.DateTimePicker dtpFinal;
        public System.Windows.Forms.DateTimePicker dtpInicial;
        public System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Label lblMensagem;
        public System.Windows.Forms.DateTimePicker dtpData;
    }
}

