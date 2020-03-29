namespace AppConfeitaria
{
    partial class frm_Sabor
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
            this.tbox_Desc_Sabor = new System.Windows.Forms.TextBox();
            this.tbox_Tit_Sabor = new System.Windows.Forms.TextBox();
            this.tbox_Cod_Sabor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Lista = new System.Windows.Forms.Panel();
            this.lbox_Sabores = new System.Windows.Forms.ListBox();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Detalhe.SuspendLayout();
            this.pnl_Lista.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.tbox_Desc_Sabor);
            this.pnl_Detalhe.Controls.Add(this.tbox_Tit_Sabor);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Sabor);
            this.pnl_Detalhe.Controls.Add(this.label7);
            this.pnl_Detalhe.Controls.Add(this.label6);
            this.pnl_Detalhe.Controls.Add(this.label5);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(216, 80);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(360, 260);
            this.pnl_Detalhe.TabIndex = 11;
            // 
            // tbox_Desc_Sabor
            // 
            this.tbox_Desc_Sabor.Location = new System.Drawing.Point(24, 111);
            this.tbox_Desc_Sabor.Multiline = true;
            this.tbox_Desc_Sabor.Name = "tbox_Desc_Sabor";
            this.tbox_Desc_Sabor.Size = new System.Drawing.Size(308, 113);
            this.tbox_Desc_Sabor.TabIndex = 6;
            // 
            // tbox_Tit_Sabor
            // 
            this.tbox_Tit_Sabor.Location = new System.Drawing.Point(106, 43);
            this.tbox_Tit_Sabor.Name = "tbox_Tit_Sabor";
            this.tbox_Tit_Sabor.Size = new System.Drawing.Size(228, 26);
            this.tbox_Tit_Sabor.TabIndex = 5;
            // 
            // tbox_Cod_Sabor
            // 
            this.tbox_Cod_Sabor.Enabled = false;
            this.tbox_Cod_Sabor.Location = new System.Drawing.Point(24, 43);
            this.tbox_Cod_Sabor.Name = "tbox_Cod_Sabor";
            this.tbox_Cod_Sabor.Size = new System.Drawing.Size(76, 26);
            this.tbox_Cod_Sabor.TabIndex = 4;
            this.tbox_Cod_Sabor.Tag = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(21, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(104, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código";
            // 
            // pnl_Lista
            // 
            this.pnl_Lista.Controls.Add(this.lbox_Sabores);
            this.pnl_Lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lista.Location = new System.Drawing.Point(0, 80);
            this.pnl_Lista.Name = "pnl_Lista";
            this.pnl_Lista.Size = new System.Drawing.Size(216, 260);
            this.pnl_Lista.TabIndex = 10;
            // 
            // lbox_Sabores
            // 
            this.lbox_Sabores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Sabores.FormattingEnabled = true;
            this.lbox_Sabores.ItemHeight = 20;
            this.lbox_Sabores.Location = new System.Drawing.Point(0, 0);
            this.lbox_Sabores.Name = "lbox_Sabores";
            this.lbox_Sabores.Size = new System.Drawing.Size(216, 260);
            this.lbox_Sabores.TabIndex = 0;
            this.lbox_Sabores.Click += new System.EventHandler(this.lbox_Sabors_Click);
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.Color.Tan;
            this.pnl_Botoes.Controls.Add(this.btn_Cancelar);
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Controls.Add(this.btn_Excluir);
            this.pnl_Botoes.Controls.Add(this.btn_Alterar);
            this.pnl_Botoes.Controls.Add(this.btn_Novo);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 340);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(576, 62);
            this.pnl_Botoes.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Cancelar.Location = new System.Drawing.Point(448, 14);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 35);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Confirmar.Location = new System.Drawing.Point(330, 14);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(111, 35);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Excluir.Location = new System.Drawing.Point(206, 14);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(93, 35);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Alterar.Location = new System.Drawing.Point(106, 14);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(93, 35);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Novo.Location = new System.Drawing.Point(8, 14);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(93, 35);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.Tan;
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(576, 80);
            this.pnl_Titulo.TabIndex = 8;
            // 
            // frm_Sabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Lista);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Sabor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabor";
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.pnl_Lista.ResumeLayout(false);
            this.pnl_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.TextBox tbox_Desc_Sabor;
        private System.Windows.Forms.TextBox tbox_Tit_Sabor;
        private System.Windows.Forms.TextBox tbox_Cod_Sabor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Lista;
        private System.Windows.Forms.ListBox lbox_Sabores;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Titulo;
    }
}