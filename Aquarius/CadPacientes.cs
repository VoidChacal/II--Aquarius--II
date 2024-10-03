using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            SexoPaciente.Enabled = true;
            CPFPaciente.Enabled = true;
            RGPaciente.Enabled = true;
            DtEntPaciente.Enabled = true;
            Responsavel.Enabled = true;
            ContResponsavel.Enabled = true;
            IdadePaciente.Enabled = true; //Alterar?
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
            SexoPaciente.Enabled = false;
            CPFPaciente.Enabled = false;
            RGPaciente.Enabled = false;
            DtEntPaciente.Enabled = false;
            Responsavel.Enabled = false;
            ContResponsavel.Enabled = false;
            IdadePaciente.Enabled = false; //alterar?
        }

        private void TudoVazio()
        {
            NomePaciente.Text = "";
            DescPaciente.Text = "";
            SexoPaciente.Text = "";
            CPFPaciente.Text = "";
            RGPaciente.Text = "";
            DtEntPaciente.Text = "";
            Responsavel.Text = "";
            ContResponsavel.Text = "";
            IdadePaciente.Text = "";
        }

        // ------------ Mostrar Dados --------------
        private void ShowDados()
        {
            CodPaciente.Text = AquariusMenu.Pacientes[atual].codigo.ToString();
            NomePaciente.Text = AquariusMenu.Pacientes[atual].nome;
            IdadePaciente.Text = AquariusMenu.Pacientes[atual].idade;
            SexoPaciente.Text = AquariusMenu.Pacientes[atual].sexo;
            CPFPaciente.Text = AquariusMenu.Pacientes[atual].CPF;
            RGPaciente.Text = AquariusMenu.Pacientes[atual].RG;
            DtEntPaciente.Text = AquariusMenu.Pacientes[atual].DataEntrada;
            Responsavel.Text = AquariusMenu.Pacientes[atual].Responsavel;
            ContResponsavel.Text = AquariusMenu.Pacientes[atual].ContRespon;
            DescPaciente.Text = AquariusMenu.Pacientes[atual].descricao;
        }

        public CadPacientes()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Cad_formClosing);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            
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

        // ------------------ Idade do Paciente ---------------------
        private void IdadePaciente_TextChanged(object sender, EventArgs e)
        {
           // DateTime parsedDate;
           // if (!DateTime.TryParse(IdadePaciente.Text, out parsedDate))
           // {
           //     MessageBox.Show("Por favor, insira uma data válida no formato DD/MM/AAAA.");
           // }
        }

        // ------------------- CPF do Paciente -----------------------
        private void CPFPaciente_TextChanged(object sender, EventArgs e)
        {
            string cpf = CPFPaciente.Text.Replace(".", "").Replace("-", "");
            if (cpf.Length == 11 && long.TryParse(cpf, out _))
            {
                if (!ValidarCPF(cpf))
                {
                    MessageBox.Show("CPF inválido!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cpf.Length > 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Função para validar o CPF (simples exemplo, pode ser expandido)
        private bool ValidarCPF(string cpf)
        {
            // Coloque aqui a lógica de validação de CPF
            return true; // Retornar verdadeiro ou falso com base na validação
        }

        //------------------ RG do Paciente --------------------------
        private void RGPaciente_TextChanged(object sender, EventArgs e)
        {
            string rg = RGPaciente.Text.Replace(".", "").Replace("-", "");
            if (rg.Length >= 7 && rg.Length <= 9 && long.TryParse(rg, out _))
            {
                // RG entre 7 a 9 digitos
                // Validar RG se necessario
                // maskedTextBoxCPF.Mask = "000.000.000-00";
            }
            else if (rg.Length > 9)
            {
                MessageBox.Show("O RG deve conter entre 7 a 9 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                IdadePaciente.Text = ""; //Alterar
                SexoPaciente.Text = "";
                CPFPaciente.Text = "";
                RGPaciente.Text = "";
                DtEntPaciente.Text = "";
                Responsavel.Text = "";
                ContResponsavel.Text = "";
                // Imagem Novo
                HabilitaEdit();
                EditTipo = true;
            }
        }

        // -------- Salvar Perfil Criado/Edit ----------
        private void Salvar_Click(object sender, EventArgs e)
        {
            bool Verif = true;
            // MUDAR ESSA PORRA NÃO FUNCIONA MACACO
            String textDigUpper = SexoPaciente.Text;

            String textUpper = textDigUpper.ToUpper();

            // VERIFICA ESSA MERDA
            DateTime parsedDate;
            if (!DateTime.TryParse(IdadePaciente.Text, out parsedDate))
            {
                MessageBox.Show("Por favor, insira uma data válida no formato DD/MM/AAAA.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IdadePaciente.Text = "";
                HabilitaEdit();
                Verif = false;

            }
            if (textUpper != "M" && textUpper != "F") // <-- BLACK MONKEY
            {
                MessageBox.Show("Por favor, insira um sexo válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SexoPaciente.Text = "";
                Verif = false;
                // CRIAR UMA CLASS PARA APAGAR TUDO
            }
            
            // Tudo certo :)
            if (Verif == true)
            {
                if (EditTipo)
                {



                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].codigo = int.Parse(CodPaciente.Text);
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].nome = NomePaciente.Text;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].descricao = DescPaciente.Text;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].idade = IdadePaciente.Text; //Alterar?
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].sexo = textUpper;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].CPF = CPFPaciente.Text;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].RG = RGPaciente.Text;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].DataEntrada = DtEntPaciente.Text;
                    AquariusMenu.Pacientes[AquariusMenu.contPacientes].ContRespon = ContResponsavel.Text;
                    atual = AquariusMenu.contPacientes++;


                }
                else
                {



                    AquariusMenu.Pacientes[atual].nome = NomePaciente.Text;
                    AquariusMenu.Pacientes[atual].descricao = DescPaciente.Text;
                    AquariusMenu.Pacientes[atual].idade = IdadePaciente.Text; //Alterar?
                    AquariusMenu.Pacientes[atual].sexo = textUpper;
                    AquariusMenu.Pacientes[atual].CPF = CPFPaciente.Text;
                    AquariusMenu.Pacientes[atual].RG = RGPaciente.Text;
                    AquariusMenu.Pacientes[atual].DataEntrada = DtEntPaciente.Text;
                    AquariusMenu.Pacientes[atual].ContRespon = ContResponsavel.Text;

                }
                DesabilitarEdit();
            }
            
        }

        // --------- Excluir Perfil Atual ----------
        private void Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o perfil atual?", "Apagar Perfil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (AquariusMenu.contPacientes > 0)
                {
                    AquariusMenu.Pacientes[atual].nome = "";
                    AquariusMenu.Pacientes[atual].descricao = "";
                    AquariusMenu.Pacientes[atual].idade = ""; //Alterar?
                    AquariusMenu.Pacientes[atual].sexo = "";
                    AquariusMenu.Pacientes[atual].CPF = "";
                    AquariusMenu.Pacientes[atual].RG = "";
                    AquariusMenu.Pacientes[atual].DataEntrada = "";
                    AquariusMenu.Pacientes[atual].Responsavel = "";
                    AquariusMenu.Pacientes[atual].ContRespon = "";
                    ShowDados();
                }
            }
            else
            {
               // e.Cancel = True;
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
            if (atual < int.Parse(CodPaciente.Text))
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
            TudoVazio();
            ShowDados();
        }

        // -------- Sair do Painel de Busca ----------
        private void VoltarSearch_Click(object sender, EventArgs e)
        {
            PainelSearch.Visible = false;
        }

        // ---------- Botão do Painel --------------
        private void Pesquisa_Click(object sender, EventArgs e)
        {
            PainelSearch.Visible = true;
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

        // -------------- Enviar Foto btn -----------------
        private void EnvFoto_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    FotoPaciente.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar a imagem", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------ Botão de preview da impressão -------
        private void button9_Click(object sender, EventArgs e)
        {
            PacientePreview.ShowDialog();
        }

        // ----------------------- PACIENTE PREVIEW E PRINT ------------------------------------------
        private void RelatorioPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO PACIENTE" + (char)10 + (char)10;
            Dados = Dados + "-----------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + CodPaciente.Text + (char)10 + (char)10;
            Dados = Dados + "Nome: " + NomePaciente.Text + (char)10 + (char)10;
            Dados = Dados + "Idade: " + IdadePaciente.Text + (char)10 + (char)10;
            Dados = Dados + "Sexo: " + SexoPaciente.Text + (char)10 + (char)10;
            Dados = Dados + "CPF: " + CPFPaciente.Text + (char)10 + (char)10;
            Dados = Dados + "RG: " + RGPaciente.Text + (char)10 + (char)10;
            Dados = Dados + "Data de Entrada: " + DtEntPaciente.Text + (char)10 + (char)10;
            Dados = Dados + "Responsavel: " + Responsavel.Text + (char)10 + (char)10;
            Dados = Dados + "Contato do Responsavel: " + ContResponsavel.Text + (char)10 + (char)10;
            Dados = Dados + "--------------------------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "------------------------------------- Descrição do Paciente ------------------------" + (char)10 + (char)10;
            Dados = Dados + DescPaciente.Text + (char)10 + (char)10;

            Font fonte = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            Brush pincel = Brushes.Black;


            // Define o retângulo (dimensões) da área de impressão (ajustando para o tamanho da página)
            RectangleF areaImpressao = new RectangleF(50, 50, e.MarginBounds.Width - 50, e.MarginBounds.Height - 50);

            // Desenha o texto dentro da área definida, o que causa a quebra automática de linha
            objImpressao.DrawString(Dados, fonte, pincel, areaImpressao);


            if (FotoPaciente.Image != null)
            {
                // Definindo a posição e tamanho da imagem no documento ( x() y(), 100x100 pixels)
                Rectangle rect = new Rectangle(650, 10, 100, 100);

                // Desenhando a imagem no documento
                objImpressao.DrawImage(FotoPaciente.Image, rect);
            }
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

            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA32

           // Main CadPacientes
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Label Contato do Responsavel
        }

        private void SexoPaciente_TextChanged(object sender, EventArgs e)
        {
            String textDigUpper = SexoPaciente.Text;

            String textUpper = textDigUpper.ToUpper();
        }
    }
}
