namespace AppConfeitaria
{
    partial class frm_Login
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
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Pass_Usuario = new System.Windows.Forms.TextBox();
            this.tbox_Log_Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Detalhe.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Detalhe.Controls.Add(this.tbox_Pass_Usuario);
            this.pnl_Detalhe.Controls.Add(this.tbox_Log_Usuario);
            this.pnl_Detalhe.Controls.Add(this.label7);
            this.pnl_Detalhe.Controls.Add(this.label6);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(0, 80);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(199, 145);
            this.pnl_Detalhe.TabIndex = 13;
            this.pnl_Detalhe.Click += new System.EventHandler(this.frm_Login_Activated);
            // 
            // tbox_Pass_Usuario
            // 
            this.tbox_Pass_Usuario.Location = new System.Drawing.Point(26, 99);
            this.tbox_Pass_Usuario.Name = "tbox_Pass_Usuario";
            this.tbox_Pass_Usuario.PasswordChar = '*';
            this.tbox_Pass_Usuario.Size = new System.Drawing.Size(151, 26);
            this.tbox_Pass_Usuario.TabIndex = 6;
            // 
            // tbox_Log_Usuario
            // 
            this.tbox_Log_Usuario.Location = new System.Drawing.Point(26, 37);
            this.tbox_Log_Usuario.Name = "tbox_Log_Usuario";
            this.tbox_Log_Usuario.Size = new System.Drawing.Size(151, 26);
            this.tbox_Log_Usuario.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PapayaWhip;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PapayaWhip;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(23, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Login";
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.Color.Tan;
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 225);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(199, 80);
            this.pnl_Botoes.TabIndex = 12;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Confirmar.Location = new System.Drawing.Point(45, 6);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(106, 46);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.Tan;
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(199, 80);
            this.pnl_Titulo.TabIndex = 11;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(199, 305);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.TextBox tbox_Pass_Usuario;
        private System.Windows.Forms.TextBox tbox_Log_Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}