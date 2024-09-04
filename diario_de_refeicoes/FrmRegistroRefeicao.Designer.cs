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
            cmbRealizado = new ComboBox();
            btnSalvar = new Button();
            dtTimeRealizado = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.MintCream;
            lblNome.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlText;
            lblNome.Location = new Point(205, 194);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 14);
            lblNome.TabIndex = 0;
            lblNome.Text = "Refeição:";
            // 
            // lblDataRealizado
            // 
            lblDataRealizado.AutoSize = true;
            lblDataRealizado.BackColor = Color.MintCream;
            lblDataRealizado.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataRealizado.Location = new Point(205, 250);
            lblDataRealizado.Name = "lblDataRealizado";
            lblDataRealizado.Size = new Size(89, 14);
            lblDataRealizado.TabIndex = 1;
            lblDataRealizado.Text = "Data Realizado:";
            // 
            // lblRealizado
            // 
            lblRealizado.AutoSize = true;
            lblRealizado.BackColor = Color.MintCream;
            lblRealizado.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRealizado.Location = new Point(205, 308);
            lblRealizado.Name = "lblRealizado";
            lblRealizado.Size = new Size(60, 14);
            lblRealizado.TabIndex = 2;
            lblRealizado.Text = "Realizado:";
            // 
            // cmbRefeicao
            // 
            cmbRefeicao.FormattingEnabled = true;
            cmbRefeicao.Location = new Point(205, 212);
            cmbRefeicao.Name = "cmbRefeicao";
            cmbRefeicao.Size = new Size(202, 23);
            cmbRefeicao.TabIndex = 3;
            cmbRefeicao.SelectedValueChanged += cmbRefeicao_SelectedValueChanged;
            cmbRefeicao.Leave += cmbRefeicao_Leave;
            // 
            // cmbRealizado
            // 
            cmbRealizado.Enabled = false;
            cmbRealizado.FormattingEnabled = true;
            cmbRealizado.Location = new Point(205, 326);
            cmbRealizado.Name = "cmbRealizado";
            cmbRealizado.Size = new Size(202, 23);
            cmbRealizado.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(332, 441);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Registrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtTimeRealizado
            // 
            dtTimeRealizado.Enabled = false;
            dtTimeRealizado.Location = new Point(205, 268);
            dtTimeRealizado.Name = "dtTimeRealizado";
            dtTimeRealizado.Size = new Size(202, 23);
            dtTimeRealizado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._47392b33_9472_4b4e_a463_83b9e00f778a;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 614);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmRegistroRefeicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 614);
            Controls.Add(dtTimeRealizado);
            Controls.Add(btnSalvar);
            Controls.Add(cmbRealizado);
            Controls.Add(cmbRefeicao);
            Controls.Add(lblRealizado);
            Controls.Add(lblDataRealizado);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Name = "FrmRegistroRefeicao";
            Text = "Registrar Refeição";
            Load += FrmRegistroRefeicao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblDataRealizado;
        private Label lblRealizado;
        private ComboBox cmbRefeicao;
        private ComboBox cmbRealizado;
        private Button btnSalvar;
        private DateTimePicker dtTimeRealizado;
        private PictureBox pictureBox1;
    }
}