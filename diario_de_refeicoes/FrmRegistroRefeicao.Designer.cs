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
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(60, 90);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Refeição:";
            // 
            // lblDataRealizado
            // 
            lblDataRealizado.AutoSize = true;
            lblDataRealizado.Location = new Point(28, 125);
            lblDataRealizado.Name = "lblDataRealizado";
            lblDataRealizado.Size = new Size(87, 15);
            lblDataRealizado.TabIndex = 1;
            lblDataRealizado.Text = "Data Realizado:";
            // 
            // lblRealizado
            // 
            lblRealizado.AutoSize = true;
            lblRealizado.Location = new Point(55, 159);
            lblRealizado.Name = "lblRealizado";
            lblRealizado.Size = new Size(60, 15);
            lblRealizado.TabIndex = 2;
            lblRealizado.Text = "Realizado:";
            // 
            // cmbRefeicao
            // 
            cmbRefeicao.FormattingEnabled = true;
            cmbRefeicao.Location = new Point(131, 82);
            cmbRefeicao.Name = "cmbRefeicao";
            cmbRefeicao.Size = new Size(188, 23);
            cmbRefeicao.TabIndex = 3;
            // 
            // FrmRegistroRefeicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}