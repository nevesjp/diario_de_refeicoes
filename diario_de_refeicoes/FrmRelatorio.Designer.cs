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
            ((System.ComponentModel.ISupportInitialize)grdResult).BeginInit();
            SuspendLayout();
            // 
            // mskDataInicial
            // 
            mskDataInicial.Location = new Point(26, 23);
            mskDataInicial.Mask = "00/00/0000";
            mskDataInicial.Name = "mskDataInicial";
            mskDataInicial.Size = new Size(100, 23);
            mskDataInicial.TabIndex = 1;
            mskDataInicial.ValidatingType = typeof(DateTime);
            // 
            // mskDataFinal
            // 
            mskDataFinal.Location = new Point(141, 23);
            mskDataFinal.Mask = "00/00/0000";
            mskDataFinal.Name = "mskDataFinal";
            mskDataFinal.Size = new Size(100, 23);
            mskDataFinal.TabIndex = 2;
            mskDataFinal.ValidatingType = typeof(DateTime);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(640, 54);
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
            grdResult.Location = new Point(12, 54);
            grdResult.Name = "grdResult";
            grdResult.ReadOnly = true;
            grdResult.RowTemplate.Height = 25;
            grdResult.Size = new Size(622, 359);
            grdResult.TabIndex = 5;
            // 
            // lblPontosSomados
            // 
            lblPontosSomados.AutoSize = true;
            lblPontosSomados.Location = new Point(247, 28);
            lblPontosSomados.Name = "lblPontosSomados";
            lblPontosSomados.Size = new Size(0, 15);
            lblPontosSomados.TabIndex = 6;
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 425);
            Controls.Add(lblPontosSomados);
            Controls.Add(grdResult);
            Controls.Add(btnFiltrar);
            Controls.Add(mskDataFinal);
            Controls.Add(mskDataInicial);
            Name = "FrmRelatorio";
            Text = "FrmRelatorio";
            ((System.ComponentModel.ISupportInitialize)grdResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskDataInicial;
        private MaskedTextBox mskDataFinal;
        private Button btnFiltrar;
        private DataGridView grdResult;
        private Label lblPontosSomados;
    }
}