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

            string queryString = "SELECT Nome, DataRealizado, Realizado FROM RegistroRefeicoes " +
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
            }
        }




    }
}
