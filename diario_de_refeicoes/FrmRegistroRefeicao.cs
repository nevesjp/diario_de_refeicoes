using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace diario_de_refeicoes
{
    public partial class FrmRegistroRefeicao : Form
    {

        string StringConexao = "Data Source=localhost\\sqlexpress;Initial Catalog=minhas_refeicoes;Integrated Security=True;User ID=sa;Password=sysdb;Encrypt=False";

        public FrmRegistroRefeicao()
        {
            InitializeComponent();
            getDadosComboBox();
        }

        private void getDadosComboBox()
        {
            CarregaNomesRefeicoes();
            CarregaTipoRealizado();
        }

        private void CarregaNomesRefeicoes()
        {
            string queryString = "SELECT Nome from TipoRefeicao";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexao);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    cmbRefeicao.Items.Add(row[0].ToString());
                }
                conexao.Close();
            }
        }

        private void CarregaTipoRealizado()
        {
            string queryString = "SELECT Nome from TipoRealizado";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexao);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    cmbRealizado.Items.Add(row[0].ToString());
                }
                conexao.Close();
            }
        }

        private void cmbRefeicao_SelectedValueChanged(object sender, EventArgs e)
        {
            // Verificar se há um item selecionado e obter o valor da seleção
            string? vlr = cmbRefeicao.SelectedItem as string;

            // Habilitar ou desabilitar o TextBox com base na seleção
            txtDataRealizado.Enabled = !string.IsNullOrEmpty(vlr);

            // Dicionário para mapear refeições a horários
            var horarios = new Dictionary<string, DateTime>
            {
                { "Café da manhã", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0) },
                { "Lanche da Manhã", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0) },
                { "Almoço", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0) },
                { "Lanche da tarde", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0) },
                { "Jantar", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0) }
            };

            // Atribuir o horário correspondente ao valor selecionado ou null se não houver correspondência
            DateTime? date = horarios.TryGetValue(vlr ?? string.Empty, out DateTime horario) ? horario : (DateTime?)null;

            // Definir o texto do TextBox com a data e a hora formatada, ou limpar se o horário for null
            txtDataRealizado.Text = date.HasValue ? date.Value.ToString("dd/MM/yyyy HH:mm") : string.Empty;

            // Habilitar o ComboBox relacionado
            cmbRealizado.Enabled = true;
        }



        private void cmbRefeicao_Leave(object sender, EventArgs e)
        {
            if (cmbRefeicao.SelectedItem == null || string.IsNullOrEmpty(cmbRefeicao.SelectedItem.ToString()))
            {
                txtDataRealizado.Text = "";
                txtDataRealizado.Enabled = false;

                cmbRealizado.Text = "";
                cmbRealizado.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool podeSalvar =
                // Verificar se o item selecionado em cmbRefeicao não é null e não está vazio
                cmbRefeicao.SelectedItem != null &&
                !string.IsNullOrEmpty(cmbRefeicao.SelectedItem.ToString()) &&

                // Verificar se txtDataRealizado não está vazio
                !string.IsNullOrEmpty(txtDataRealizado.Text) &&

                // Verificar se o item selecionado em cmbRealizado não é null e não está vazio
                (cmbRealizado.SelectedItem != null && !string.IsNullOrEmpty(cmbRealizado.SelectedItem.ToString()));

            if (podeSalvar)
            {
                try
                {
                    // Abrir a conexão
                    using (SqlConnection conexao = new SqlConnection(StringConexao))
                    {
                        conexao.Open();

                        // Comando SQL com parâmetros
                        string comandoSql = "INSERT INTO RegistroRefeicoes (Nome, DataRealizado, Realizado, Ponto) VALUES (@Valor1, @Valor2, @Valor3, @Valor4)";
                        using (SqlCommand cmd = new SqlCommand(comandoSql, conexao))
                        {
                            // Adicionar parâmetros com valores correspondentes
                            cmd.Parameters.AddWithValue("@Valor1", cmbRefeicao.Text); // Ou use .SelectedItem.ToString() se preferir
                            cmd.Parameters.AddWithValue("@Valor2", txtDataRealizado.Text); // Acessar o texto do TextBox
                            cmd.Parameters.AddWithValue("@Valor3", cmbRealizado.Text); // Ou use .SelectedItem.ToString() se preferir
                            cmd.Parameters.AddWithValue("@Valor4", getPontoRefeicao(cmbRealizado.Text)); // Ou use .SelectedItem.ToString() se preferir

                            // Executar o comando
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Registrado com sucesso!");
                                Close();

                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro foi inserido.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERR-00: O registro não foi salvo. Verifique os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal getPontoRefeicao(string TipoRealizado)
        {
            decimal ponto = 0.00m;

            switch (TipoRealizado)
            {
                case "De acordo com o proposto": ponto = 2; break;
                case "Não atingiu quantidade": ponto = 1.50m; break;
                case "Não realizado": ponto = 0; break;
                case "Substituído": ponto = 2; break;
                case "Refeição Livre": ponto = 1; break;
                default: ponto = 0; break;
            }
            return ponto;
        }
    }
}
