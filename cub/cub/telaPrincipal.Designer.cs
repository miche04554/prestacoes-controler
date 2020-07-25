namespace cub
{
    partial class telaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.Label = new System.Windows.Forms.Label();
            this.btnAtualizaCub = new System.Windows.Forms.Button();
            this.lblValorDoCub = new System.Windows.Forms.Label();
            this.btnCadastrarAluguel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblAlugueisTelaPrincipal = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDoDevedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNovoCub = new System.Windows.Forms.TextBox();
            this.lblNovoCub = new System.Windows.Forms.Label();
            this.btnAtualizaTabela = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxExcluir = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlugueisTelaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(20, 49);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(221, 24);
            this.Label.TabIndex = 0;
            this.Label.Text = "VALOR ATUAL DO CUB:";
            this.Label.Click += new System.EventHandler(this.lblValorCub_Click);
            // 
            // btnAtualizaCub
            // 
            this.btnAtualizaCub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizaCub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaCub.Location = new System.Drawing.Point(577, 38);
            this.btnAtualizaCub.Name = "btnAtualizaCub";
            this.btnAtualizaCub.Size = new System.Drawing.Size(157, 48);
            this.btnAtualizaCub.TabIndex = 1;
            this.btnAtualizaCub.Text = "ATUALIZAR CUB";
            this.btnAtualizaCub.UseVisualStyleBackColor = false;
            // 
            // lblValorDoCub
            // 
            this.lblValorDoCub.AutoSize = true;
            this.lblValorDoCub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDoCub.Location = new System.Drawing.Point(247, 49);
            this.lblValorDoCub.Name = "lblValorDoCub";
            this.lblValorDoCub.Size = new System.Drawing.Size(75, 24);
            this.lblValorDoCub.TabIndex = 3;
            this.lblValorDoCub.Text = "1800,00";
            // 
            // btnCadastrarAluguel
            // 
            this.btnCadastrarAluguel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluguel.Location = new System.Drawing.Point(769, 38);
            this.btnCadastrarAluguel.Name = "btnCadastrarAluguel";
            this.btnCadastrarAluguel.Size = new System.Drawing.Size(163, 48);
            this.btnCadastrarAluguel.TabIndex = 4;
            this.btnCadastrarAluguel.Text = "NOVO APARTAMENTO";
            this.btnCadastrarAluguel.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(641, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 5;
            // 
            // tblAlugueisTelaPrincipal
            // 
            this.tblAlugueisTelaPrincipal.AllowUserToAddRows = false;
            this.tblAlugueisTelaPrincipal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblAlugueisTelaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlugueisTelaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.dataCompra,
            this.valorPago,
            this.saldoDoDevedor});
            this.tblAlugueisTelaPrincipal.Location = new System.Drawing.Point(449, 124);
            this.tblAlugueisTelaPrincipal.Name = "tblAlugueisTelaPrincipal";
            this.tblAlugueisTelaPrincipal.Size = new System.Drawing.Size(823, 468);
            this.tblAlugueisTelaPrincipal.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 30;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 330;
            // 
            // dataCompra
            // 
            this.dataCompra.HeaderText = "Data da Compra";
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.ReadOnly = true;
            this.dataCompra.Width = 150;
            // 
            // valorPago
            // 
            this.valorPago.HeaderText = "Valor Pago";
            this.valorPago.Name = "valorPago";
            this.valorPago.ReadOnly = true;
            this.valorPago.Width = 150;
            // 
            // saldoDoDevedor
            // 
            this.saldoDoDevedor.HeaderText = "Saldo do Devedor";
            this.saldoDoDevedor.Name = "saldoDoDevedor";
            this.saldoDoDevedor.ReadOnly = true;
            this.saldoDoDevedor.Width = 150;
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacoes.Location = new System.Drawing.Point(967, 38);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(171, 48);
            this.btnInformacoes.TabIndex = 7;
            this.btnInformacoes.Text = "INFORMAÇÕES";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1173, 38);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(158, 48);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(282, 97);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 22);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            // 
            // txtNovoCub
            // 
            this.txtNovoCub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoCub.Location = new System.Drawing.Point(211, 97);
            this.txtNovoCub.Name = "txtNovoCub";
            this.txtNovoCub.Size = new System.Drawing.Size(74, 22);
            this.txtNovoCub.TabIndex = 12;
            this.txtNovoCub.Visible = false;
            // 
            // lblNovoCub
            // 
            this.lblNovoCub.AutoSize = true;
            this.lblNovoCub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoCub.Location = new System.Drawing.Point(222, 78);
            this.lblNovoCub.Name = "lblNovoCub";
            this.lblNovoCub.Size = new System.Drawing.Size(129, 16);
            this.lblNovoCub.TabIndex = 13;
            this.lblNovoCub.Text = "Informe o novo valor";
            this.lblNovoCub.Visible = false;
            // 
            // btnAtualizaTabela
            // 
            this.btnAtualizaTabela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizaTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaTabela.Location = new System.Drawing.Point(385, 38);
            this.btnAtualizaTabela.Name = "btnAtualizaTabela";
            this.btnAtualizaTabela.Size = new System.Drawing.Size(157, 48);
            this.btnAtualizaTabela.TabIndex = 14;
            this.btnAtualizaTabela.Text = "ATUALIZAR TABELA";
            this.btnAtualizaTabela.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(896, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 48);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // pbxExcluir
            // 
            this.pbxExcluir.BackColor = System.Drawing.Color.White;
            this.pbxExcluir.Location = new System.Drawing.Point(667, 231);
            this.pbxExcluir.Name = "pbxExcluir";
            this.pbxExcluir.Size = new System.Drawing.Size(415, 162);
            this.pbxExcluir.TabIndex = 17;
            this.pbxExcluir.TabStop = false;
            this.pbxExcluir.Visible = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(691, 334);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(171, 48);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Visible = false;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.Location = new System.Drawing.Point(711, 276);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(318, 20);
            this.lblExcluir.TabIndex = 18;
            this.lblExcluir.Text = "Deseja deletar o apartamento selecionado?";
            this.lblExcluir.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1187, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "RELATÓRIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1021, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(251, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Mostrar Somente os apartamentos não quitados";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.pbxExcluir);
            this.Controls.Add(this.btnAtualizaTabela);
            this.Controls.Add(this.lblNovoCub);
            this.Controls.Add(this.txtNovoCub);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.tblAlugueisTelaPrincipal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrarAluguel);
            this.Controls.Add(this.lblValorDoCub);
            this.Controls.Add(this.btnAtualizaCub);
            this.Controls.Add(this.Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlugueisTelaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnAtualizaCub;
        private System.Windows.Forms.Label lblValorDoCub;
        private System.Windows.Forms.Button btnCadastrarAluguel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNovoCub;
        private System.Windows.Forms.Label lblNovoCub;
        private System.Windows.Forms.Button btnAtualizaTabela;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxExcluir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDoDevedor;
        public System.Windows.Forms.DataGridView tblAlugueisTelaPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

