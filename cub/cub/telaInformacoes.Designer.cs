namespace cub
{
    partial class telaInformacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInformacoes));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPagamentos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaOuReforco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagarParcela = new System.Windows.Forms.Button();
            this.btnPagarReforco = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPagarOutroValor = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorParcelas = new System.Windows.Forms.Label();
            this.lblSaldoDevedor = new System.Windows.Forms.Label();
            this.lblValorCubCompra = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorReforco = new System.Windows.Forms.Label();
            this.txtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCancelarPagamento = new System.Windows.Forms.Button();
            this.btnOkParcela = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnOkReforco = new System.Windows.Forms.Button();
            this.btnOkOutroValor = new System.Windows.Forms.Button();
            this.btnOkQuitar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReajsute = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Valor das parcelas: R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor dos reforços: R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Valor total: R$";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1133, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 48);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descrição: ";
            // 
            // tblPagamentos
            // 
            this.tblPagamentos.AllowUserToAddRows = false;
            this.tblPagamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.Data,
            this.parcelaOuReforco,
            this.valor,
            this.cub,
            this.reajuste});
            this.tblPagamentos.Location = new System.Drawing.Point(324, 453);
            this.tblPagamentos.Name = "tblPagamentos";
            this.tblPagamentos.ReadOnly = true;
            this.tblPagamentos.Size = new System.Drawing.Size(529, 169);
            this.tblPagamentos.TabIndex = 41;
            // 
            // numero
            // 
            this.numero.HeaderText = "ID";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            this.numero.Width = 30;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 80;
            // 
            // parcelaOuReforco
            // 
            this.parcelaOuReforco.HeaderText = "Tipo";
            this.parcelaOuReforco.Name = "parcelaOuReforco";
            this.parcelaOuReforco.ReadOnly = true;
            this.parcelaOuReforco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cub
            // 
            this.cub.HeaderText = "Valor do cub";
            this.cub.Name = "cub";
            this.cub.ReadOnly = true;
            this.cub.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // reajuste
            // 
            this.reajuste.HeaderText = "Reajuste (%)";
            this.reajuste.Name = "reajuste";
            this.reajuste.ReadOnly = true;
            this.reajuste.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reajuste.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnPagarParcela
            // 
            this.btnPagarParcela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPagarParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarParcela.Location = new System.Drawing.Point(142, 638);
            this.btnPagarParcela.Name = "btnPagarParcela";
            this.btnPagarParcela.Size = new System.Drawing.Size(158, 48);
            this.btnPagarParcela.TabIndex = 42;
            this.btnPagarParcela.Text = "Pagar parcela";
            this.btnPagarParcela.UseVisualStyleBackColor = false;
            // 
            // btnPagarReforco
            // 
            this.btnPagarReforco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPagarReforco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarReforco.Location = new System.Drawing.Point(385, 638);
            this.btnPagarReforco.Name = "btnPagarReforco";
            this.btnPagarReforco.Size = new System.Drawing.Size(158, 48);
            this.btnPagarReforco.TabIndex = 43;
            this.btnPagarReforco.Text = "Pagar reforço";
            this.btnPagarReforco.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Pagamentos";
            // 
            // btnPagarOutroValor
            // 
            this.btnPagarOutroValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPagarOutroValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarOutroValor.Location = new System.Drawing.Point(628, 638);
            this.btnPagarOutroValor.Name = "btnPagarOutroValor";
            this.btnPagarOutroValor.Size = new System.Drawing.Size(158, 48);
            this.btnPagarOutroValor.TabIndex = 45;
            this.btnPagarOutroValor.Text = "Pagar outro valor";
            this.btnPagarOutroValor.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(871, 638);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(158, 48);
            this.btnQuitar.TabIndex = 46;
            this.btnQuitar.Text = "Quitar ";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(291, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(176, 23);
            this.lblDescricao.TabIndex = 47;
            this.lblDescricao.Text = "Descrição_apartamento";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(291, 125);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(90, 23);
            this.lblDataCompra.TabIndex = 48;
            this.lblDataCompra.Text = "13/10/2002";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Valor do Cub na compra: R$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 22);
            this.label11.TabIndex = 50;
            this.label11.Text = "Valor pago: R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(568, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 22);
            this.label12.TabIndex = 51;
            this.label12.Text = "Saldo do devedor: R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(169, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Descrição: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 22);
            this.label14.TabIndex = 29;
            this.label14.Text = "Data da compra:";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(314, 197);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(192, 23);
            this.lblValorPago.TabIndex = 52;
            this.lblValorPago.Text = "dataCompra_apartamento";
            // 
            // lblValorParcelas
            // 
            this.lblValorParcelas.AutoSize = true;
            this.lblValorParcelas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelas.Location = new System.Drawing.Point(784, 196);
            this.lblValorParcelas.Name = "lblValorParcelas";
            this.lblValorParcelas.Size = new System.Drawing.Size(192, 23);
            this.lblValorParcelas.TabIndex = 53;
            this.lblValorParcelas.Text = "dataCompra_apartamento";
            // 
            // lblSaldoDevedor
            // 
            this.lblSaldoDevedor.AutoSize = true;
            this.lblSaldoDevedor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoDevedor.Location = new System.Drawing.Point(784, 126);
            this.lblSaldoDevedor.Name = "lblSaldoDevedor";
            this.lblSaldoDevedor.Size = new System.Drawing.Size(192, 23);
            this.lblSaldoDevedor.TabIndex = 54;
            this.lblSaldoDevedor.Text = "dataCompra_apartamento";
            // 
            // lblValorCubCompra
            // 
            this.lblValorCubCompra.AutoSize = true;
            this.lblValorCubCompra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCubCompra.Location = new System.Drawing.Point(320, 268);
            this.lblValorCubCompra.Name = "lblValorCubCompra";
            this.lblValorCubCompra.Size = new System.Drawing.Size(192, 23);
            this.lblValorCubCompra.TabIndex = 56;
            this.lblValorCubCompra.Text = "dataCompra_apartamento";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(314, 339);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(192, 23);
            this.lblValorTotal.TabIndex = 57;
            this.lblValorTotal.Text = "dataCompra_apartamento";
            // 
            // lblValorReforco
            // 
            this.lblValorReforco.AutoSize = true;
            this.lblValorReforco.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorReforco.Location = new System.Drawing.Point(784, 269);
            this.lblValorReforco.Name = "lblValorReforco";
            this.lblValorReforco.Size = new System.Drawing.Size(192, 23);
            this.lblValorReforco.TabIndex = 58;
            this.lblValorReforco.Text = "dataCompra_apartamento";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPagamento.Location = new System.Drawing.Point(103, 511);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(88, 26);
            this.txtDataPagamento.TabIndex = 59;
            this.txtDataPagamento.ValidatingType = typeof(System.DateTime);
            this.txtDataPagamento.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(58, 462);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(213, 23);
            this.lbl1.TabIndex = 60;
            this.lbl1.Text = "Informe a data do pagamento";
            this.lbl1.Visible = false;
            // 
            // btnCancelarPagamento
            // 
            this.btnCancelarPagamento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPagamento.Location = new System.Drawing.Point(172, 575);
            this.btnCancelarPagamento.Name = "btnCancelarPagamento";
            this.btnCancelarPagamento.Size = new System.Drawing.Size(86, 30);
            this.btnCancelarPagamento.TabIndex = 61;
            this.btnCancelarPagamento.Text = "Cancelar";
            this.btnCancelarPagamento.UseVisualStyleBackColor = false;
            this.btnCancelarPagamento.Visible = false;
            // 
            // btnOkParcela
            // 
            this.btnOkParcela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkParcela.Location = new System.Drawing.Point(48, 575);
            this.btnOkParcela.Name = "btnOkParcela";
            this.btnOkParcela.Size = new System.Drawing.Size(89, 30);
            this.btnOkParcela.TabIndex = 62;
            this.btnOkParcela.Text = "Ok";
            this.btnOkParcela.UseVisualStyleBackColor = false;
            this.btnOkParcela.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(122, 485);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 23);
            this.lbl2.TabIndex = 63;
            this.lbl2.Text = "e o valor";
            this.lbl2.Visible = false;
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagamento.Location = new System.Drawing.Point(103, 543);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(100, 26);
            this.txtValorPagamento.TabIndex = 64;
            this.txtValorPagamento.Visible = false;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(67, 546);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(30, 23);
            this.lblPagamento.TabIndex = 65;
            this.lblPagamento.Text = "R$";
            this.lblPagamento.Visible = false;
            // 
            // btnOkReforco
            // 
            this.btnOkReforco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkReforco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkReforco.Location = new System.Drawing.Point(48, 575);
            this.btnOkReforco.Name = "btnOkReforco";
            this.btnOkReforco.Size = new System.Drawing.Size(89, 30);
            this.btnOkReforco.TabIndex = 66;
            this.btnOkReforco.Text = "Ok";
            this.btnOkReforco.UseVisualStyleBackColor = false;
            this.btnOkReforco.Visible = false;
            this.btnOkReforco.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnOkOutroValor
            // 
            this.btnOkOutroValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkOutroValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkOutroValor.Location = new System.Drawing.Point(48, 575);
            this.btnOkOutroValor.Name = "btnOkOutroValor";
            this.btnOkOutroValor.Size = new System.Drawing.Size(89, 30);
            this.btnOkOutroValor.TabIndex = 67;
            this.btnOkOutroValor.Text = "Ok";
            this.btnOkOutroValor.UseVisualStyleBackColor = false;
            this.btnOkOutroValor.Visible = false;
            // 
            // btnOkQuitar
            // 
            this.btnOkQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkQuitar.Location = new System.Drawing.Point(48, 575);
            this.btnOkQuitar.Name = "btnOkQuitar";
            this.btnOkQuitar.Size = new System.Drawing.Size(89, 30);
            this.btnOkQuitar.TabIndex = 68;
            this.btnOkQuitar.Text = "Ok";
            this.btnOkQuitar.UseVisualStyleBackColor = false;
            this.btnOkQuitar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(379, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 50);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // lblReajsute
            // 
            this.lblReajsute.AutoSize = true;
            this.lblReajsute.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReajsute.Location = new System.Drawing.Point(671, 338);
            this.lblReajsute.Name = "lblReajsute";
            this.lblReajsute.Size = new System.Drawing.Size(176, 23);
            this.lblReajsute.TabIndex = 72;
            this.lblReajsute.Text = "Descrição_apartamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "Reajuste:";
            // 
            // telaInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1356, 742);
            this.Controls.Add(this.lblReajsute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOkQuitar);
            this.Controls.Add(this.btnOkOutroValor);
            this.Controls.Add(this.btnOkReforco);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnOkParcela);
            this.Controls.Add(this.btnCancelarPagamento);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.lblValorReforco);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValorCubCompra);
            this.Controls.Add(this.lblSaldoDevedor);
            this.Controls.Add(this.lblValorParcelas);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnPagarOutroValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPagarReforco);
            this.Controls.Add(this.btnPagarParcela);
            this.Controls.Add(this.tblPagamentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaInformacoes";
            this.Text = "Informações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tblPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblPagamentos;
        private System.Windows.Forms.Button btnPagarParcela;
        private System.Windows.Forms.Button btnPagarReforco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPagarOutroValor;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblValorParcelas;
        private System.Windows.Forms.Label lblSaldoDevedor;
        private System.Windows.Forms.Label lblValorCubCompra;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorReforco;
        private System.Windows.Forms.MaskedTextBox txtDataPagamento;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCancelarPagamento;
        private System.Windows.Forms.Button btnOkParcela;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Button btnOkReforco;
        private System.Windows.Forms.Button btnOkOutroValor;
        private System.Windows.Forms.Button btnOkQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaOuReforco;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cub;
        private System.Windows.Forms.DataGridViewTextBoxColumn reajuste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReajsute;
        private System.Windows.Forms.Label label4;
    }
}