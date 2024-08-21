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
            label1 = new Label();
            btnRegistrar = new Button();
            button2 = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 39);
            label1.Name = "label1";
            label1.Size = new Size(371, 54);
            label1.TabIndex = 0;
            label1.Text = "O que deseja fazer?";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(48, 187);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(171, 63);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Refeição";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(389, 187);
            button2.Name = "button2";
            button2.Size = new Size(171, 63);
            button2.TabIndex = 2;
            button2.Text = "Gerar Relatório (em breve)";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(525, 415);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(btnSair);
            Controls.Add(button2);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrar;
        private Button button2;
        private Button btnSair;
    }
}