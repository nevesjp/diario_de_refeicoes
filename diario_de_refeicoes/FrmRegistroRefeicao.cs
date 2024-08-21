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

namespace diario_de_refeicoes
{
    public partial class FrmRegistroRefeicao : Form
    {

        string StringConexao = "Data Source=localhost\\sqlexpress;Initial Catalog=minhas_refeicoes;Integrated Security=True;User ID=sa;Password=sysdb;Encrypt=False";

        public FrmRegistroRefeicao()
        {
            InitializeComponent();
            CarregaNomesRefeicoes();
        }

        private void CarregaNomesRefeicoes()
        {
            string queryString = "SELECT Nome from TipoRefeicao";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexao);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows){
                    cmbRefeicao.Items.Add(row[0].ToString());
                }
                conexao.Close();
                
            }
        }
    }
}
