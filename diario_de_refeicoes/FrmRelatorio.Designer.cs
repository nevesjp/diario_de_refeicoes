namespace diario_de_refeicoes
{
    partial class FrmRelatorio
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
            mskDataInicial = new MaskedTextBox();
            mskDataFinal = new MaskedTextBox();
            btnFiltrar = new Button();
            grdResult = new DataGridView();
            lblPontosSomados = new Label();
            numDias = new NumericUpDown();
            btnMenosDataInicial = new Button();
            btnMaisDataInicial = new Button();
            btnMaisDataFinal = new Button();
            btnMenosDataFinal = new Button();
            lblPercentualAtingido = new Label();
            prgBarTeste = new ProgressBar();
            btnLast7Days = new Button();
            btnAvancar = new Button();
            btnRetroceder = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grdResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mskDataInicial
            // 
            mskDataInicial.Location = new Point(12, 77);
            mskDataInicial.Mask = "00/00/0000";
            mskDataInicial.Name = "mskDataInicial";
            mskDataInicial.Size = new Size(100, 23);
            mskDataInicial.TabIndex = 1;
            mskDataInicial.ValidatingType = typeof(DateTime);
            // 
            // mskDataFinal
            // 
            mskDataFinal.Location = new Point(184, 77);
            mskDataFinal.Mask = "00/00/0000";
            mskDataFinal.Name = "mskDataFinal";
            mskDataFinal.Size = new Size(100, 23);
            mskDataFinal.TabIndex = 2;
            mskDataFinal.ValidatingType = typeof(DateTime);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(452, 605);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // grdResult
            // 
            grdResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdResult.Location = new Point(1, 221);
            grdResult.Name = "grdResult";
            grdResult.ReadOnly = true;
            grdResult.RowTemplate.Height = 25;
            grdResult.Size = new Size(538, 307);
            grdResult.TabIndex = 5;
            // 
            // lblPontosSomados
            // 
            lblPontosSomados.AutoSize = true;
            lblPontosSomados.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontosSomados.Location = new Point(12, 9);
            lblPontosSomados.Name = "lblPontosSomados";
            lblPontosSomados.Size = new Size(0, 19);
            lblPontosSomados.TabIndex = 6;
            // 
            // numDias
            // 
            numDias.Location = new Point(12, 48);
            numDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDias.Name = "numDias";
            numDias.Size = new Size(57, 23);
            numDias.TabIndex = 8;
            numDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnMenosDataInicial
            // 
            btnMenosDataInicial.Location = new Point(118, 77);
            btnMenosDataInicial.Name = "btnMenosDataInicial";
            btnMenosDataInicial.Size = new Size(27, 23);
            btnMenosDataInicial.TabIndex = 9;
            btnMenosDataInicial.Text = "-";
            btnMenosDataInicial.UseVisualStyleBackColor = true;
            btnMenosDataInicial.Click += btnMenosDataInicial_Click;
            // 
            // btnMaisDataInicial
            // 
            btnMaisDataInicial.Location = new Point(118, 52);
            btnMaisDataInicial.Name = "btnMaisDataInicial";
            btnMaisDataInicial.Size = new Size(27, 23);
            btnMaisDataInicial.TabIndex = 10;
            btnMaisDataInicial.Text = "+";
            btnMaisDataInicial.UseVisualStyleBackColor = true;
            btnMaisDataInicial.Click += btnMaisDataInicial_Click;
            // 
            // btnMaisDataFinal
            // 
            btnMaisDataFinal.Location = new Point(151, 52);
            btnMaisDataFinal.Name = "btnMaisDataFinal";
            btnMaisDataFinal.Size = new Size(27, 23);
            btnMaisDataFinal.TabIndex = 12;
            btnMaisDataFinal.Text = "+";
            btnMaisDataFinal.UseVisualStyleBackColor = true;
            btnMaisDataFinal.Click += btnMaisDataFinal_Click;
            // 
            // btnMenosDataFinal
            // 
            btnMenosDataFinal.Location = new Point(151, 77);
            btnMenosDataFinal.Name = "btnMenosDataFinal";
            btnMenosDataFinal.Size = new Size(27, 23);
            btnMenosDataFinal.TabIndex = 11;
            btnMenosDataFinal.Text = "-";
            btnMenosDataFinal.UseVisualStyleBackColor = true;
            btnMenosDataFinal.Click += btnMenosDataFinal_Click;
            // 
            // lblPercentualAtingido
            // 
            lblPercentualAtingido.AutoSize = true;
            lblPercentualAtingido.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualAtingido.Location = new Point(184, 46);
            lblPercentualAtingido.Name = "lblPercentualAtingido";
            lblPercentualAtingido.Size = new Size(0, 19);
            lblPercentualAtingido.TabIndex = 13;
            // 
            // prgBarTeste
            // 
            prgBarTeste.Location = new Point(1, 634);
            prgBarTeste.Name = "prgBarTeste";
            prgBarTeste.Size = new Size(538, 23);
            prgBarTeste.TabIndex = 14;
            // 
            // btnLast7Days
            // 
            btnLast7Days.Location = new Point(290, 77);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(75, 23);
            btnLast7Days.TabIndex = 15;
            btnLast7Days.Text = "Last 7 days";
            btnLast7Days.UseVisualStyleBackColor = true;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // btnAvancar
            // 
            btnAvancar.Location = new Point(452, 76);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(75, 23);
            btnAvancar.TabIndex = 16;
            btnAvancar.Text = ">>";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(371, 77);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(75, 23);
            btnRetroceder.TabIndex = 17;
            btnRetroceder.Text = "<<";
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._10fde140_6544_4149_b584_2f14b0b90df1;
            pictureBox1.Location = new Point(1, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 657);
            Controls.Add(btnRetroceder);
            Controls.Add(btnAvancar);
            Controls.Add(btnLast7Days);
            Controls.Add(prgBarTeste);
            Controls.Add(lblPercentualAtingido);
            Controls.Add(btnMaisDataFinal);
            Controls.Add(btnMenosDataFinal);
            Controls.Add(btnMaisDataInicial);
            Controls.Add(btnMenosDataInicial);
            Controls.Add(numDias);
            Controls.Add(lblPontosSomados);
            Controls.Add(grdResult);
            Controls.Add(btnFiltrar);
            Controls.Add(mskDataFinal);
            Controls.Add(mskDataInicial);
            Controls.Add(pictureBox1);
            Name = "FrmRelatorio";
            Text = "Relatório";
            ((System.ComponentModel.ISupportInitialize)grdResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskDataInicial;
        private MaskedTextBox mskDataFinal;
        private Button btnFiltrar;
        private DataGridView grdResult;
        private Label lblPontosSomados;
        private NumericUpDown numDias;
        private Button btnMenosDataInicial;
        private Button btnMaisDataInicial;
        private Button btnMaisDataFinal;
        private Button btnMenosDataFinal;
        private Label lblPercentualAtingido;
        private ProgressBar prgBarTeste;
        private Button btnLast7Days;
        private Button btnAvancar;
        private Button btnRetroceder;
        private PictureBox pictureBox1;
    }
}