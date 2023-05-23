namespace ManipNome01
{
    partial class SaidaIHM
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
            lblUltimoEspaco = new Label();
            lblSobrenome = new Label();
            lblNomeF1 = new Label();
            lblNomeF2 = new Label();
            lblNomeF3 = new Label();
            txtUltimoEspaco = new TextBox();
            txtSobrenome = new TextBox();
            txtNomeF1 = new TextBox();
            txtNomeF2 = new TextBox();
            txtNomeF3 = new TextBox();
            SuspendLayout();
            // 
            // lblUltimoEspaco
            // 
            lblUltimoEspaco.AutoSize = true;
            lblUltimoEspaco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUltimoEspaco.Location = new Point(24, 32);
            lblUltimoEspaco.Name = "lblUltimoEspaco";
            lblUltimoEspaco.Size = new Size(177, 32);
            lblUltimoEspaco.TabIndex = 0;
            lblUltimoEspaco.Text = "Último Espaço: ";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSobrenome.Location = new Point(24, 88);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(143, 32);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblNomeF1
            // 
            lblNomeF1.AutoSize = true;
            lblNomeF1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeF1.Location = new Point(24, 142);
            lblNomeF1.Name = "lblNomeF1";
            lblNomeF1.Size = new Size(194, 32);
            lblNomeF1.TabIndex = 2;
            lblNomeF1.Text = "Nome Formato1:";
            // 
            // lblNomeF2
            // 
            lblNomeF2.AutoSize = true;
            lblNomeF2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeF2.Location = new Point(24, 193);
            lblNomeF2.Name = "lblNomeF2";
            lblNomeF2.Size = new Size(194, 32);
            lblNomeF2.TabIndex = 3;
            lblNomeF2.Text = "Nome Formato2:";
            // 
            // lblNomeF3
            // 
            lblNomeF3.AutoSize = true;
            lblNomeF3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeF3.Location = new Point(24, 244);
            lblNomeF3.Name = "lblNomeF3";
            lblNomeF3.Size = new Size(194, 32);
            lblNomeF3.TabIndex = 4;
            lblNomeF3.Text = "Nome Formato3:";
            // 
            // txtUltimoEspaco
            // 
            txtUltimoEspaco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUltimoEspaco.Location = new Point(248, 32);
            txtUltimoEspaco.Name = "txtUltimoEspaco";
            txtUltimoEspaco.Size = new Size(155, 39);
            txtUltimoEspaco.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSobrenome.Location = new Point(248, 87);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(155, 39);
            txtSobrenome.TabIndex = 6;
            // 
            // txtNomeF1
            // 
            txtNomeF1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeF1.Location = new Point(248, 142);
            txtNomeF1.Name = "txtNomeF1";
            txtNomeF1.Size = new Size(494, 39);
            txtNomeF1.TabIndex = 7;
            // 
            // txtNomeF2
            // 
            txtNomeF2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeF2.Location = new Point(248, 192);
            txtNomeF2.Name = "txtNomeF2";
            txtNomeF2.Size = new Size(494, 39);
            txtNomeF2.TabIndex = 8;
            // 
            // txtNomeF3
            // 
            txtNomeF3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeF3.Location = new Point(248, 240);
            txtNomeF3.Name = "txtNomeF3";
            txtNomeF3.Size = new Size(494, 39);
            txtNomeF3.TabIndex = 9;
            // 
            // SaidaIHM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 315);
            Controls.Add(txtNomeF3);
            Controls.Add(txtNomeF2);
            Controls.Add(txtNomeF1);
            Controls.Add(txtSobrenome);
            Controls.Add(txtUltimoEspaco);
            Controls.Add(lblNomeF3);
            Controls.Add(lblNomeF2);
            Controls.Add(lblNomeF1);
            Controls.Add(lblSobrenome);
            Controls.Add(lblUltimoEspaco);
            Name = "SaidaIHM";
            Text = "ManipNome - Saída";
            Load += SaidaIHM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUltimoEspaco;
        private Label lblSobrenome;
        private Label lblNomeF1;
        private Label lblNomeF2;
        private Label lblNomeF3;
        private TextBox txtUltimoEspaco;
        private TextBox txtSobrenome;
        private TextBox txtNomeF1;
        private TextBox txtNomeF2;
        private TextBox txtNomeF3;
    }
}