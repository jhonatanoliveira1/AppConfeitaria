namespace AppConfeitaria
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tim_Agendamento = new System.Windows.Forms.Timer(this.components);
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recheioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coberturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.tim_Principal = new System.Windows.Forms.Timer(this.components);
            this.sstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabel_DataSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabel_HoraSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstrip_Principal.SuspendLayout();
            this.sstrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.boloToolStripMenuItem,
            this.toolStripMenuItem1,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // boloToolStripMenuItem
            // 
            this.boloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saborToolStripMenuItem,
            this.recheioToolStripMenuItem,
            this.coberturaToolStripMenuItem});
            this.boloToolStripMenuItem.Name = "boloToolStripMenuItem";
            this.boloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.boloToolStripMenuItem.Text = "Bolo";
            this.boloToolStripMenuItem.Click += new System.EventHandler(this.boloToolStripMenuItem_Click);
            // 
            // saborToolStripMenuItem
            // 
            this.saborToolStripMenuItem.Name = "saborToolStripMenuItem";
            this.saborToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.saborToolStripMenuItem.Text = "Sabor";
            this.saborToolStripMenuItem.Click += new System.EventHandler(this.saborToolStripMenuItem_Click);
            // 
            // recheioToolStripMenuItem
            // 
            this.recheioToolStripMenuItem.Name = "recheioToolStripMenuItem";
            this.recheioToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.recheioToolStripMenuItem.Text = "Recheio";
            this.recheioToolStripMenuItem.Click += new System.EventHandler(this.recheioToolStripMenuItem_Click);
            // 
            // coberturaToolStripMenuItem
            // 
            this.coberturaToolStripMenuItem.Name = "coberturaToolStripMenuItem";
            this.coberturaToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.coberturaToolStripMenuItem.Text = "Cobertura";
            this.coberturaToolStripMenuItem.Click += new System.EventHandler(this.coberturaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.agendamentoToolStripMenuItem.Text = "Pedidos";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.agendaToolStripMenuItem.Text = "Pedido";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // mstrip_Principal
            // 
            this.mstrip_Principal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mstrip_Principal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mstrip_Principal.Name = "mstrip_Principal";
            this.mstrip_Principal.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mstrip_Principal.Size = new System.Drawing.Size(1168, 35);
            this.mstrip_Principal.TabIndex = 0;
            this.mstrip_Principal.Text = "menuStrip1";
            // 
            // tim_Principal
            // 
            this.tim_Principal.Enabled = true;
            this.tim_Principal.Tick += new System.EventHandler(this.tim_Principal_Tick);
            // 
            // sstrip_Principal
            // 
            this.sstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslabel_DataSys,
            this.toolStripStatusLabel2,
            this.tsslabel_HoraSys,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.sstrip_Principal.Location = new System.Drawing.Point(0, 643);
            this.sstrip_Principal.Name = "sstrip_Principal";
            this.sstrip_Principal.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.sstrip_Principal.Size = new System.Drawing.Size(1168, 32);
            this.sstrip_Principal.TabIndex = 2;
            this.sstrip_Principal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 25);
            this.toolStripStatusLabel1.Text = "Data: ";
            // 
            // tsslabel_DataSys
            // 
            this.tsslabel_DataSys.ActiveLinkColor = System.Drawing.Color.Red;
            this.tsslabel_DataSys.AutoSize = false;
            this.tsslabel_DataSys.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tsslabel_DataSys.Name = "tsslabel_DataSys";
            this.tsslabel_DataSys.Size = new System.Drawing.Size(90, 25);
            this.tsslabel_DataSys.Text = "99/99/9999";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel2.Text = "Hora: ";
            // 
            // tsslabel_HoraSys
            // 
            this.tsslabel_HoraSys.AutoSize = false;
            this.tsslabel_HoraSys.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tsslabel_HoraSys.Name = "tsslabel_HoraSys";
            this.tsslabel_HoraSys.Size = new System.Drawing.Size(80, 25);
            this.tsslabel_HoraSys.Text = "99:99:99";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 25);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(303, 25);
            this.toolStripStatusLabel4.Text = "AppConfeitaria - Sistema de Pedidos";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 25);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 675);
            this.Controls.Add(this.sstrip_Principal);
            this.Controls.Add(this.mstrip_Principal);
            this.MainMenuStrip = this.mstrip_Principal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstrip_Principal.ResumeLayout(false);
            this.mstrip_Principal.PerformLayout();
            this.sstrip_Principal.ResumeLayout(false);
            this.sstrip_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tim_Agendamento;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recheioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coberturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mstrip_Principal;
        private System.Windows.Forms.Timer tim_Principal;
        private System.Windows.Forms.StatusStrip sstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabel_DataSys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslabel_HoraSys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
    }
}