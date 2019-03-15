namespace ProjetoMicroOndas
{
    partial class MicroOndas
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
            this.components = new System.ComponentModel.Container();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeDoPrograma = new System.Windows.Forms.Label();
            this.txtStringDeEntrada = new System.Windows.Forms.TextBox();
            this.brnInicioRapido = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultarPrograma = new System.Windows.Forms.Button();
            this.btnPrograma = new System.Windows.Forms.Button();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblAquecida = new System.Windows.Forms.Label();
            this.lblTextoStringFinal1 = new System.Windows.Forms.Label();
            this.lblTextoStringFinal2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbListaDeProgramas = new System.Windows.Forms.ComboBox();
            this.lblListaDeProgramas = new System.Windows.Forms.Label();
            this.gbConsultaProgramas = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.btnIniciarAquecimento = new System.Windows.Forms.Button();
            this.boxInstrucaoDeUso = new System.Windows.Forms.RichTextBox();
            this.gbResultadoPesquisaPrograma = new System.Windows.Forms.GroupBox();
            this.txtPotenciaConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempoConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeDoPrograma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbConsultaProgramas.SuspendLayout();
            this.gbResultadoPesquisaPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(22, 79);
            this.txtTempo.Multiline = true;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(156, 32);
            this.txtTempo.TabIndex = 0;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(23, 260);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(156, 23);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Iniciar Aquecimento";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeDoPrograma);
            this.groupBox1.Controls.Add(this.txtStringDeEntrada);
            this.groupBox1.Controls.Add(this.brnInicioRapido);
            this.groupBox1.Controls.Add(this.btnInicio);
            this.groupBox1.Controls.Add(this.btnConsultarPrograma);
            this.groupBox1.Controls.Add(this.btnPrograma);
            this.groupBox1.Controls.Add(this.lblPotencia);
            this.groupBox1.Controls.Add(this.txtPotencia);
            this.groupBox1.Controls.Add(this.lblTempo);
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 401);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblNomeDoPrograma
            // 
            this.lblNomeDoPrograma.AutoSize = true;
            this.lblNomeDoPrograma.Location = new System.Drawing.Point(19, 15);
            this.lblNomeDoPrograma.Name = "lblNomeDoPrograma";
            this.lblNomeDoPrograma.Size = new System.Drawing.Size(98, 13);
            this.lblNomeDoPrograma.TabIndex = 17;
            this.lblNomeDoPrograma.Text = "Nome do Programa";
            // 
            // txtStringDeEntrada
            // 
            this.txtStringDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringDeEntrada.Location = new System.Drawing.Point(21, 28);
            this.txtStringDeEntrada.Multiline = true;
            this.txtStringDeEntrada.Name = "txtStringDeEntrada";
            this.txtStringDeEntrada.Size = new System.Drawing.Size(156, 32);
            this.txtStringDeEntrada.TabIndex = 16;
            this.txtStringDeEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // brnInicioRapido
            // 
            this.brnInicioRapido.Location = new System.Drawing.Point(23, 231);
            this.brnInicioRapido.Name = "brnInicioRapido";
            this.brnInicioRapido.Size = new System.Drawing.Size(155, 23);
            this.brnInicioRapido.TabIndex = 15;
            this.brnInicioRapido.Text = "Início Rápido";
            this.brnInicioRapido.UseVisualStyleBackColor = true;
            this.brnInicioRapido.Click += new System.EventHandler(this.brnInicioRapido_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(11, 368);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(199, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultarPrograma
            // 
            this.btnConsultarPrograma.Location = new System.Drawing.Point(23, 202);
            this.btnConsultarPrograma.Name = "btnConsultarPrograma";
            this.btnConsultarPrograma.Size = new System.Drawing.Size(154, 23);
            this.btnConsultarPrograma.TabIndex = 5;
            this.btnConsultarPrograma.Text = "Consultar Programa";
            this.btnConsultarPrograma.UseVisualStyleBackColor = true;
            this.btnConsultarPrograma.Click += new System.EventHandler(this.btnConsultarPrograma_Click);
            // 
            // btnPrograma
            // 
            this.btnPrograma.Location = new System.Drawing.Point(23, 173);
            this.btnPrograma.Name = "btnPrograma";
            this.btnPrograma.Size = new System.Drawing.Size(154, 23);
            this.btnPrograma.TabIndex = 4;
            this.btnPrograma.Text = "Programa Automático";
            this.btnPrograma.UseVisualStyleBackColor = true;
            this.btnPrograma.Click += new System.EventHandler(this.btnPrograma_Click);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(20, 116);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(129, 13);
            this.lblPotencia.TabIndex = 3;
            this.lblPotencia.Text = "Potência do Aquecimento";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotencia.Location = new System.Drawing.Point(22, 129);
            this.txtPotencia.Multiline = true;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(156, 32);
            this.txtPotencia.TabIndex = 1;
            this.txtPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(20, 66);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(120, 13);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "Tempo de Aquecimento";
            // 
            // lblAquecida
            // 
            this.lblAquecida.AutoSize = true;
            this.lblAquecida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquecida.ForeColor = System.Drawing.Color.Blue;
            this.lblAquecida.Location = new System.Drawing.Point(12, 9);
            this.lblAquecida.Name = "lblAquecida";
            this.lblAquecida.Size = new System.Drawing.Size(0, 20);
            this.lblAquecida.TabIndex = 18;
            this.lblAquecida.Visible = false;
            // 
            // lblTextoStringFinal1
            // 
            this.lblTextoStringFinal1.AutoSize = true;
            this.lblTextoStringFinal1.Location = new System.Drawing.Point(12, 439);
            this.lblTextoStringFinal1.Name = "lblTextoStringFinal1";
            this.lblTextoStringFinal1.Size = new System.Drawing.Size(35, 13);
            this.lblTextoStringFinal1.TabIndex = 19;
            this.lblTextoStringFinal1.Text = "label2";
            this.lblTextoStringFinal1.Visible = false;
            // 
            // lblTextoStringFinal2
            // 
            this.lblTextoStringFinal2.AutoSize = true;
            this.lblTextoStringFinal2.Location = new System.Drawing.Point(12, 458);
            this.lblTextoStringFinal2.Name = "lblTextoStringFinal2";
            this.lblTextoStringFinal2.Size = new System.Drawing.Size(35, 13);
            this.lblTextoStringFinal2.TabIndex = 20;
            this.lblTextoStringFinal2.Text = "label1";
            this.lblTextoStringFinal2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbListaDeProgramas
            // 
            this.cmbListaDeProgramas.FormattingEnabled = true;
            this.cmbListaDeProgramas.Location = new System.Drawing.Point(9, 32);
            this.cmbListaDeProgramas.Name = "cmbListaDeProgramas";
            this.cmbListaDeProgramas.Size = new System.Drawing.Size(201, 21);
            this.cmbListaDeProgramas.TabIndex = 21;
            this.cmbListaDeProgramas.Text = "Selecione";
            this.cmbListaDeProgramas.SelectedIndexChanged += new System.EventHandler(this.cmbListaDeProgramas_SelectedIndexChanged);
            // 
            // lblListaDeProgramas
            // 
            this.lblListaDeProgramas.AutoSize = true;
            this.lblListaDeProgramas.Location = new System.Drawing.Point(6, 19);
            this.lblListaDeProgramas.Name = "lblListaDeProgramas";
            this.lblListaDeProgramas.Size = new System.Drawing.Size(97, 13);
            this.lblListaDeProgramas.TabIndex = 22;
            this.lblListaDeProgramas.Text = "Lista de Programas";
            // 
            // gbConsultaProgramas
            // 
            this.gbConsultaProgramas.Controls.Add(this.btnSalvar);
            this.gbConsultaProgramas.Controls.Add(this.btnAdicionarPrograma);
            this.gbConsultaProgramas.Controls.Add(this.btnIniciarAquecimento);
            this.gbConsultaProgramas.Controls.Add(this.boxInstrucaoDeUso);
            this.gbConsultaProgramas.Controls.Add(this.gbResultadoPesquisaPrograma);
            this.gbConsultaProgramas.Controls.Add(this.lblListaDeProgramas);
            this.gbConsultaProgramas.Controls.Add(this.btnFechar);
            this.gbConsultaProgramas.Controls.Add(this.cmbListaDeProgramas);
            this.gbConsultaProgramas.Location = new System.Drawing.Point(218, 32);
            this.gbConsultaProgramas.Name = "gbConsultaProgramas";
            this.gbConsultaProgramas.Size = new System.Drawing.Size(220, 401);
            this.gbConsultaProgramas.TabIndex = 23;
            this.gbConsultaProgramas.TabStop = false;
            this.gbConsultaProgramas.Text = "Consulta Programas";
            this.gbConsultaProgramas.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(112, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 23);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(11, 316);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(98, 23);
            this.btnAdicionarPrograma.TabIndex = 26;
            this.btnAdicionarPrograma.Text = "Adic. Programa";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.btnAdicionarPrograma_Click);
            // 
            // btnIniciarAquecimento
            // 
            this.btnIniciarAquecimento.Location = new System.Drawing.Point(11, 342);
            this.btnIniciarAquecimento.Name = "btnIniciarAquecimento";
            this.btnIniciarAquecimento.Size = new System.Drawing.Size(199, 23);
            this.btnIniciarAquecimento.TabIndex = 25;
            this.btnIniciarAquecimento.Text = "Iniciar Programa";
            this.btnIniciarAquecimento.UseVisualStyleBackColor = true;
            this.btnIniciarAquecimento.Click += new System.EventHandler(this.btnIniciarAquecimento_Click);
            // 
            // boxInstrucaoDeUso
            // 
            this.boxInstrucaoDeUso.Enabled = false;
            this.boxInstrucaoDeUso.Location = new System.Drawing.Point(18, 186);
            this.boxInstrucaoDeUso.Name = "boxInstrucaoDeUso";
            this.boxInstrucaoDeUso.Size = new System.Drawing.Size(183, 116);
            this.boxInstrucaoDeUso.TabIndex = 24;
            this.boxInstrucaoDeUso.Text = "";
            // 
            // gbResultadoPesquisaPrograma
            // 
            this.gbResultadoPesquisaPrograma.Controls.Add(this.txtPotenciaConsulta);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.label5);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.txtTempoConsulta);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.label4);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.label3);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.txtDescricao);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.label2);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.txtNomeDoPrograma);
            this.gbResultadoPesquisaPrograma.Controls.Add(this.label1);
            this.gbResultadoPesquisaPrograma.Location = new System.Drawing.Point(9, 57);
            this.gbResultadoPesquisaPrograma.Name = "gbResultadoPesquisaPrograma";
            this.gbResultadoPesquisaPrograma.Size = new System.Drawing.Size(201, 259);
            this.gbResultadoPesquisaPrograma.TabIndex = 23;
            this.gbResultadoPesquisaPrograma.TabStop = false;
            this.gbResultadoPesquisaPrograma.Visible = false;
            // 
            // txtPotenciaConsulta
            // 
            this.txtPotenciaConsulta.Enabled = false;
            this.txtPotenciaConsulta.Location = new System.Drawing.Point(107, 91);
            this.txtPotenciaConsulta.Name = "txtPotenciaConsulta";
            this.txtPotenciaConsulta.Size = new System.Drawing.Size(85, 20);
            this.txtPotenciaConsulta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Potência:";
            // 
            // txtTempoConsulta
            // 
            this.txtTempoConsulta.Enabled = false;
            this.txtTempoConsulta.Location = new System.Drawing.Point(107, 65);
            this.txtTempoConsulta.Name = "txtTempoConsulta";
            this.txtTempoConsulta.Size = new System.Drawing.Size(85, 20);
            this.txtTempoConsulta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instruções de Uso:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(107, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(85, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtNomeDoPrograma
            // 
            this.txtNomeDoPrograma.Enabled = false;
            this.txtNomeDoPrograma.Location = new System.Drawing.Point(107, 13);
            this.txtNomeDoPrograma.Name = "txtNomeDoPrograma";
            this.txtNomeDoPrograma.Size = new System.Drawing.Size(85, 20);
            this.txtNomeDoPrograma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Programa:";
            // 
            // MicroOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 492);
            this.Controls.Add(this.gbConsultaProgramas);
            this.Controls.Add(this.lblTextoStringFinal2);
            this.Controls.Add(this.lblTextoStringFinal1);
            this.Controls.Add(this.lblAquecida);
            this.Controls.Add(this.groupBox1);
            this.Name = "MicroOndas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MicroOndas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConsultaProgramas.ResumeLayout(false);
            this.gbConsultaProgramas.PerformLayout();
            this.gbResultadoPesquisaPrograma.ResumeLayout(false);
            this.gbResultadoPesquisaPrograma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultarPrograma;
        private System.Windows.Forms.Button btnPrograma;
        private System.Windows.Forms.Button brnInicioRapido;
        private System.Windows.Forms.Label lblNomeDoPrograma;
        private System.Windows.Forms.TextBox txtStringDeEntrada;
        private System.Windows.Forms.Label lblAquecida;
        private System.Windows.Forms.Label lblTextoStringFinal1;
        private System.Windows.Forms.Label lblTextoStringFinal2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbListaDeProgramas;
        private System.Windows.Forms.Label lblListaDeProgramas;
        private System.Windows.Forms.GroupBox gbConsultaProgramas;
        private System.Windows.Forms.GroupBox gbResultadoPesquisaPrograma;
        private System.Windows.Forms.TextBox txtTempoConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDoPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPotenciaConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox boxInstrucaoDeUso;
        private System.Windows.Forms.Button btnIniciarAquecimento;
        private System.Windows.Forms.Button btnAdicionarPrograma;
        private System.Windows.Forms.Button btnSalvar;
    }
}

