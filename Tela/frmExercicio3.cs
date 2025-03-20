using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TargetSistemas.Modelo;

namespace TargetSistemas
{
    public partial class frmExercicio3 : Form
    {
        private List<mdlExercicio3.Faturamento> Faturamentos = new List<mdlExercicio3.Faturamento>();

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

            double menorValor = Faturamentos.Where(f => f.Valor > 0).Min(f => f.Valor);
            double maiorValor = Faturamentos.Where(f => f.Valor > 0).Max(f => f.Valor);
            double somaFaturamento = Faturamentos.Where(f => f.Valor > 0).Sum(f => f.Valor);

            double somaFaturamentoSemFDSFeriado = Faturamentos
                .Where(f => f.Valor > 0 && !Feriado(f.Dia) && !FinalDeSemana(f.Dia))
                .Sum(f => f.Valor);
            int diasComFaturamentoSemFDSFeriado = Faturamentos
                .Count(f => f.Valor > 0 && !Feriado(f.Dia) && !FinalDeSemana(f.Dia));
            double mediaFaturamentoSemFDSFeriado = somaFaturamentoSemFDSFeriado / diasComFaturamentoSemFDSFeriado;
            int diasAcimaDaMediaSemFDSFeriado = Faturamentos
                .Count(f => f.Valor > mediaFaturamentoSemFDSFeriado && !Feriado(f.Dia) && !FinalDeSemana(f.Dia));

            txtMenorFaturamento.Text = menorValor.ToString("C2");
            txtMaiorFaturamento.Text = maiorValor.ToString("C2");
            txtNumeroDias.Text = diasAcimaDaMediaSemFDSFeriado.ToString();

        }


        private bool FinalDeSemana(int dia)
        {
            DateTime data = new DateTime(2025, 1, dia);
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }

        private bool Feriado(int dia)
        {
            DateTime data = new DateTime(2025, 1, dia);
            return Feriados.Contains(data);
        }

        List<DateTime> Feriados = new List<DateTime>
        {
            new DateTime(2025, 1, 1),
            new DateTime(2025, 12, 25),
        };

        private void CarregarDados()
        {
            try
            {
                string caminhoArquivo = "dados.json";
                var json = File.ReadAllText(caminhoArquivo);
                Faturamentos = JsonConvert.DeserializeObject<List<mdlExercicio3.Faturamento>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo JSON \n\n\n " + ex.Message);
            }
        }

    }
}
