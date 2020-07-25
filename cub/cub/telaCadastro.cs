using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cub
{
    public partial class telaCadastro : Form
    {
        aluguel_bancoEntities3 bd = new aluguel_bancoEntities3();
        public telaCadastro()
        {
            InitializeComponent();
            btnSalvar.Click += salvarAluguel;
            btnVoltar.Click += voltar;          
        }
        private void voltar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void salvarAluguel(object sender, EventArgs e)
        {
            try
            {
                apartamentos_tabela novo = new apartamentos_tabela()
                {
                    descricao = txtDescricao.Text,
                    data_compra = Convert.ToDateTime(txtDataCompra.Text),
                    valor_em_reais = Convert.ToDecimal(txtValorTotal.Text),
                    cub_quando_comprado = Convert.ToDecimal(txtValorCubCompra.Text),
                    valor_em_cub = Convert.ToDecimal(Convert.ToDecimal(txtValorTotal.Text) / Convert.ToDecimal(txtValorCubCompra.Text)),
                    valor_pago_reais = Convert.ToDecimal(txtValorEntrada.Text),
                    valor_pago_cub = Convert.ToDecimal(Convert.ToDecimal(txtValorEntrada.Text) / Convert.ToDecimal(txtValorCubCompra.Text)),
                    saldo_devedor_cub = Convert.ToDecimal((Convert.ToDecimal(txtValorTotal.Text) - Convert.ToDecimal(txtValorEntrada.Text)) / Convert.ToDecimal(txtValorCubCompra.Text)),
                    valor_parcela_cub = Convert.ToDecimal(Convert.ToDecimal(txtValorParcelas.Text) / Convert.ToDecimal(txtValorCubCompra.Text)),
                    valor_reforco_cub = Convert.ToDecimal(Convert.ToDecimal(txtValorReforcos.Text) / Convert.ToDecimal(txtValorCubCompra.Text)),
                };
                bd.apartamentos_tabela.Add(novo);
                bd.SaveChanges();
                int idEntrada = 0;
                bd.apartamentos_tabela.ToList().ForEach(m =>
                {
                    if (m.descricao.Equals(txtDescricao.Text))
                    {
                        idEntrada = m.id;
                    }
                });
                pagamentos_tabela pagaEntrada = new pagamentos_tabela()
                {
                    id_apartamento = idEntrada,
                    tipo = "Entrada",
                    valor = Convert.ToDecimal(txtValorEntrada.Text),
                    data = Convert.ToDateTime(txtDataCompra.Text),
                    valor_cub = Convert.ToDecimal(txtValorCubCompra.Text)
                };
                bd.pagamentos_tabela.Add(pagaEntrada);
                bd.SaveChanges();
                MessageBox.Show("Aluguel salvo com sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
