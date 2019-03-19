using neMicroOndas;
using peMicroOndas.TO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMicroOndas
{
    public partial class MicroOndas : Form
    {
        public int cont = 1;
        public string stringIncremental;
        public string nPrograma = "";
        public string nDescricao = "";
        public string nTempo = "";
        public string nPotencia = "";
        public string nInstrucoesUso = "";
        public string ehArquivoTxt = "";
        public string stringDoArquivo = "";

        public List<TOProgramas> listaDosProgramas = new List<TOProgramas>();
        StringEntradaEventArgs args = new StringEntradaEventArgs();

        public MicroOndas()
        {
            InitializeComponent();

            listaDosProgramas.Add(new TOProgramas { Programa = "FEIJAO", Descricao = "Aquecer feijão", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Feijão, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "55", Potencia = "6" });
            listaDosProgramas.Add(new TOProgramas { Programa = "ARROZ", Descricao = "Aquecer Arroz", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Arroz, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "45", Potencia = "5" });
            listaDosProgramas.Add(new TOProgramas { Programa = "CARNE", Descricao = "Aquecer Carne", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Carne, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "35", Potencia = "4" });
            listaDosProgramas.Add(new TOProgramas { Programa = "LEITE", Descricao = "Aquecer Leite", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Leite, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "25", Potencia = "3" });
            listaDosProgramas.Add(new TOProgramas { Programa = "PAO", Descricao = "Aquecer Pão", InstrucoesUso = "Este programa aquece o alimento de acordo com o tempo e potência definidos. Para inicar o aquecimento do Pão, clique no botão 'Iniciar Aquecimento' e aguarde decorrer o tempo. Após isso, retire com cuidado o alimento do interior do micro-ondas.", Tempo = "15", Potencia = "2" });

            gbConsultaProgramas.Height = 65;

            this.Evento += MensagemEvento;
        }


        /// <summary>
        /// Ação do botão "Início Rápido" de aquecimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnInicioRapido_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;

            gbConsultaProgramas.Visible = false;

            txtTempo.Text = "30";
            txtPotencia.Text = "8";

            cont = int.Parse(txtTempo.Text);
            stringIncremental = ".";

            timer1.Interval = int.Parse(txtTempo.Text);
            timer1.Start();
        }


        /// <summary>
        /// Ação do botão "Iniciar Aquecimento"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            gbConsultaProgramas.Visible = false;

            var tempo = txtTempo.Text;
            var potencia = txtPotencia.Text;

            //Realiza as validações das regras de negócio atribuídas para o campo
            ValidaTempo validaTempo = new ValidaTempo();
            var retornoTempo = validaTempo.tempoCozimento(tempo);


            if (retornoTempo == "")
            {
                txtTempo.Text = tempo;
                cont = int.Parse(txtTempo.Text);
            }
            else
            {
                //Lança a exceção
                args.textoEntrada = retornoTempo;
                VerificaEvento(args);
            }

            //Verifica se o campo potência possui valor inserido
            if (potencia != "")
            {
                //Realiza as validações das regras de negócio atribuídas para o campo
                ValidaPotencia validaPotencia = new ValidaPotencia();
                var retornoPotencia = validaPotencia.potenciaAquecimento(potencia);

                if (retornoPotencia == "")
                {
                    txtPotencia.Text = potencia;
                }
                else
                {
                    //Lança a exceção
                    args.textoEntrada = retornoPotencia;
                    VerificaEvento(args);
                }
            }
            else
            {
                if (txtTempo.Text != "")
                {
                    //Atribui um valor padrão para a poteência
                    txtPotencia.Text = "10";
                }
            }

            stringIncremental = ".";

            //Chama o timer para atualizar o campo de entrada (string)
            if (txtTempo.Text != "")
            {
                timer1.Interval = int.Parse(txtTempo.Text);
                timer1.Start();
                timer1.Start();
            }
        }


        /// <summary>
        /// Ação do botão "Iniciar Programa"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrograma_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            txtTempo.Text = "";
            txtPotencia.Text = "";


            var filePath = txtStringDeEntrada.Text;

            //Verificar se a string informada corresponde à um diretório válido
            if (File.Exists(filePath))
            {
                var fileContent = string.Empty;


                using (StreamReader reader = new StreamReader(filePath))
                {
                    fileContent = reader.ReadToEnd();
                    stringDoArquivo = fileContent;
                    reader.Close();
                }

                var retorno = listaDosProgramas.Where(x => x.Programa.ToUpper() == stringDoArquivo.ToUpper()).FirstOrDefault();

                if (retorno != null)
                {
                    ehArquivoTxt = "sim";

                    txtTempo.Text = retorno.Tempo;
                    txtPotencia.Text = retorno.Potencia;

                    cont = int.Parse(txtTempo.Text);
                    stringIncremental = stringDoArquivo.Substring(0, 1);

                    //Inicia o timer de atualização dos valores
                    timer1.Interval = int.Parse(txtTempo.Text);
                    timer1.Start();
                }
                else
                {
                    args.textoEntrada = "Alimento incompatível com o programa!";
                    VerificaEvento(args);
                }
                
            }
            else
            {
                var retorno = listaDosProgramas.Where(x => x.Programa.ToUpper() == txtStringDeEntrada.Text.ToUpper()).FirstOrDefault();

                if (retorno == null)
                {
                    args.textoEntrada = "Alimento incompatível com o programa!";
                    VerificaEvento(args);
                }
                else
                {

                    txtTempo.Text = retorno.Tempo;
                    txtPotencia.Text = retorno.Potencia;

                    cont = int.Parse(txtTempo.Text);
                    stringIncremental = txtStringDeEntrada.Text.Substring(0, 1);

                    //Inicia o timer de atualização dos valores
                    Timer timer = new Timer();
                    timer1.Interval = int.Parse(txtTempo.Text);
                    timer1.Start();
                }
            }
        }


        /// <summary>
        /// Action do botão 'Consultar Programa'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarPrograma_Click(object sender, EventArgs e)
        {
            btnConsultarPrograma.Enabled = false;
            cmbListaDeProgramas.Enabled = true;
            lblAquecida.Visible = false;
            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";

            var programas = listaDosProgramas;

            ////carrega os programas no comboBox
            for (int i = 0; i < programas.Count; i++)
            {
                cmbListaDeProgramas.Items.Add(programas[i].Programa.ToUpper());
            }

            gbConsultaProgramas.Visible = true;
        }


        /// <summary>
        /// Action do comboBox que lista os programas disponíveis (fica dentro groupBox 'gbConsultaProgramas')
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbListaDeProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";

            gbConsultaProgramas.Height = 400;
            gbResultadoPesquisaPrograma.Visible = true;
            btnIniciarAquecimento.Enabled = true;

            var programaSelecionado = cmbListaDeProgramas.SelectedItem.ToString().ToUpper();

            var retorno = listaDosProgramas.Where(x => x.Programa.ToUpper() == programaSelecionado).FirstOrDefault();

            //carrega no textBox os valores recuperados
            txtNomeDoPrograma.Text = retorno.Programa;
            txtDescricao.Text = retorno.Descricao;
            txtTempoConsulta.Text = retorno.Tempo;
            txtPotenciaConsulta.Text = retorno.Potencia;
            boxInstrucaoDeUso.Text = retorno.InstrucoesUso;
        }


        /// <summary>
        /// Ação do botão 'Iniciar Aquecimento' dentro do groupBox 'gbConsultaProgramas' apresentado quando acionado o botão 'Consultar Programa'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarAquecimento_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";

            var retorno = listaDosProgramas.Where(x => x.Programa.ToUpper() == txtNomeDoPrograma.Text.ToUpper()).FirstOrDefault();

            //carrega no textBox os valores recuperados
            txtStringDeEntrada.Text = retorno.Programa;
            txtTempo.Text = retorno.Tempo;
            txtPotencia.Text = retorno.Potencia;

            cont = int.Parse(txtTempo.Text);
            stringIncremental = txtStringDeEntrada.Text.Substring(0, 1);

            //Inicia o timer de atualização dos valores
            timer1.Interval = int.Parse(txtTempo.Text);
            timer1.Start();
        }


        /// <summary>
        /// Action do botão 'Adicionar Programa'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarPrograma_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";

            //Define valores para os campos a serem utilizados para adicionar um novo programa
            cmbListaDeProgramas.Text = "Selecione";
            cmbListaDeProgramas.Enabled = false;
            txtNomeDoPrograma.Text = "";
            txtDescricao.Text = "";
            txtTempoConsulta.Text = "";
            txtPotenciaConsulta.Text = "";
            boxInstrucaoDeUso.Text = "";
            txtNomeDoPrograma.Enabled = true;
            txtDescricao.Enabled = true;
            txtTempoConsulta.Enabled = true;
            txtPotenciaConsulta.Enabled = true;
            boxInstrucaoDeUso.Enabled = true;
            btnIniciarAquecimento.Enabled = false;
            btnAdicionarPrograma.Enabled = false;
            btnSalvar.Enabled = true;
        }


        /// <summary>
        /// Action do botão 'Salvar' que realiza a inclusão do novo programa do micro-ondas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            txtTempo.Text = "";
            txtPotencia.Text = "";

            var tempo = txtTempoConsulta.Text;
            var potencia = txtPotenciaConsulta.Text;

            ValidaTempo validaTempo = new ValidaTempo();
            var retornoTempo = validaTempo.tempoCozimento(tempo);

            if (retornoTempo != "")
            {
                //Lança a exceção
                args.textoEntrada = retornoTempo;
                VerificaEvento(args);
            }

            //Verifica se o campo potência possui valor inserido
            if (potencia != "")
            {
                //Realiza as validações das regras de negócio atribuídas para o campo
                ValidaPotencia validaPotencia = new ValidaPotencia();
                var retornoPotencia = validaPotencia.potenciaAquecimento(potencia);

                if (retornoPotencia != "")
                {
                    //Lança a exceção
                    args.textoEntrada = retornoPotencia;
                    VerificaEvento(args);
                }
            }
            else
            {
                if (retornoTempo == "")
                {
                    //Atribui um valor padrão para a poteência caso não seja informado
                    potencia = "10";

                }
            }

            if (tempo != "")
            {
                //Adiciona o novo item na lista de programas
                listaDosProgramas.Add(new TOProgramas
                {
                    Programa = txtNomeDoPrograma.Text,
                    Descricao = txtDescricao.Text,
                    Tempo = tempo,
                    Potencia = potencia,
                    InstrucoesUso = boxInstrucaoDeUso.Text
                });

                cmbListaDeProgramas.Items.Clear();
                listaDosProgramas.ForEach(x => cmbListaDeProgramas.Items.Add(x.Programa.ToUpper()));
                cmbListaDeProgramas.Enabled = true;
                txtNomeDoPrograma.Text = "";
                txtDescricao.Text = "";
                txtTempoConsulta.Text = "";
                txtPotenciaConsulta.Text = "";
                boxInstrucaoDeUso.Text = "";
                txtNomeDoPrograma.Enabled = false;
                txtDescricao.Enabled = false;
                txtTempoConsulta.Enabled = false;
                txtPotenciaConsulta.Enabled = false;
                boxInstrucaoDeUso.Enabled = false;
                btnSalvar.Enabled = false;
                btnAdicionarPrograma.Enabled = true;
                btnAdicionarPrograma.Enabled = true;
            }

            txtNomeDoPrograma.Text = "";
            txtDescricao.Text = "";
            txtTempoConsulta.Text = "";
            txtPotenciaConsulta.Text = "";
            boxInstrucaoDeUso.Text = "";
            txtNomeDoPrograma.Enabled = false;
            txtDescricao.Enabled = false;
            txtTempoConsulta.Enabled = false;
            txtPotenciaConsulta.Enabled = false;
            boxInstrucaoDeUso.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdicionarPrograma.Enabled = true;
            btnAdicionarPrograma.Enabled = true;
        }


        /// <summary>
        /// Apresentação do evento de conclusão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void MensagemEvento(object sender, StringEntradaEventArgs e)
        {
            MessageBox.Show(e.textoEntrada);
        }


        public event EventHandler<StringEntradaEventArgs> Evento;


        /// <summary>
        /// Valida o evento
        /// </summary>
        /// <param name="e"></param>
        protected virtual void VerificaEvento(StringEntradaEventArgs e)
        {
            EventHandler<StringEntradaEventArgs> handler = Evento;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        /// <summary>
        /// Action do botão 'Fechar'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            lblAquecida.Visible = false;
            gbConsultaProgramas.Height = 65;
            cmbListaDeProgramas.Items.Clear();
            gbConsultaProgramas.Visible = false;
            btnConsultarPrograma.Enabled = true;
            btnAdicionarPrograma.Enabled = true;
            btnSalvar.Enabled = false;
            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";
        }


        /// <summary>
        /// Action de pausa do aquecimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnPausar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (btnPausar.Text == "Pausar")
                {
                    PausaAquecimento();
                }
            }
            else
            {
                ReiniciarAquecimento();
            }
        }


        /// <summary>
        /// Action que para o aquecimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
                CancelarAquecimento();
                btnPausar.Text = "Pausar";
        }


        /// <summary>
        /// Task que dá um pause na aplicação
        /// </summary>
        /// <returns></returns>
        async Task PausaAquecimento()
        {
            btnPausar.Text = "Reiniciar";
            timer1.Stop();
            await Task.Delay(-1);
        }


        /// <summary>
        /// Task que reinicia o aquecimento
        /// </summary>
        /// <returns></returns>
        async Task ReiniciarAquecimento()
        {
            btnPausar.Text = "Pausar";
            timer1.Start();
        }


        /// <summary>
        /// Task que cancela o aquecimento
        /// </summary>
        /// <returns></returns>
        async Task CancelarAquecimento()
        {
            timer1.Stop();
            args.textoEntrada = "Aquecimento Cancelado!";
            VerificaEvento(args);

            txtStringDeEntrada.Text = "";
            txtTempo.Text = "";
            txtPotencia.Text = "";
        }


        /// <summary>
        /// Timer de execução do aquecimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont--;

            //Recebe os valores das variáveis para determinar a finalização do timer
            var totalTempo = int.Parse(txtTempo.Text);
            var totalPotencia = int.Parse(txtPotencia.Text);
            string[] pontoFinal = new string[totalPotencia];

            //Definindo o valor a ser inserido na string de entrada
            for (int i = 0; i < totalPotencia; i++)
            {
                pontoFinal[i] += ".";
            }

            //Validando a entrada para utilizar o streamwriter para gravar as informações no arquivo
            if (ehArquivoTxt == "sim")
            {
                var filePath = txtStringDeEntrada.Text;

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    //Incrementando valores à string de entrada
                    foreach (string line in pontoFinal)
                    {
                        sw.WriteLine(line);
                    }

                    string aquecida = "aquecida";

                    timer1.Stop();
                    lblAquecida.Text = aquecida;
                    lblAquecida.Visible = true;

                    cont = 0;
                }
            }
            else
            {
                txtStringDeEntrada.Text += stringIncremental;
            }

            //Verificar se está no momento de parar o timer e atribui os valores aos respectivos campos
            if (cont == 0)
            {
                string aquecida = "aquecida";

                timer1.Stop();
                lblAquecida.Text = aquecida;
                lblAquecida.Visible = true;

                cont = 0;

                txtTempo.Text = "";
                txtPotencia.Text = "";

                args.textoEntrada = txtStringDeEntrada.Text;
                VerificaEvento(args);
            }
        }


        public class StringEntradaEventArgs : EventArgs
        {
            public string textoEntrada { get; set; }
        }
    }
}

