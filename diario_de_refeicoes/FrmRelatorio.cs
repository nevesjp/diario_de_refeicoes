using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diario_de_refeicoes
{
    public partial class FrmRelatorio : Form
    {
        string StringConexao = "Data Source=localhost\\sqlexpress;Initial Catalog=minhas_refeicoes;Integrated Security=True;User ID=sa;Password=sysdb;Encrypt=False";
        public FrmRelatorio()
        {
            InitializeComponent();
            loadFrm();
        }

        private void loadFrm()
        {
            mskDataInicial.Text = DateTime.Now.ToString();
            mskDataFinal.Text = DateTime.Now.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if ((mskDataInicial.Text.Trim() == string.Empty || mskDataInicial.Text == mskDataInicial.Mask || mskDataInicial.Text == "  /  /") ||
                    (mskDataFinal.Text.Trim() == string.Empty || mskDataFinal.Text == mskDataInicial.Mask || mskDataFinal.Text == "  /  /"))
            {
                MessageBox.Show("O campo não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaRefeicoes();
        }

        private void CarregaRefeicoes()
        {
            // Converte as datas das máscaras para DateTime com as horas ajustadas
            DateTime dataInicial = DateTime.Parse(mskDataInicial.Text).Date;
            DateTime dataFinal = DateTime.Parse(mskDataFinal.Text).Date.AddHours(23).AddMinutes(59);

            string queryString = "SELECT Nome, DataRealizado, Realizado, ISNULL(Ponto, 0) AS Score FROM RegistroRefeicoes " +
                                 "WHERE DataRealizado BETWEEN @DataInicial AND @DataFinal";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                SqlCommand command = new SqlCommand(queryString, conexao);
                command.Parameters.AddWithValue("@DataInicial", dataInicial);
                command.Parameters.AddWithValue("@DataFinal", dataFinal);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Atribui o DataTable como fonte de dados para o DataGridView
                grdResult.DataSource = table;

                // Se necessário, atualiza a exibição do DataGridView
                grdResult.Refresh();

                if (table.Rows.Count > 0)
                {
                    decimal pontosSomados = table.AsEnumerable().Sum(row => row.Field<decimal>("Score"));
                    decimal pontosEsperados = table.Rows.Count * 2.0m;
                    double percentualAtingido = pontosEsperados > 0 ? (double)(pontosSomados / pontosEsperados) * 100 : 0;

                    prgBarTeste.Value = (int)percentualAtingido;

                    lblPontosSomados.Text = string.Format("Pontos somados no período: {0}. Pontos esperados: {1}.",
                                              pontosSomados.ToString("0.00"),
                                              pontosEsperados.ToString("0.00"));
                    lblPercentualAtingido.Text = string.Format("Atingiu: {0}%", percentualAtingido.ToString("0.00"));
                    if (percentualAtingido >= 80)
                    {
                        lblPontosSomados.ForeColor = Color.Green;
                        lblPercentualAtingido.ForeColor = Color.Green;
                    }
                    else if (percentualAtingido >= 50 && percentualAtingido < 80)
                    {
                        lblPontosSomados.ForeColor = Color.Orange;
                        lblPercentualAtingido.ForeColor = Color.Orange;
                    }
                    else
                    {
                        lblPontosSomados.ForeColor = Color.Red;
                        lblPercentualAtingido.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblPontosSomados.Text = "Nenhum resultado foi encontrado.";
                    lblPontosSomados.ForeColor = Color.Red;
                    lblPercentualAtingido.Text = "";
                }
            }
        }


        private void btnMenosDataInicial_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(mskDataInicial.Text, out DateTime dataInicial))
            {
                // Subtrai o valor 
                dataInicial = dataInicial.AddDays(-(int)numDias.Value);

                // Atualiza com a nova data
                mskDataInicial.Text = dataInicial.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
        }

        private void btnMaisDataInicial_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(mskDataInicial.Text, out DateTime dataInicial))
            {
                // Subtrai o valor 
                dataInicial = dataInicial.AddDays((int)numDias.Value);

                // Atualiza com a nova data
                mskDataInicial.Text = dataInicial.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
        }

        private void btnMenosDataFinal_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(mskDataFinal.Text, out DateTime dataFinal))
            {
                // Subtrai o valor 
                dataFinal = dataFinal.AddDays(-(int)numDias.Value);

                // Atualiza com a nova data
                mskDataFinal.Text = dataFinal.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
        }

        private void btnMaisDataFinal_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(mskDataFinal.Text, out DateTime dataFinal))
            {
                // Subtrai o valor 
                dataFinal = dataFinal.AddDays((int)numDias.Value);

                // Atualiza com a nova data
                mskDataFinal.Text = dataFinal.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
        }

        private void prgBarTeste_Click(object sender, EventArgs e)
        {
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(mskDataInicial.Text, out DateTime dataInicial))
            {
                // Subtrai o valor 
                dataInicial = dataInicial.AddDays(-7);

                // Atualiza com a nova data
                mskDataInicial.Text = dataInicial.ToString("dd/MM/yyyy");

                btnFiltrar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
        }
    }
}
