namespace diario_de_refeicoes
{
    partial class FrmPrincipal
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
            btnRegistrar = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            registrarRefeiçãoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(90, 471);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(171, 63);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Refeição";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Visible = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(267, 471);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(171, 63);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Gerar Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Visible = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(444, 511);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Visible = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._77e24fcf_afd7_4a39_913d_74d564a5b05f;
            pictureBox1.Location = new Point(-1, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarRefeiçãoToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(517, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarRefeiçãoToolStripMenuItem
            // 
            registrarRefeiçãoToolStripMenuItem.Name = "registrarRefeiçãoToolStripMenuItem";
            registrarRefeiçãoToolStripMenuItem.Size = new Size(113, 20);
            registrarRefeiçãoToolStripMenuItem.Text = "Registrar Refeição";
            registrarRefeiçãoToolStripMenuItem.Click += registrarRefeiçãoToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            relatóriosToolStripMenuItem.Click += relatóriosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 542);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnRegistrar);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private Button btnRelatorio;
        private Button btnSair;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarRefeiçãoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}