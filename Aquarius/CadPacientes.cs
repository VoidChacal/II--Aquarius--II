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
    public partial class CadPacientes : Form
    {
        bool EditTipo = false;
        int atual = 0;

        // ----------- Habilitar Edição -------------
        private void HabilitaEdit()
        {
            CodPaciente.Enabled = false;
            NomePaciente.Enabled = true;
            DescPaciente.Enabled = true;
            EnvFoto.Enabled = true;
            Anterior.Enabled = false;
            Proximo.Enabled = false;
            Novo.Enabled = false;
            Alterar.Enabled = false;
            Excluir.Enabled = false;
            Salvar.Enabled = true;
            Cancelar.Enabled = true;
            Pesquisa.Enabled = false;
            Imprimir.Enabled = false;
            Voltar.Enabled = false;
        }

        // ------------ Desabilitar Edição --------------
        private void DesabilitarEdit()
        {
            CodPaciente.Enabled = false;
            NomePaciente.Enabled = false;
            DescPaciente.Enabled = false;
            EnvFoto.Enabled = false;
            Anterior.Enabled = true;
            Proximo.Enabled = true;
            Novo.Enabled = true;
            Alterar.Enabled = true;
            Excluir.Enabled = true;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Pesquisa.Enabled = true;
            Imprimir.Enabled = true;
            Voltar.Enabled = true;
        }

        // ------------ Mostrar Dados --------------
        private void ShowDados()
        {
            CodPaciente.Text = AquariusMenu.Pacientes[atual].codigo.ToString();
            NomePaciente.Text = AquariusMenu.Pacientes[atual].nome;
            DescPaciente.Text = AquariusMenu.Pacientes[atual].descricao;
        }

        public CadPacientes()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Cad_formClosing);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        // ----- Evento chamado antes do CadPacientes fechar --------------
        private void Cad_formClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja fechar o aplicativo?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
       
        // ------ Botão de preview da impressão -------
        private void button9_Click(object sender, EventArgs e)
        {
            PacientePreview.ShowDialog();
        }

        // ------ Voltar para Menu -------
        private void Voltar_Click(object sender, EventArgs e)
        {
            AquariusMenu menu = new AquariusMenu();
            menu.Show();
            this.Hide();
        }

        // -------- Novo Paciente ---------
        private void Novo_Click(object sender, EventArgs e)
        {
            if (AquariusMenu.contPacientes < 10)
            {
                CodPaciente.Text = (AquariusMenu.contPacientes + 1).ToString();
                NomePaciente.Text = "";
                DescPaciente.Text = "";
                // Imagem Novo
                HabilitaEdit();
                EditTipo = true;
            }
        }

        // -------- Salvar Perfil Criado/Edit ----------
        private void Salvar_Click(object sender, EventArgs e)
        {
            if (EditTipo)
            {
                AquariusMenu.Pacientes[AquariusMenu.contPacientes].codigo = int.Parse(CodPaciente.Text);
                AquariusMenu.Pacientes[AquariusMenu.contPacientes].nome = NomePaciente.Text;
                AquariusMenu.Pacientes[AquariusMenu.contPacientes].descricao = DescPaciente.Text;
                atual = AquariusMenu.contPacientes++;
            }
            else
            {
                AquariusMenu.Pacientes[atual].nome = NomePaciente.Text;
                AquariusMenu.Pacientes[atual].descricao = DescPaciente.Text;
            }
            DesabilitarEdit();
        }

        // --------- Excluir Perfil Atual ----------
        private void Excluir_Click(object sender, EventArgs e)
        {
            if(AquariusMenu.contPacientes > 0)
            {
                AquariusMenu.Pacientes[atual].nome = "";
                AquariusMenu.Pacientes[atual].descricao = "";
                ShowDados();
            }
        }

        // --------- Habilitar Edição de Perfil -----------
        private void Alterar_Click(object sender, EventArgs e)
        {
            if (atual < AquariusMenu.contPacientes - 1)
            {
                HabilitaEdit();
                EditTipo = false;
            }
            else
            {
                MessageBox.Show("Nenhum perfil de paciente para alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------- Voltar para o perfil anterior ----------
        private void Anterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                ShowDados();
            }
            else
            {
                MessageBox.Show("Inicio do arquivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // -------- Avançar para o proximo perfil ----------
        private void Proximo_Click(object sender, EventArgs e)
        {
            if (atual < 0)
            {
                atual++;
                ShowDados();
            }
            else
            {
                MessageBox.Show("Fim do arquivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ------- Cancelar Criação/Edit de Perfil ----------
        private void Cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarEdit();
            ShowDados();
        }

        // -------- Sair do Painel de Busca ---------
        private void VoltarSearch_Click(object sender, EventArgs e)
        {
            PainelSearch.Visible = false;
        }

        // -------- Procurar Paciente pelo Nome ----------
        private void Procurar_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < AquariusMenu.contPacientes; x++) 
            {
                if (AquariusMenu.Pacientes[x].nome.IndexOf(Name) >= 0)
                {
                    atual = x;
                    ShowDados();
                    break;
                }
                if (x >= AquariusMenu.contPacientes)
                {
                    MessageBox.Show(SearchNome, "Não encontrado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                PainelSearch.Visible = false;
            }
        }

        // ----------------------- PACIENTE PREVIEW E PRINT ------------------------------------------
        private void RelatorioPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO PACIENTE" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + CodPaciente + (char)10 + (char)10;
            Dados = Dados + "Nome: " + NomePaciente + (char)10 + (char)10;
            Dados = Dados + "Descrição: " + DescPaciente + (char)10 + (char)10;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        // ---------------------------------------------
        //           Não utilizado - AKA Lixo
        // ---------------------------------------------
        private void PacientePreview_Load(object sender, EventArgs e)
        {
            // Preview Imprimir
        }
        private void CodPaciente_TextChanged(object sender, EventArgs e)
        {
            // Text box do Codigo Paciente
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Text box da Descrição do Paciente
        }
        private void CadPacientes_Load(object sender, EventArgs e)
        {
           // Main CadPacientes
        }
    }
}
