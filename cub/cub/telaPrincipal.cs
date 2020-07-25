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
    public partial class telaPrincipal : Form
    {
        aluguel_bancoEntities3 bd = new aluguel_bancoEntities3();
        public static apartamentos_tabela selecionado = new apartamentos_tabela();
        public static double valorCub = 0;
        public telaPrincipal()
        {
            InitializeComponent();         
            button1.Click += Button1_Click;
            try
            {
                bd.cub_tabela.ToList().ForEach(c =>
                {
                    if (c.id == 1)
                    {
                        valorCub = Convert.ToDouble(c.valor_atual_do_cub);
                        lblValorDoCub.Text = Convert.ToString(c.valor_atual_do_cub);
                    }
                });
            }
            catch
            {
                MessageBox.Show("Erro ao carregar o valor do cub");
            }
            btnOk.Click += atualizarCub;
            btnAtualizaCub.Click += mostarAtualizacao; ;
            btnCadastrarAluguel.Click += cadastro;
            btnInformacoes.Click += informcoes;
            btnAtualizaTabela.Click += BtnAtualizaTabela_Click;
            btnExcluir.Click += mostrarExcluir;
            btnDeletar.Click += excluir;
            btnCancelar.Click += CancelarExcluir;
            this.tblAlugueisTelaPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tblAlugueisTelaPrincipal.MultiSelect = false;
            montarTabelaApartamentos();
            checkBox1.Click += BtnAtualizaTabela_Click;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                aluguel_bancoEntities3 bd = new aluguel_bancoEntities3();
                using (var doc = new PdfSharp.Pdf.PdfDocument())
                {
                    int distancia = 150;

                    var page = doc.AddPage();
                    var graphicx = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                    var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphicx);
                    var fontTitulo = new PdfSharp.Drawing.XFont("Arial", 16);
                    var font = new PdfSharp.Drawing.XFont("Arial", 12);

                    textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                    textFormatter.DrawString("Relatório Geral\n \n \n", fontTitulo, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 70, page.Width, page.Height));
                    textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
                    textFormatter.DrawString(" Descrição", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 120, 250, 145));
                    textFormatter.DrawString(" Data", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(255, 120, 320, 145));
                    textFormatter.DrawString(" Valor Pago", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(345, 120, 420, 145));
                    textFormatter.DrawString(" Saldo do Devedor", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(445, 120, 590, 145));

                    bd.apartamentos_tabela.ToList().ForEach(ap =>
                    {
                        textFormatter.DrawString(ap.descricao, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, distancia, 250, distancia + 25));
                        textFormatter.DrawString(Convert.ToString(ap.data_compra.Value.ToString("dd/MM/yyyy")), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(255, distancia, 320, distancia + 25));
                        textFormatter.DrawString("R$" + Convert.ToString(Math.Round(ap.valor_pago_reais, 2)), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(345, distancia, 420, distancia + 25));
                        textFormatter.DrawString("R$" + Convert.ToString(Math.Round(Convert.ToDouble(ap.saldo_devedor_cub) * valorCub, 2)), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(445, distancia, 590, distancia + 25));
                        distancia += 30;
                    });
                    graphicx.DrawLine(PdfSharp.Drawing.XPens.Black, 250, 130, 250, distancia);
                    graphicx.DrawLine(PdfSharp.Drawing.XPens.Black, 340, 130, 340, distancia);
                    graphicx.DrawLine(PdfSharp.Drawing.XPens.Black, 440, 130, 440, distancia);
                    doc.Save("arquivo.pdf");
                    System.Diagnostics.Process.Start("arquivo.pdf");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao gerar PDF");
            }
        }
        public void CancelarExcluir(object sender, EventArgs e)
        {
            lblExcluir.Visible = false;
            pbxExcluir.Visible = false;
            btnDeletar.Visible = false;
            btnCancelar.Visible = false;
        }
        private void mostrarExcluir(object sender, EventArgs e)
        {
            btnDeletar.Visible = true;
            btnCancelar.Visible = true;
            lblExcluir.Visible = true;
            pbxExcluir.Visible = true;
        }
        private void BtnAtualizaTabela_Click(object sender, EventArgs e)
        {
            montarTabelaApartamentos();
        }
        public void montarTabelaApartamentos()
        {
            aluguel_bancoEntities3 bd = new aluguel_bancoEntities3();
            try
            {
                tblAlugueisTelaPrincipal.Rows.Clear();
                bd.apartamentos_tabela.ToList().ForEach(m =>
                {
                    if ((checkBox1.Checked && m.saldo_devedor_cub != 0) || !checkBox1.Checked)
                    {
                        tblAlugueisTelaPrincipal.Rows.Add(m.id, m.descricao, m.data_compra.Value.ToString("dd/MM/yyyy"), "R$ " + Math.Round(m.valor_pago_reais, 2), "R$ " + Math.Round(Convert.ToDouble(m.saldo_devedor_cub) * valorCub, 2));
                    }
                });
            }
            catch
            {
                MessageBox.Show("Erro na conexão com o banco de dados");
            }
        }
        private void mostarAtualizacao(object sender, EventArgs e)
        {
            txtNovoCub.Visible = true;
            lblNovoCub.Visible = true;
            btnOk.Visible = true;
            txtNovoCub.Focus();
        }
        private void excluir(object sender, EventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(tblAlugueisTelaPrincipal.SelectedRows[0].Cells[0].Value);
                selecionado = bd.apartamentos_tabela.Where(u => u.id.Equals(idSelecionado)).FirstOrDefault();
                apartamentos_tabela excluirI = new apartamentos_tabela();
                bd.apartamentos_tabela.ToList().ForEach(f =>
                {
                    if (f.id.Equals(idSelecionado))
                    {
                        excluirI = f;
                    }
                });
                bd.apartamentos_tabela.Remove(excluirI);
                pagamentos_tabela ExclirPg = new pagamentos_tabela();
                bd.pagamentos_tabela.ToList().ForEach(z =>
                {
                    if (z.id_apartamento.Equals(idSelecionado))
                    {
                        ExclirPg = z;
                        bd.pagamentos_tabela.Remove(ExclirPg);
                    }
                });
                bd.SaveChanges();
                MessageBox.Show("Apartamento excluído");
                lblExcluir.Visible = false;
                pbxExcluir.Visible = false;
                btnDeletar.Visible = false;
                btnCancelar.Visible = false;
                montarTabelaApartamentos();
            }
            catch
            {
                MessageBox.Show("Selecione uma linha antes de deletar");
                lblExcluir.Visible = false;
                pbxExcluir.Visible = false;
                btnDeletar.Visible = false;
                btnCancelar.Visible = false;
            }
        }
        private void informcoes(object sender, EventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(tblAlugueisTelaPrincipal.SelectedRows[0].Cells[0].Value);
                selecionado = bd.apartamentos_tabela.Where(u => u.id.Equals(idSelecionado)).FirstOrDefault();
                if (selecionado != null)
                {
                    new telaInformacoes().Show();
                }
                else
                {
                    MessageBox.Show("Selecione um apartamento");
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma linha antes");
            }
        }
        private void cadastro(object sender, EventArgs e)
        {
            new telaCadastro().Show();
        }
        private void atualizarCub(object sender, EventArgs e)
        {
            try
            {
                valorCub = Math.Round(Convert.ToDouble(txtNovoCub.Text), 2);
                cub_tabela nsei = bd.cub_tabela.Single(c => c.id.Equals(1));
                nsei.valor_atual_do_cub = Convert.ToDecimal(valorCub);
                bd.SaveChanges();
                lblValorDoCub.Text = Convert.ToString(valorCub);
                txtNovoCub.Visible = false;
                lblNovoCub.Visible = false;
                btnOk.Visible = false;
                txtNovoCub.Clear();
                montarTabelaApartamentos();
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar o cub");
                txtNovoCub.Visible = false;
                lblNovoCub.Visible = false;
                btnOk.Visible = false;
            }
        }
        private void lblValorCub_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
