using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarius
{
    public partial class AquariusMenu : Form
    {
        public struct StructPaciente
        {
            public int codigo;
            public string nome;
            public string descricao;
            public string idade;
            public string sexo;
            public string CPF;
            public string RG;
            public string DataEntrada;
            public string Responsavel;
            public string ContRespon;
            // Imagem talvez?
        }

        static public StructPaciente[] Pacientes = new StructPaciente[10];
        static public int contPacientes = 0;

        public AquariusMenu()
        {
            InitializeComponent();

            // Evento fechar
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);

            // Impede o redimensionamento da janela
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Desativa o botão de maximizar
            this.MaximizeBox = false;
        }

        // ----- Evento chamado antes do Menu fechar --------------
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {   
            // Mensagem de confirmação
            DialogResult result = MessageBox.Show("Tem certeza que deseja fechar o aplicativo?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // No option
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else
            {
                Application.Exit();
            }

        }
        // ----------- Botão Cadastro Paciente -------------- // Não altere nome da class
        private void button1_Click(object sender, EventArgs e)
        {
            CadPacientes CadPaci = new CadPacientes();
            CadPaci.Show();
            this.Hide();
        }

        // ----------- Botão Relatorio Paciente ------------- // Não altere nome da class
        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioPreview.ShowDialog();
        }

        private void RelatorioPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;

            // Puta que pariu que merda de codigo
            while (cabecalho)
            {
                Dados = "                                                                 RELATÓRIO DOS PACIENTES" + (char)10;
                Dados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy").PadRight(153) + "    Pág:  " + pag.ToString("00") + (char)10;
                Dados += "-----------------------------------------------------------------------------------------------------------------------------------------------------" + (char)10;
                Dados += "Código      Nome                                              CPF                                                                  Contato do Responsavel" + (char)10;
                Dados += "-----------------------------------------------------------------------------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                itens = true;
                while (itens)
                {
                    Dados += Pacientes[i].codigo.ToString("0000").PadRight(10) + " | " + Pacientes[i].nome.PadRight(49) + "   |   " + Pacientes[i].CPF.PadRight(60) + "  |  " + Pacientes[i].ContRespon + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        Dados += (char)12;
                    }
                    if (i >= contPacientes)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
            }
            objImpressao.DrawString(Dados, new Font("Microsoft Sans Serif", 10, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        // ---------------------------------------------
        //           Não utilizado - AKA Lixo
        // ---------------------------------------------
        private void Menu_Load(object sender, EventArgs e)
        {
            // Main menu
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Label Cadastro
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Label Relatorio
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Logo
        }
        private void PacientePreview_Load(object sender, EventArgs e)
        {
            // Preview Print
        }
    }
}
