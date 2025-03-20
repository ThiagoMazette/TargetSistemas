using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetSistemas
{
    public partial class frmExercicio3 : Form
    {

        private List<Faturamento> Faturamentos = new List<Faturamento>();

        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CarregarDados();

            if (Faturamentos.Count == 0)
            {
                MessageBox.Show("Não há dados de faturamento");
                return;
            }

            // Calcular o menor e o maior valor de faturamento
            double menorValor = Faturamentos.Where(f => f.Valor > 0).Min(f => f.Valor);
            double maiorValor = Faturamentos.Where(f => f.Valor > 0).Max(f => f.Valor);

            // Calcular a média de faturamento (ignorar os dias com faturamento zero)
            double somaFaturamento = Faturamentos.Where(f => f.Valor > 0).Sum(f => f.Valor);
            int diasComFaturamento = Faturamentos.Count(f => f.Valor > 0);
            double mediaFaturamento = somaFaturamento / diasComFaturamento;

            // Contar quantos dias tiveram faturamento superior à média
            int diasAcimaDaMedia = Faturamentos.Count(f => f.Valor > mediaFaturamento);

            // Exibir os resultados
            txtMenorFaturamento.Text = $"Menor Faturamento: {menorValor:C2}";
            txtMaiorFaturamento.Text = $"Maior Faturamento: {maiorValor:C2}";
        //    lblMediaFaturamento.Text = $"Média Faturamento: {mediaFaturamento:C2}";
            txtNumeroDias.Text = $"Dias com Faturamento Acima da Média: {diasAcimaDaMedia}";

        }

        private void CarregarDados()
        {
            try
            {                
                string caminhoArquivo = "dados.json";               
                var json = File.ReadAllText(caminhoArquivo);               
                Faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo JSON \n\n\n "+ ex.Message);
            }
        }
    }

    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
