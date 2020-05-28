namespace WindowsFormsApp1
{
    partial class Registro
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescriçao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescriçao = new System.Windows.Forms.Label();
            this.lblNatureza = new System.Windows.Forms.Label();
            this.comboNatureza = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Info;
            this.txtValor.Location = new System.Drawing.Point(144, 69);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtDescriçao
            // 
            this.txtDescriçao.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescriçao.Location = new System.Drawing.Point(12, 151);
            this.txtDescriçao.Multiline = true;
            this.txtDescriçao.Name = "txtDescriçao";
            this.txtDescriçao.Size = new System.Drawing.Size(360, 120);
            this.txtDescriçao.TabIndex = 2;
            this.txtDescriçao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescriçao_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(141, 49);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // lblDescriçao
            // 
            this.lblDescriçao.AutoSize = true;
            this.lblDescriçao.Location = new System.Drawing.Point(24, 125);
            this.lblDescriçao.Name = "lblDescriçao";
            this.lblDescriçao.Size = new System.Drawing.Size(56, 13);
            this.lblDescriçao.TabIndex = 6;
            this.lblDescriçao.Text = "Descrição";
            // 
            // lblNatureza
            // 
            this.lblNatureza.AutoSize = true;
            this.lblNatureza.Location = new System.Drawing.Point(9, 49);
            this.lblNatureza.Name = "lblNatureza";
            this.lblNatureza.Size = new System.Drawing.Size(52, 13);
            this.lblNatureza.TabIndex = 7;
            this.lblNatureza.Text = "Natureza";
            // 
            // comboNatureza
            // 
            this.comboNatureza.BackColor = System.Drawing.SystemColors.Info;
            this.comboNatureza.FormattingEnabled = true;
            this.comboNatureza.Location = new System.Drawing.Point(12, 68);
            this.comboNatureza.Name = "comboNatureza";
            this.comboNatureza.Size = new System.Drawing.Size(100, 21);
            this.comboNatureza.TabIndex = 8;
            this.comboNatureza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboNatureza_KeyPress);
            // 
            // dtpData
            // 
            this.dtpData.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(272, 68);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 22);
            this.dtpData.TabIndex = 9;
            this.dtpData.Value = new System.DateTime(2019, 6, 2, 14, 9, 21, 0);
            this.dtpData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpData_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(269, 49);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvar.Location = new System.Drawing.Point(297, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(12, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.comboNatureza);
            this.Controls.Add(this.lblNatureza);
            this.Controls.Add(this.lblDescriçao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDescriçao);
            this.Controls.Add(this.txtValor);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescriçao;
        private System.Windows.Forms.Label lblNatureza;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDescriçao;
        public System.Windows.Forms.ComboBox comboNatureza;
        public System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnSalvar;
    }
}