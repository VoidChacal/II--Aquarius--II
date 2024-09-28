namespace Aquarius
{
    partial class CadPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPacientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NomePaciente = new System.Windows.Forms.RichTextBox();
            this.FotoPaciente = new System.Windows.Forms.PictureBox();
            this.DescPaciente = new System.Windows.Forms.RichTextBox();
            this.CodPaciente = new System.Windows.Forms.RichTextBox();
            this.Anterior = new System.Windows.Forms.Button();
            this.Proximo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.Imprimir = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnvFoto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PainelSearch = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchNome = new System.Windows.Forms.RichTextBox();
            this.Procurar = new System.Windows.Forms.Button();
            this.VoltarSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PacientePreview = new System.Windows.Forms.PrintPreviewDialog();
            this.PacientePrint = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PainelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.groupBox1.Controls.Add(this.CodPaciente);
            this.groupBox1.Controls.Add(this.PainelSearch);
            this.groupBox1.Controls.Add(this.EnvFoto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Voltar);
            this.groupBox1.Controls.Add(this.Imprimir);
            this.groupBox1.Controls.Add(this.Pesquisa);
            this.groupBox1.Controls.Add(this.Excluir);
            this.groupBox1.Controls.Add(this.Alterar);
            this.groupBox1.Controls.Add(this.Novo);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.Salvar);
            this.groupBox1.Controls.Add(this.Proximo);
            this.groupBox1.Controls.Add(this.Anterior);
            this.groupBox1.Controls.Add(this.DescPaciente);
            this.groupBox1.Controls.Add(this.FotoPaciente);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.NomePaciente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pacientes";
            // 
            // NomePaciente
            // 
            this.NomePaciente.Location = new System.Drawing.Point(95, 121);
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.Size = new System.Drawing.Size(395, 25);
            this.NomePaciente.TabIndex = 1;
            this.NomePaciente.Text = "";
            // 
            // FotoPaciente
            // 
            this.FotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoPaciente.Location = new System.Drawing.Point(541, 30);
            this.FotoPaciente.Name = "FotoPaciente";
            this.FotoPaciente.Size = new System.Drawing.Size(195, 153);
            this.FotoPaciente.TabIndex = 2;
            this.FotoPaciente.TabStop = false;
            // 
            // DescPaciente
            // 
            this.DescPaciente.Location = new System.Drawing.Point(37, 223);
            this.DescPaciente.Name = "DescPaciente";
            this.DescPaciente.Size = new System.Drawing.Size(421, 167);
            this.DescPaciente.TabIndex = 3;
            this.DescPaciente.Text = "";
            this.DescPaciente.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // CodPaciente
            // 
            this.CodPaciente.Location = new System.Drawing.Point(205, 50);
            this.CodPaciente.Name = "CodPaciente";
            this.CodPaciente.Size = new System.Drawing.Size(107, 27);
            this.CodPaciente.TabIndex = 4;
            this.CodPaciente.Text = "";
            this.CodPaciente.TextChanged += new System.EventHandler(this.CodPaciente_TextChanged);
            // 
            // Anterior
            // 
            this.Anterior.ForeColor = System.Drawing.Color.Black;
            this.Anterior.Location = new System.Drawing.Point(225, 488);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(114, 40);
            this.Anterior.TabIndex = 5;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Proximo
            // 
            this.Proximo.ForeColor = System.Drawing.Color.Black;
            this.Proximo.Location = new System.Drawing.Point(356, 488);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(114, 40);
            this.Proximo.TabIndex = 6;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // Salvar
            // 
            this.Salvar.ForeColor = System.Drawing.Color.Black;
            this.Salvar.Location = new System.Drawing.Point(225, 550);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(114, 40);
            this.Salvar.TabIndex = 7;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(356, 550);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(114, 40);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Novo
            // 
            this.Novo.ForeColor = System.Drawing.Color.Black;
            this.Novo.Location = new System.Drawing.Point(501, 488);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(114, 40);
            this.Novo.TabIndex = 9;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Alterar
            // 
            this.Alterar.ForeColor = System.Drawing.Color.Black;
            this.Alterar.Location = new System.Drawing.Point(636, 488);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(114, 40);
            this.Alterar.TabIndex = 10;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.ForeColor = System.Drawing.Color.Black;
            this.Excluir.Location = new System.Drawing.Point(773, 488);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(114, 40);
            this.Excluir.TabIndex = 11;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Pesquisa
            // 
            this.Pesquisa.ForeColor = System.Drawing.Color.Black;
            this.Pesquisa.Location = new System.Drawing.Point(501, 550);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(114, 40);
            this.Pesquisa.TabIndex = 12;
            this.Pesquisa.Text = "Pesquisa";
            this.Pesquisa.UseVisualStyleBackColor = true;
            // 
            // Imprimir
            // 
            this.Imprimir.ForeColor = System.Drawing.Color.Black;
            this.Imprimir.Location = new System.Drawing.Point(636, 550);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(114, 40);
            this.Imprimir.TabIndex = 13;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.button9_Click);
            // 
            // Voltar
            // 
            this.Voltar.ForeColor = System.Drawing.Color.Black;
            this.Voltar.Location = new System.Drawing.Point(773, 550);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(114, 40);
            this.Voltar.TabIndex = 14;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo do Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descrição do paciente:";
            // 
            // EnvFoto
            // 
            this.EnvFoto.ForeColor = System.Drawing.Color.Black;
            this.EnvFoto.Location = new System.Drawing.Point(562, 195);
            this.EnvFoto.Name = "EnvFoto";
            this.EnvFoto.Size = new System.Drawing.Size(155, 35);
            this.EnvFoto.TabIndex = 18;
            this.EnvFoto.Text = "Enviar foto";
            this.EnvFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(792, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // PainelSearch
            // 
            this.PainelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.PainelSearch.Controls.Add(this.label5);
            this.PainelSearch.Controls.Add(this.VoltarSearch);
            this.PainelSearch.Controls.Add(this.Procurar);
            this.PainelSearch.Controls.Add(this.SearchNome);
            this.PainelSearch.Controls.Add(this.label4);
            this.PainelSearch.Location = new System.Drawing.Point(182, 107);
            this.PainelSearch.Name = "PainelSearch";
            this.PainelSearch.Size = new System.Drawing.Size(705, 375);
            this.PainelSearch.TabIndex = 20;
            this.PainelSearch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // SearchNome
            // 
            this.SearchNome.Location = new System.Drawing.Point(143, 115);
            this.SearchNome.Name = "SearchNome";
            this.SearchNome.Size = new System.Drawing.Size(462, 34);
            this.SearchNome.TabIndex = 1;
            this.SearchNome.Text = "";
            // 
            // Procurar
            // 
            this.Procurar.ForeColor = System.Drawing.Color.Black;
            this.Procurar.Location = new System.Drawing.Point(137, 272);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(114, 40);
            this.Procurar.TabIndex = 2;
            this.Procurar.Text = "Procurar";
            this.Procurar.UseVisualStyleBackColor = true;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // VoltarSearch
            // 
            this.VoltarSearch.ForeColor = System.Drawing.Color.Black;
            this.VoltarSearch.Location = new System.Drawing.Point(440, 272);
            this.VoltarSearch.Name = "VoltarSearch";
            this.VoltarSearch.Size = new System.Drawing.Size(114, 40);
            this.VoltarSearch.TabIndex = 3;
            this.VoltarSearch.Text = "Voltar";
            this.VoltarSearch.UseVisualStyleBackColor = true;
            this.VoltarSearch.Click += new System.EventHandler(this.VoltarSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Painel de busca";
            // 
            // PacientePreview
            // 
            this.PacientePreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PacientePreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PacientePreview.ClientSize = new System.Drawing.Size(400, 300);
            this.PacientePreview.Enabled = true;
            this.PacientePreview.Icon = ((System.Drawing.Icon)(resources.GetObject("PacientePreview.Icon")));
            this.PacientePreview.Name = "PacientePreview";
            this.PacientePreview.Visible = false;
            this.PacientePreview.Load += new System.EventHandler(this.PacientePreview_Load);
            // 
            // PacientePrint
            // 
            this.PacientePrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.RelatorioPrint_PrintPage);
            // 
            // CadPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1153, 645);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadPacientes";
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.CadPacientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PainelSearch.ResumeLayout(false);
            this.PainelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox FotoPaciente;
        private System.Windows.Forms.RichTextBox NomePaciente;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.RichTextBox CodPaciente;
        private System.Windows.Forms.RichTextBox DescPaciente;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnvFoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PainelSearch;
        private System.Windows.Forms.RichTextBox SearchNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button VoltarSearch;
        private System.Windows.Forms.Button Procurar;
        private System.Windows.Forms.PrintPreviewDialog PacientePreview;
        private System.Drawing.Printing.PrintDocument PacientePrint;
    }
}