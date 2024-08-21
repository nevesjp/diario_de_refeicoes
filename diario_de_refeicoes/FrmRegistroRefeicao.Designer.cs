namespace diario_de_refeicoes
{
    partial class FrmRegistroRefeicao
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
            lblNome = new Label();
            lblDataRealizado = new Label();
            lblRealizado = new Label();
            cmbRefeicao = new ComboBox();
            txtDataRealizado = new TextBox();
            cmbRealizado = new ComboBox();
            btnSalvar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(83, 109);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Refeição:";
            // 
            // lblDataRealizado
            // 
            lblDataRealizado.AutoSize = true;
            lblDataRealizado.Location = new Point(51, 144);
            lblDataRealizado.Name = "lblDataRealizado";
            lblDataRealizado.Size = new Size(87, 15);
            lblDataRealizado.TabIndex = 1;
            lblDataRealizado.Text = "Data Realizado:";
            // 
            // lblRealizado
            // 
            lblRealizado.AutoSize = true;
            lblRealizado.Location = new Point(78, 178);
            lblRealizado.Name = "lblRealizado";
            lblRealizado.Size = new Size(60, 15);
            lblRealizado.TabIndex = 2;
            lblRealizado.Text = "Realizado:";
            // 
            // cmbRefeicao
            // 
            cmbRefeicao.FormattingEnabled = true;
            cmbRefeicao.Location = new Point(154, 101);
            cmbRefeicao.Name = "cmbRefeicao";
            cmbRefeicao.Size = new Size(188, 23);
            cmbRefeicao.TabIndex = 3;
            cmbRefeicao.SelectedValueChanged += cmbRefeicao_SelectedValueChanged;
            cmbRefeicao.Leave += cmbRefeicao_Leave;
            // 
            // txtDataRealizado
            // 
            txtDataRealizado.Enabled = false;
            txtDataRealizado.Location = new Point(154, 136);
            txtDataRealizado.Name = "txtDataRealizado";
            txtDataRealizado.Size = new Size(188, 23);
            txtDataRealizado.TabIndex = 4;
            // 
            // cmbRealizado
            // 
            cmbRealizado.Enabled = false;
            cmbRealizado.FormattingEnabled = true;
            cmbRealizado.Location = new Point(154, 178);
            cmbRealizado.Name = "cmbRealizado";
            cmbRealizado.Size = new Size(188, 23);
            cmbRealizado.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(366, 178);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Registrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 54);
            label1.TabIndex = 7;
            label1.Text = "Registrar";
            // 
            // FrmRegistroRefeicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 260);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(cmbRealizado);
            Controls.Add(txtDataRealizado);
            Controls.Add(cmbRefeicao);
            Controls.Add(lblRealizado);
            Controls.Add(lblDataRealizado);
            Controls.Add(lblNome);
            Name = "FrmRegistroRefeicao";
            Text = "FrmRegistroRefeicao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblDataRealizado;
        private Label lblRealizado;
        private ComboBox cmbRefeicao;
        private TextBox txtDataRealizado;
        private ComboBox cmbRealizado;
        private Button btnSalvar;
        private Label label1;
    }
}