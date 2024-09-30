namespace Aquarius
{
    partial class AquariusMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AquariusMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.RelPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RelatorioPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.RelatorioPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(173)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pacientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelPaciente
            // 
            this.RelPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(173)))));
            this.RelPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(173)))));
            this.RelPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelPaciente.Location = new System.Drawing.Point(429, 250);
            this.RelPaciente.Name = "RelPaciente";
            this.RelPaciente.Size = new System.Drawing.Size(114, 40);
            this.RelPaciente.TabIndex = 1;
            this.RelPaciente.Text = "Pacientes";
            this.RelPaciente.UseVisualStyleBackColor = false;
            this.RelPaciente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Relatorios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-19, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(644, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RelatorioPreview
            // 
            this.RelatorioPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.RelatorioPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.RelatorioPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.RelatorioPreview.Document = this.RelatorioPrint;
            this.RelatorioPreview.Enabled = true;
            this.RelatorioPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("RelatorioPreview.Icon")));
            this.RelatorioPreview.Name = "RelatorioPreview";
            this.RelatorioPreview.Visible = false;
            this.RelatorioPreview.Load += new System.EventHandler(this.PacientePreview_Load);
            // 
            // RelatorioPrint
            // 
            this.RelatorioPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.RelatorioPrint_PrintPage);
            // 
            // AquariusMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelPaciente);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AquariusMenu";
            this.Text = "Aquarius";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RelPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PrintPreviewDialog RelatorioPreview;
        private System.Drawing.Printing.PrintDocument RelatorioPrint;
    }
}

