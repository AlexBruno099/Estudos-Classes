using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_importantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                lblResultado.Text = "yes";
            }
            else
            {
                lblResultado.Text = "NO ";
            }
        }

        private void btnAleatorios_Click(object sender, EventArgs e)
        {
            Random r = new Random();

           int valor = r.Next(0, 100);

            lblResultado.Text = "Numeros :" + valor;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            // lblResultado.Text =  TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(5, 30,30);

            TimeSpan fim = new TimeSpan(18, 25, 0);

            TimeSpan intervalo = fim - inicio;
            lblResultado.Text = intervalo.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            /// lblResultado.Text = DateTime.Now.ToString(); // Data, Hora, Segundos, dia, mes e ano
            /// lblResultado.Text = DateTime.Today.ToString(); // Data, Hora, Segundos
            /// lblResultado.Text = DateTime.DaysInMonth(2024, 02).ToString(); // dias que um mês teria
            ///  lblResultado.Text = DateTime.IsLeapYear(2024).ToString(); // verifica se o ano é ano bisexto
            /// lblResultado.Text = DateTime.Now.ToShortDateString(); // data abreviada
            ///   lblResultado.Text = DateTime.Now.ToLongDateString(); // data completa
            /// lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //formatação de data e hora
            /// 
            DateTime data = new DateTime(1985, 01, 10/*DATA*/, 14,35,29/*Hora*/ );

           // lblResultado.Text = data.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.Add(tempo).ToString();


            lblResultado.Text = data.DayOfWeek.ToString();


        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            // Color cor1 = Color.FromArgb(255, Color.DarkGreen);
            Color cor1 = Color.FromArgb(255, Color.DarkGreen);
            Color cor2 = Color.FromKnownColor(KnownColor.Control);
            Color cor3 = Color.FromName("DarkRed");

            lblResultado.BackColor = cor3;
            lblResultado.ForeColor = cor2;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string dirAtual = Environment.CurrentDirectory;

            lblResultado.Text = dirAtual;
        }

        private void btnAplication_Click(object sender, EventArgs e)
        {
            string exec = Application.ExecutablePath;

            string pasta = Application.StartupPath;

            //Application.Restart();

            lblResultado.Text = "Caminho da pasta: " + pasta;

            lblResultado.Text = "Caminho do Executavel :" + exec;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font fonte = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Pixel);
            lblResultado.Text = "Bem vindo";
            lblResultado.Font = fonte;
        }
    }
}
