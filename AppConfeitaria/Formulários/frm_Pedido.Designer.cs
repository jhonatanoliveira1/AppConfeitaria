namespace AppConfeitaria
{
    partial class frm_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pedido));
            this.pnl_Lista = new System.Windows.Forms.Panel();
            this.lbox_Pedidos = new System.Windows.Forms.ListBox();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Cod_Pedido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Vtotal_PedidoItem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Valor_Bolo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Tam_Bolo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Nm_Bolo = new System.Windows.Forms.Label();
            this.tbox_Quant_PedidoItem = new System.Windows.Forms.TextBox();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_Cod_Bolo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Cod_Cliente = new System.Windows.Forms.TextBox();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.lb_Nm_Cliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Obs_Pedido = new System.Windows.Forms.TextBox();
            this.mtbox_Dh_Pedido = new System.Windows.Forms.MaskedTextBox();
            this.ltv_PedidoItem = new System.Windows.Forms.ListView();
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_End_Cliente = new System.Windows.Forms.Label();
            this.btn_Bolo = new System.Windows.Forms.Button();
            this.lb_Bai_Cliente = new System.Windows.Forms.Label();
            this.lb_Cid_Cliente = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.pnl_Lista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Detalhe.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Lista
            // 
            this.pnl_Lista.Controls.Add(this.lbox_Pedidos);
            this.pnl_Lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lista.Location = new System.Drawing.Point(0, 80);
            this.pnl_Lista.Name = "pnl_Lista";
            this.pnl_Lista.Size = new System.Drawing.Size(216, 555);
            this.pnl_Lista.TabIndex = 10;
            // 
            // lbox_Pedidos
            // 
            this.lbox_Pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Pedidos.FormattingEnabled = true;
            this.lbox_Pedidos.ItemHeight = 20;
            this.lbox_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.lbox_Pedidos.Name = "lbox_Pedidos";
            this.lbox_Pedidos.Size = new System.Drawing.Size(216, 555);
            this.lbox_Pedidos.TabIndex = 0;
            this.lbox_Pedidos.Click += new System.EventHandler(this.lbox_Pedidos_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.Tan;
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(946, 80);
            this.pnl_Titulo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(24, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código";
            // 
            // tbox_Cod_Pedido
            // 
            this.tbox_Cod_Pedido.Enabled = false;
            this.tbox_Cod_Pedido.Location = new System.Drawing.Point(28, 31);
            this.tbox_Cod_Pedido.Name = "tbox_Cod_Pedido";
            this.tbox_Cod_Pedido.Size = new System.Drawing.Size(74, 26);
            this.tbox_Cod_Pedido.TabIndex = 4;
            this.tbox_Cod_Pedido.Tag = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.lb_Vtotal_PedidoItem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_Valor_Bolo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_Tam_Bolo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Nm_Bolo);
            this.panel1.Controls.Add(this.tbox_Quant_PedidoItem);
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 128);
            this.panel1.TabIndex = 7;
            // 
            // lb_Vtotal_PedidoItem
            // 
            this.lb_Vtotal_PedidoItem.BackColor = System.Drawing.Color.Linen;
            this.lb_Vtotal_PedidoItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Vtotal_PedidoItem.Location = new System.Drawing.Point(614, 28);
            this.lb_Vtotal_PedidoItem.Name = "lb_Vtotal_PedidoItem";
            this.lb_Vtotal_PedidoItem.Size = new System.Drawing.Size(92, 20);
            this.lb_Vtotal_PedidoItem.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSalmon;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(472, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Valor";
            // 
            // lb_Valor_Bolo
            // 
            this.lb_Valor_Bolo.BackColor = System.Drawing.Color.Linen;
            this.lb_Valor_Bolo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Valor_Bolo.Location = new System.Drawing.Point(476, 78);
            this.lb_Valor_Bolo.Name = "lb_Valor_Bolo";
            this.lb_Valor_Bolo.Size = new System.Drawing.Size(92, 20);
            this.lb_Valor_Bolo.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(148, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nome";
            // 
            // lb_Tam_Bolo
            // 
            this.lb_Tam_Bolo.BackColor = System.Drawing.Color.Linen;
            this.lb_Tam_Bolo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Tam_Bolo.Location = new System.Drawing.Point(24, 78);
            this.lb_Tam_Bolo.Name = "lb_Tam_Bolo";
            this.lb_Tam_Bolo.Size = new System.Drawing.Size(434, 20);
            this.lb_Tam_Bolo.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(472, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(614, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Valor Total";
            // 
            // lb_Nm_Bolo
            // 
            this.lb_Nm_Bolo.BackColor = System.Drawing.Color.Linen;
            this.lb_Nm_Bolo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Nm_Bolo.Location = new System.Drawing.Point(148, 28);
            this.lb_Nm_Bolo.Name = "lb_Nm_Bolo";
            this.lb_Nm_Bolo.Size = new System.Drawing.Size(310, 20);
            this.lb_Nm_Bolo.TabIndex = 54;
            // 
            // tbox_Quant_PedidoItem
            // 
            this.tbox_Quant_PedidoItem.Enabled = false;
            this.tbox_Quant_PedidoItem.Location = new System.Drawing.Point(476, 25);
            this.tbox_Quant_PedidoItem.Name = "tbox_Quant_PedidoItem";
            this.tbox_Quant_PedidoItem.Size = new System.Drawing.Size(91, 26);
            this.tbox_Quant_PedidoItem.TabIndex = 61;
            this.tbox_Quant_PedidoItem.Tag = "1";
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Down.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Down.Image = ((System.Drawing.Image)(resources.GetObject("btn_Down.Image")));
            this.btn_Down.Location = new System.Drawing.Point(666, 261);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(33, 37);
            this.btn_Down.TabIndex = 57;
            this.btn_Down.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Up.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Up.Image = ((System.Drawing.Image)(resources.GetObject("btn_Up.Image")));
            this.btn_Up.Location = new System.Drawing.Point(626, 261);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(33, 37);
            this.btn_Up.TabIndex = 56;
            this.btn_Up.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Up.UseVisualStyleBackColor = false;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSalmon;
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(22, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Bolo";
            // 
            // tbox_Cod_Bolo
            // 
            this.tbox_Cod_Bolo.Location = new System.Drawing.Point(23, 221);
            this.tbox_Cod_Bolo.Name = "tbox_Cod_Bolo";
            this.tbox_Cod_Bolo.Size = new System.Drawing.Size(74, 26);
            this.tbox_Cod_Bolo.TabIndex = 55;
            this.tbox_Cod_Bolo.Leave += new System.EventHandler(this.tbox_Cod_Bolo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(22, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cliente";
            // 
            // tbox_Cod_Cliente
            // 
            this.tbox_Cod_Cliente.Location = new System.Drawing.Point(28, 105);
            this.tbox_Cod_Cliente.Name = "tbox_Cod_Cliente";
            this.tbox_Cod_Cliente.Size = new System.Drawing.Size(74, 26);
            this.tbox_Cod_Cliente.TabIndex = 16;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cliente.Image")));
            this.btn_Cliente.Location = new System.Drawing.Point(106, 102);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(33, 37);
            this.btn_Cliente.TabIndex = 17;
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // lb_Nm_Cliente
            // 
            this.lb_Nm_Cliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.lb_Nm_Cliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Nm_Cliente.Location = new System.Drawing.Point(144, 108);
            this.lb_Nm_Cliente.Name = "lb_Nm_Cliente";
            this.lb_Nm_Cliente.Size = new System.Drawing.Size(278, 20);
            this.lb_Nm_Cliente.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(120, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Data e Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(286, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Observação";
            // 
            // tbox_Obs_Pedido
            // 
            this.tbox_Obs_Pedido.Location = new System.Drawing.Point(290, 29);
            this.tbox_Obs_Pedido.Multiline = true;
            this.tbox_Obs_Pedido.Name = "tbox_Obs_Pedido";
            this.tbox_Obs_Pedido.Size = new System.Drawing.Size(420, 47);
            this.tbox_Obs_Pedido.TabIndex = 27;
            // 
            // mtbox_Dh_Pedido
            // 
            this.mtbox_Dh_Pedido.Location = new System.Drawing.Point(124, 31);
            this.mtbox_Dh_Pedido.Mask = "00/00/0000 00:00";
            this.mtbox_Dh_Pedido.Name = "mtbox_Dh_Pedido";
            this.mtbox_Dh_Pedido.Size = new System.Drawing.Size(145, 26);
            this.mtbox_Dh_Pedido.TabIndex = 28;
            this.mtbox_Dh_Pedido.Tag = "1";
            this.mtbox_Dh_Pedido.ValidatingType = typeof(System.DateTime);
            // 
            // ltv_PedidoItem
            // 
            this.ltv_PedidoItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ltv_PedidoItem.FullRowSelect = true;
            this.ltv_PedidoItem.GridLines = true;
            this.ltv_PedidoItem.HideSelection = false;
            this.ltv_PedidoItem.Location = new System.Drawing.Point(0, 320);
            this.ltv_PedidoItem.Name = "ltv_PedidoItem";
            this.ltv_PedidoItem.Size = new System.Drawing.Size(730, 235);
            this.ltv_PedidoItem.TabIndex = 29;
            this.ltv_PedidoItem.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.label15);
            this.pnl_Detalhe.Controls.Add(this.label14);
            this.pnl_Detalhe.Controls.Add(this.label13);
            this.pnl_Detalhe.Controls.Add(this.label12);
            this.pnl_Detalhe.Controls.Add(this.lb_End_Cliente);
            this.pnl_Detalhe.Controls.Add(this.btn_Bolo);
            this.pnl_Detalhe.Controls.Add(this.label11);
            this.pnl_Detalhe.Controls.Add(this.lb_Bai_Cliente);
            this.pnl_Detalhe.Controls.Add(this.btn_Down);
            this.pnl_Detalhe.Controls.Add(this.lb_Cid_Cliente);
            this.pnl_Detalhe.Controls.Add(this.btn_Up);
            this.pnl_Detalhe.Controls.Add(this.ltv_PedidoItem);
            this.pnl_Detalhe.Controls.Add(this.mtbox_Dh_Pedido);
            this.pnl_Detalhe.Controls.Add(this.tbox_Obs_Pedido);
            this.pnl_Detalhe.Controls.Add(this.label10);
            this.pnl_Detalhe.Controls.Add(this.label8);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Bolo);
            this.pnl_Detalhe.Controls.Add(this.lb_Nm_Cliente);
            this.pnl_Detalhe.Controls.Add(this.btn_Cliente);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Cliente);
            this.pnl_Detalhe.Controls.Add(this.label9);
            this.pnl_Detalhe.Controls.Add(this.panel1);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Pedido);
            this.pnl_Detalhe.Controls.Add(this.label5);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(216, 80);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(730, 555);
            this.pnl_Detalhe.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label15.Location = new System.Drawing.Point(142, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "Nome";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label14.Location = new System.Drawing.Point(142, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Endereço";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label13.Location = new System.Drawing.Point(424, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(424, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cidade";
            // 
            // lb_End_Cliente
            // 
            this.lb_End_Cliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.lb_End_Cliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_End_Cliente.Location = new System.Drawing.Point(144, 158);
            this.lb_End_Cliente.Name = "lb_End_Cliente";
            this.lb_End_Cliente.Size = new System.Drawing.Size(278, 20);
            this.lb_End_Cliente.TabIndex = 48;
            // 
            // btn_Bolo
            // 
            this.btn_Bolo.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Bolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bolo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Bolo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bolo.Image")));
            this.btn_Bolo.Location = new System.Drawing.Point(108, 218);
            this.btn_Bolo.Name = "btn_Bolo";
            this.btn_Bolo.Size = new System.Drawing.Size(33, 37);
            this.btn_Bolo.TabIndex = 62;
            this.btn_Bolo.UseVisualStyleBackColor = false;
            this.btn_Bolo.Click += new System.EventHandler(this.btn_Bolo_Click);
            // 
            // lb_Bai_Cliente
            // 
            this.lb_Bai_Cliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.lb_Bai_Cliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Bai_Cliente.Location = new System.Drawing.Point(430, 158);
            this.lb_Bai_Cliente.Name = "lb_Bai_Cliente";
            this.lb_Bai_Cliente.Size = new System.Drawing.Size(278, 20);
            this.lb_Bai_Cliente.TabIndex = 47;
            // 
            // lb_Cid_Cliente
            // 
            this.lb_Cid_Cliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.lb_Cid_Cliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Cid_Cliente.Location = new System.Drawing.Point(430, 108);
            this.lb_Cid_Cliente.Name = "lb_Cid_Cliente";
            this.lb_Cid_Cliente.Size = new System.Drawing.Size(278, 20);
            this.lb_Cid_Cliente.TabIndex = 46;
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Novo.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Novo.Location = new System.Drawing.Point(8, 14);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(93, 35);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Alterar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Alterar.Location = new System.Drawing.Point(106, 14);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(93, 35);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Excluir.Location = new System.Drawing.Point(206, 14);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(93, 35);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Confirmar.Location = new System.Drawing.Point(703, 14);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(111, 35);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Sienna;
            this.btn_Cancelar.Location = new System.Drawing.Point(822, 14);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 35);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 635);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(946, 74);
            this.pnl_Botoes.TabIndex = 9;
            // 
            // frm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 709);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Lista);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.pnl_Lista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Lista;
        private System.Windows.Forms.ListBox lbox_Pedidos;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Cod_Pedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_Cod_Cliente;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Label lb_Nm_Cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Obs_Pedido;
        private System.Windows.Forms.MaskedTextBox mtbox_Dh_Pedido;
        private System.Windows.Forms.ListView ltv_PedidoItem;
        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Cid_Cliente;
        private System.Windows.Forms.Label lb_Bai_Cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_End_Cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Nm_Bolo;
        private System.Windows.Forms.TextBox tbox_Cod_Bolo;
        private System.Windows.Forms.TextBox tbox_Quant_PedidoItem;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Bolo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Tam_Bolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Valor_Bolo;
        private System.Windows.Forms.Label lb_Vtotal_PedidoItem;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel pnl_Botoes;
    }
}