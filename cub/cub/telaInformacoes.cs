using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cub
{
    public partial class telaInformacoes : Form
    {
        aluguel_bancoEntities3 bd = new aluguel_bancoEntities3();
        apartamentos_tabela algumApartamento = new apartamentos_tabela();
        public telaInformacoes()
        {      
            InitializeComponent();
            carregaLabels(telaPrincipal.valorCub);
            carregaTabela();
            btnCancelarPagamento.Click += cancelarPagamento;
            btnPagarParcela.Click += mostrarPagarParcela;
            btnPagarReforco.Click += mostrarPagarReforco;
            btnPagarOutroValor.Click += mostrarPagarOutroValor;
            btnQuitar.Click += mostrarQuitar;
            btnOkParcela.Click += pagarParcela;
            btnOkReforco.Click += pagarReforco;
            btnOkOutroValor.Click += pagarOutroValor;
            btnOkQuitar.Click += quitar;
            btnVoltar.Click += voltar;
            sumirTudo();
        }
        private void definirAlgumApartamento()
        {
            bd.apartamentos_tabela.ToList().ForEach(z =>
            {
                if(z.id == telaPrincipal.selecionado.id)
                {
                    algumApartamento = z;
                }
            });
        }

        private void sumirTudo()
        {
            btnOkOutroValor.Visible = false;
            btnOkParcela.Visible = false;
            btnOkQuitar.Visible = false;
            btnOkReforco.Visible = false;
            txtDataPagamento.Visible = false;
            txtValorPagamento.Visible = false;
            btnCancelarPagamento.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lblPagamento.Visible = false;
            txtValorPagamento.Clear();
            txtDataPagamento.Clear();
        }

        private void carregaTabela()
        {
            try
            {
                tblPagamentos.Rows.Clear();
                bool primeiro = true;
                double ultimo = 0.0;
                bd.pagamentos_tabela.ToList().ForEach(f =>
                {
                    if (f.id_apartamento == telaPrincipal.selecionado.id)
                    {
                        if (primeiro == true)
                        {
                            primeiro = false;
                            tblPagamentos.Rows.Add(f.id, f.data, f.tipo, Math.Round(f.valor, 2), f.valor_cub, 0);
                            ultimo = Convert.ToDouble(f.valor_cub);
                        }
                        else
                        {
                            try
                            {
                                Convert.ToDateTime(f.data);
                                tblPagamentos.Rows.Add(f.id,f.data, f.tipo, Math.Round(f.valor, 2), f.valor_cub, Math.Round(Convert.ToInt32(Convert.ToDouble(f.valor_cub) - ultimo) / (ultimo / 100), 4)+" %");
                                ultimo = Convert.ToDouble(f.valor_cub);
                            }
                            catch
                            {
                                tblPagamentos.Rows.Add(f.id, f.data, f.tipo, Math.Round(f.valor, 2), f.valor_cub, 0);
                            }
                        }
                    }
                });
                lblReajsute.Text = Convert.ToString(Math.Round(Convert.ToInt32(Convert.ToDouble(telaPrincipal.valorCub) - ultimo) / (ultimo / 100), 4) + " %" );
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os pagamentos");
            }
        }
        private void carregaLabels(double cub)
        {
            definirAlgumApartamento();
            lblDescricao.Text = algumApartamento.descricao;
            lblDataCompra.Text = Convert.ToString(algumApartamento.data_compra);
            lblValorPago.Text = Convert.ToString(Math.Round(algumApartamento.valor_pago_reais, 2));
            lblValorCubCompra.Text = Convert.ToString(algumApartamento.cub_quando_comprado);
            lblValorTotal.Text = Convert.ToString(Math.Round(algumApartamento.valor_em_reais, 2));
            lblSaldoDevedor.Text = Convert.ToString(Math.Round(Convert.ToDouble(algumApartamento.saldo_devedor_cub) * cub, 2));
            lblValorParcelas.Text = Convert.ToString(Math.Round(Convert.ToDouble(algumApartamento.valor_parcela_cub) * cub, 2));
            lblValorReforco.Text = Convert.ToString(Math.Round(Convert.ToDouble(algumApartamento.valor_reforco_cub) * cub, 2));
        }
        private void cancelarPagamento(object sender, EventArgs e)
        {
            btnOkOutroValor.Visible = false;
            btnOkParcela.Visible = false;
            btnOkQuitar.Visible = false;
            btnOkReforco.Visible = false;
            txtDataPagamento.Visible = false;
            txtValorPagamento.Visible = false;
            btnCancelarPagamento.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lblPagamento.Visible = false;
            txtValorPagamento.Clear();
            txtDataPagamento.Clear();
        }
        private void mostrarPagarParcela(object sender, EventArgs e)
        {
            sumirTudo();
            btnOkParcela.Visible = true;
            txtDataPagamento.Visible = true;
            btnCancelarPagamento.Visible = true;
            lbl1.Visible = true;
            txtDataPagamento.Focus();
        }
        private void mostrarPagarReforco(object sender, EventArgs e)
        {
            sumirTudo();
            btnOkReforco.Visible = true;
            txtDataPagamento.Visible = true;
            btnCancelarPagamento.Visible = true;
            lbl1.Visible = true;
            txtDataPagamento.Focus();
        }
        private void mostrarPagarOutroValor(object sender, EventArgs e)
        {
            sumirTudo();
            btnOkOutroValor.Visible = true;
            txtDataPagamento.Visible = true;
            btnCancelarPagamento.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            txtValorPagamento.Visible = true;
            lblPagamento.Visible = true;
            txtDataPagamento.Focus();
        }
        private void mostrarQuitar(object sender, EventArgs e)
        {
            sumirTudo();
            btnOkQuitar.Visible = true;
            txtDataPagamento.Visible = true;
            btnCancelarPagamento.Visible = true;
            lbl1.Visible = true;
            txtDataPagamento.Focus();
        }
        private void pagarParcela(object sender, EventArgs e)
        {
            try
            {
                pagamentos_tabela pagaParcela = new pagamentos_tabela()
                {
                    id_apartamento = algumApartamento.id,
                    tipo = "Parcela",
                    valor = Convert.ToDecimal(Convert.ToDouble(algumApartamento.valor_parcela_cub) * telaPrincipal.valorCub),
                    data = Convert.ToDateTime(txtDataPagamento.Text),
                    valor_cub = Convert.ToDecimal(telaPrincipal.valorCub)
                };
                bd.pagamentos_tabela.Add(pagaParcela);
                apartamentos_tabela m = bd.apartamentos_tabela.Single(a => a.id.Equals(algumApartamento.id));
                m.valor_pago_reais += pagaParcela.valor;
                m.valor_pago_cub += m.valor_parcela_cub;
                m.saldo_devedor_cub -= Convert.ToDecimal(algumApartamento.valor_parcela_cub);
                bd.SaveChanges();
                sumirTudo();
                MessageBox.Show("O Pagamento da parcela foi efetuado");
                carregaTabela();
                carregaLabels(telaPrincipal.valorCub);
            }
            catch
            {
                MessageBox.Show("Erro ao pagar a parcela");
                sumirTudo();
            }
        }
        private void pagarReforco(object sender, EventArgs e)
        {
            try
            {
                pagamentos_tabela pagaReforco = new pagamentos_tabela()
                {
                    id_apartamento = telaPrincipal.selecionado.id,
                    tipo = "Reforço",
                    valor = Convert.ToDecimal(Convert.ToDouble(telaPrincipal.selecionado.valor_reforco_cub) * telaPrincipal.valorCub),
                    data = Convert.ToDateTime(txtDataPagamento.Text),
                    valor_cub = Convert.ToDecimal(telaPrincipal.valorCub)
                };
                bd.pagamentos_tabela.Add(pagaReforco);
                apartamentos_tabela m = bd.apartamentos_tabela.Single(a => a.id.Equals(telaPrincipal.selecionado.id));
                m.saldo_devedor_cub -= Convert.ToDecimal(telaPrincipal.selecionado.valor_reforco_cub);
                m.valor_pago_reais += pagaReforco.valor;
                m.valor_pago_cub += Convert.ToDecimal(m.valor_reforco_cub);
                bd.SaveChanges();
                MessageBox.Show("O Pagamento do reforço foi efetuado");
                carregaTabela();
                carregaLabels(telaPrincipal.valorCub);
                sumirTudo();
            }
            catch
            {
                MessageBox.Show("Erro ao pagar o reforço");
                sumirTudo();
            }
        }
        private void pagarOutroValor(object sender, EventArgs e)
        {
            try
            {
                pagamentos_tabela pagaOutroValor = new pagamentos_tabela()
                {
                    id_apartamento = telaPrincipal.selecionado.id,
                    tipo = "Outro",
                    valor = Convert.ToDecimal(txtValorPagamento.Text),
                    data = Convert.ToDateTime(txtDataPagamento.Text),
                    valor_cub = Convert.ToDecimal(telaPrincipal.valorCub)
                };
                bd.pagamentos_tabela.Add(pagaOutroValor);
                apartamentos_tabela m = bd.apartamentos_tabela.Single(a => a.id.Equals(telaPrincipal.selecionado.id));
                m.valor_pago_reais += pagaOutroValor.valor;
                m.valor_pago_cub += Convert.ToDecimal(Convert.ToDouble(pagaOutroValor.valor) / telaPrincipal.valorCub);
                m.saldo_devedor_cub -= Convert.ToDecimal(Convert.ToDouble(pagaOutroValor.valor) / telaPrincipal.valorCub);
                bd.SaveChanges();
                MessageBox.Show($"O Pagamento no valor de R${txtValorPagamento.Text} foi efetuado");
                carregaTabela();
                sumirTudo();
                carregaLabels(telaPrincipal.valorCub);
                
            }
            catch
            {
                MessageBox.Show("Erro ao tentar pagar");
                sumirTudo();
            }
        }
        private void quitar(object sender, EventArgs e)
        {
            try
            {
                pagamentos_tabela quitar = new pagamentos_tabela()
                {
                    id_apartamento = telaPrincipal.selecionado.id,
                    tipo = "Outro",
                    valor = Convert.ToDecimal(Convert.ToDouble(algumApartamento.saldo_devedor_cub) * telaPrincipal.valorCub),
                    data = Convert.ToDateTime(txtDataPagamento.Text),
                    valor_cub = Convert.ToDecimal(telaPrincipal.valorCub)
                };
                bd.pagamentos_tabela.Add(quitar);
                apartamentos_tabela m = bd.apartamentos_tabela.Single(a => a.id.Equals(telaPrincipal.selecionado.id));
                m.valor_pago_reais += quitar.valor;
                m.valor_pago_cub += Convert.ToDecimal(Convert.ToDouble(quitar.valor) / telaPrincipal.valorCub);
                m.saldo_devedor_cub = 0;
                bd.SaveChanges();
                MessageBox.Show($"O aparamento foi quitado");
                carregaTabela();
                sumirTudo();
                carregaLabels(telaPrincipal.valorCub);
            }
            catch
            {
                MessageBox.Show("Erro ao tentar quitar");
                sumirTudo();
            }
        }
        private void voltar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
