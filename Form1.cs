using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace MeuPrograma
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos;

        Random random = new Random();

        List<int> listaRandom = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        //Clicar no botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                tabControl1.Visible = true;
            }

            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }

        //Quando o Form1 carregar
        private void Form1_Load(object sender, EventArgs e)
        {
            alunos = Aluno.ListarAlunos();
            dgvCadastro.DataSource = alunos;
        }

        //Carregará nos txtbox o que já tem no datagrid
        private void dgvCadastro_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                int indice = dgvCadastro.SelectedRows[0].Index;

                if (indice >= 0)
                {
                    txtMat.Text = Convert.ToString(alunos[indice].matricula);
                    txtNome.Text = alunos[indice].nome;
                    txtTel.Text = alunos[indice].telefone;
                    cmbEtapa.Text = alunos[indice].etapa;

                    if (cmbEtapa.Text == "1")
                    {
                        txtAtvArq.Enabled = true;
                        txtAtvLog.Enabled = true;
                        txtAtvSist.Enabled = true;

                        txtTrabArq.Enabled = true;
                        txtTrabLog.Enabled = true;
                        txtTrabSist.Enabled = true;

                        txtP1Arq.Enabled = true;
                        txtP1Log.Enabled = true;
                        txtP1Sist.Enabled = true;

                        txtP2Arq.Enabled = true;
                        txtP2Log.Enabled = true;
                        txtP2Sist.Enabled = true;

                        txtAtvBanco.Enabled = false;
                        txtAtvLing.Enabled = false;
                        txtAtvProg.Enabled = false;
                        txtAtvRedes.Enabled = false;

                        txtTrabBanco.Enabled = false;
                        txtTrabLing.Enabled = false;
                        txtTrabProg.Enabled = false;
                        txtTrabRedes.Enabled = false;

                        txtP1Banco.Enabled = false;
                        txtP1Ling.Enabled = false;
                        txtP1Prog.Enabled = false;
                        txtP1Redes.Enabled = false;

                        txtP2Banco.Enabled = false;
                        txtP2Ling.Enabled = false;
                        txtP2Prog.Enabled = false;
                        txtP2Redes.Enabled = false;

                        txtAtvAna.Enabled = false;
                        txtAtvDes.Enabled = false;
                        txtAtvEmp.Enabled = false;

                        txtTrabAna.Enabled = false;
                        txtTrabDes.Enabled = false;
                        txtTrabEmp.Enabled = false;

                        txtP1Ana.Enabled = false;
                        txtP1Des.Enabled = false;
                        txtP1Emp.Enabled = false;

                        txtP2Ana.Enabled = false;
                        txtP2Des.Enabled = false;
                        txtP2Emp.Enabled = false;

                        txtAtvArq.Text = Convert.ToString(alunos[indice].atvArquitetura);
                        txtAtvLog.Text = Convert.ToString(alunos[indice].atvLogica);
                        txtAtvSist.Text = Convert.ToString(alunos[indice].atvSistemas);

                        txtTrabArq.Text = Convert.ToString(alunos[indice].trabArquitetura);
                        txtTrabLog.Text = Convert.ToString(alunos[indice].trabLogica);
                        txtTrabSist.Text = Convert.ToString(alunos[indice].trabSistemas);

                        txtP1Arq.Text = Convert.ToString(alunos[indice].p1Arquitetura);
                        txtP1Log.Text = Convert.ToString(alunos[indice].p1Logica);
                        txtP1Sist.Text = Convert.ToString(alunos[indice].p1Sistemas);

                        txtP2Arq.Text = Convert.ToString(alunos[indice].p2Arquitetura);
                        txtP2Log.Text = Convert.ToString(alunos[indice].p2Logica);
                        txtP2Sist.Text = Convert.ToString(alunos[indice].p2Sistemas);
                        
                    }

                    if (cmbEtapa.Text == "2")
                    {
                        txtAtvArq.Enabled = false;
                        txtAtvLog.Enabled = false;
                        txtAtvSist.Enabled = false;

                        txtTrabArq.Enabled = false;
                        txtTrabLog.Enabled = false;
                        txtTrabSist.Enabled = false;

                        txtP1Arq.Enabled = false;
                        txtP1Log.Enabled = false;
                        txtP1Sist.Enabled = false;

                        txtP2Arq.Enabled = false;
                        txtP2Log.Enabled = false;
                        txtP2Sist.Enabled = false;

                        txtAtvBanco.Enabled = true;
                        txtAtvLing.Enabled = true;
                        txtAtvProg.Enabled = true;
                        txtAtvRedes.Enabled = true;

                        txtTrabBanco.Enabled = true;
                        txtTrabLing.Enabled = true;
                        txtTrabProg.Enabled = true;
                        txtTrabRedes.Enabled = true;

                        txtP1Banco.Enabled = true;
                        txtP1Ling.Enabled = true;
                        txtP1Prog.Enabled = true;
                        txtP1Redes.Enabled = true;

                        txtP2Banco.Enabled = true;
                        txtP2Ling.Enabled = true;
                        txtP2Prog.Enabled = true;
                        txtP2Redes.Enabled = true;

                        txtAtvAna.Enabled = false;
                        txtAtvDes.Enabled = false;
                        txtAtvEmp.Enabled = false;

                        txtTrabAna.Enabled = false;
                        txtTrabDes.Enabled = false;
                        txtTrabEmp.Enabled = false;

                        txtP1Ana.Enabled = false;
                        txtP1Des.Enabled = false;
                        txtP1Emp.Enabled = false;

                        txtP2Ana.Enabled = false;
                        txtP2Des.Enabled = false;
                        txtP2Emp.Enabled = false;

                        txtAtvBanco.Text = Convert.ToString(alunos[indice].atvBanco);
                        txtAtvLing.Text = Convert.ToString(alunos[indice].atvLinguagem);
                        txtAtvProg.Text = Convert.ToString(alunos[indice].atvProgramacao);
                        txtAtvRedes.Text = Convert.ToString(alunos[indice].atvRedes);

                        txtTrabBanco.Text = Convert.ToString(alunos[indice].trabBanco);
                        txtTrabLing.Text = Convert.ToString(alunos[indice].trabLinguagem);
                        txtTrabProg.Text = Convert.ToString(alunos[indice].trabProgramacao);
                        txtTrabRedes.Text = Convert.ToString(alunos[indice].trabRedes);

                        txtP1Banco.Text = Convert.ToString(alunos[indice].p1Banco);
                        txtP1Ling.Text = Convert.ToString(alunos[indice].p1Linguagem);
                        txtP1Prog.Text = Convert.ToString(alunos[indice].p1Programacao);
                        txtP1Redes.Text = Convert.ToString(alunos[indice].p1Redes);

                        txtP2Banco.Text = Convert.ToString(alunos[indice].p2Banco);
                        txtP2Ling.Text = Convert.ToString(alunos[indice].p2Linguagem);
                        txtP2Prog.Text = Convert.ToString(alunos[indice].p2Programacao);
                        txtP2Redes.Text = Convert.ToString(alunos[indice].p2Redes);
                        
                    }

                    if (cmbEtapa.Text == "3")
                    {
                        txtAtvArq.Enabled = false;
                        txtAtvLog.Enabled = false;
                        txtAtvSist.Enabled = false;

                        txtTrabArq.Enabled = false;
                        txtTrabLog.Enabled = false;
                        txtTrabSist.Enabled = false;

                        txtP1Arq.Enabled = false;
                        txtP1Log.Enabled = false;
                        txtP1Sist.Enabled = false;

                        txtP2Arq.Enabled = false;
                        txtP2Log.Enabled = false;
                        txtP2Sist.Enabled = false;

                        txtAtvBanco.Enabled = false;
                        txtAtvLing.Enabled = false;
                        txtAtvProg.Enabled = false;
                        txtAtvRedes.Enabled = false;

                        txtTrabBanco.Enabled = false;
                        txtTrabLing.Enabled = false;
                        txtTrabProg.Enabled = false;
                        txtTrabRedes.Enabled = false;

                        txtP1Banco.Enabled = false;
                        txtP1Ling.Enabled = false;
                        txtP1Prog.Enabled = false;
                        txtP1Redes.Enabled = false;

                        txtP2Banco.Enabled = false;
                        txtP2Ling.Enabled = false;
                        txtP2Prog.Enabled = false;
                        txtP2Redes.Enabled = false;

                        txtAtvAna.Enabled = true;
                        txtAtvDes.Enabled = true;
                        txtAtvEmp.Enabled = true;

                        txtTrabAna.Enabled = true;
                        txtTrabDes.Enabled = true;
                        txtTrabEmp.Enabled = true;

                        txtP1Ana.Enabled = true;
                        txtP1Des.Enabled = true;
                        txtP1Emp.Enabled = true;

                        txtP2Ana.Enabled = true;
                        txtP2Des.Enabled = true;
                        txtP2Emp.Enabled = true;

                        txtAtvAna.Text = Convert.ToString(alunos[indice].atvAnalise);
                        txtAtvDes.Text = Convert.ToString(alunos[indice].atvDesign);
                        txtAtvEmp.Text = Convert.ToString(alunos[indice].atvEmpreendedorismo);

                        txtTrabAna.Text = Convert.ToString(alunos[indice].trabAnalise);
                        txtTrabDes.Text = Convert.ToString(alunos[indice].trabDesign);
                        txtTrabEmp.Text = Convert.ToString(alunos[indice].trabEmpreendedorismo);

                        txtP1Ana.Text = Convert.ToString(alunos[indice].p1Analise);
                        txtP1Des.Text = Convert.ToString(alunos[indice].p1Design);
                        txtP1Emp.Text = Convert.ToString(alunos[indice].p1Empreendedorismo);

                        txtP2Ana.Text = Convert.ToString(alunos[indice].p2Analise);
                        txtP2Des.Text = Convert.ToString(alunos[indice].p2Design);
                        txtP2Emp.Text = Convert.ToString(alunos[indice].p2Empreendedorismo);
                        

                    }
                }
            }
        }

        //Clicar no botão Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            int numero = random.Next(10000, 99999);

            foreach (int list in listaRandom)
            {
                if (numero == list)
                {
                    numero = random.Next(1, 100);
                }

                else
                {
                    listaRandom.Add(numero);
                }
            }

            Aluno a = new Aluno()
            {
                matricula = numero,
                nome = txtNome.Text,
                telefone = txtTel.Text,
                etapa = cmbEtapa.Text
            };

            if (a.etapa == "1")
            {
                txtAtvArq.Enabled = true;
                txtAtvLog.Enabled = true;
                txtAtvSist.Enabled = true;

                txtTrabArq.Enabled = true;
                txtTrabLog.Enabled = true;
                txtTrabSist.Enabled = true;

                txtP1Arq.Enabled = true;
                txtP1Log.Enabled = true;
                txtP1Sist.Enabled = true;

                txtP2Arq.Enabled = true;
                txtP2Log.Enabled = true;
                txtP2Sist.Enabled = true;

                txtAtvBanco.Enabled = false;
                txtAtvLing.Enabled = false;
                txtAtvProg.Enabled = false;
                txtAtvRedes.Enabled = false;

                txtTrabBanco.Enabled = false;
                txtTrabLing.Enabled = false;
                txtTrabProg.Enabled = false;
                txtTrabRedes.Enabled = false;

                txtP1Banco.Enabled = false;
                txtP1Ling.Enabled = false;
                txtP1Prog.Enabled = false;
                txtP1Redes.Enabled = false;

                txtP2Banco.Enabled = false;
                txtP2Ling.Enabled = false;
                txtP2Prog.Enabled = false;
                txtP2Redes.Enabled = false;

                txtAtvAna.Enabled = false;
                txtAtvDes.Enabled = false;
                txtAtvEmp.Enabled = false;

                txtTrabAna.Enabled = false;
                txtTrabDes.Enabled = false;
                txtTrabEmp.Enabled = false;

                txtP1Ana.Enabled = false;
                txtP1Des.Enabled = false;
                txtP1Emp.Enabled = false;

                txtP2Ana.Enabled = false;
                txtP2Des.Enabled = false;
                txtP2Emp.Enabled = false;

                a.atvArquitetura = Convert.ToInt32(txtAtvArq.Text);
                a.atvLogica = Convert.ToInt32(txtAtvLog.Text);
                a.atvSistemas = Convert.ToInt32(txtAtvSist.Text);

                a.trabArquitetura = Convert.ToInt32(txtTrabArq.Text);
                a.trabLogica = Convert.ToInt32(txtTrabLog.Text);
                a.trabSistemas = Convert.ToInt32(txtTrabSist.Text);

                a.p1Arquitetura = Convert.ToInt32(txtP1Arq.Text);
                a.p1Logica = Convert.ToInt32(txtP1Log.Text);
                a.p1Sistemas = Convert.ToInt32(txtP1Sist.Text);

                a.p2Arquitetura = Convert.ToInt32(txtP2Arq.Text);
                a.p2Logica = Convert.ToInt32(txtP2Log.Text);
                a.p2Sistemas = Convert.ToInt32(txtP2Sist.Text);

                txtTotArq.Text = Convert.ToString(a.atvArquitetura + a.trabArquitetura + a.p1Arquitetura + a.p2Arquitetura);
                txtTotLog.Text = Convert.ToString(a.atvLogica + a.trabLogica + a.p1Logica + a.p2Logica);
                txtTotSist.Text = Convert.ToString(a.atvSistemas + a.trabSistemas + a.p1Sistemas + a.p2Sistemas);
            }

            if (a.etapa == "2")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = true;
                txtAtvLing.Enabled = true;
                txtAtvProg.Enabled = true;
                txtAtvRedes.Enabled = true;

                txtTrabBanco.Enabled = true;
                txtTrabLing.Enabled = true;
                txtTrabProg.Enabled = true;
                txtTrabRedes.Enabled = true;

                txtP1Banco.Enabled = true;
                txtP1Ling.Enabled = true;
                txtP1Prog.Enabled = true;
                txtP1Redes.Enabled = true;

                txtP2Banco.Enabled = true;
                txtP2Ling.Enabled = true;
                txtP2Prog.Enabled = true;
                txtP2Redes.Enabled = true;

                txtAtvAna.Enabled = false;
                txtAtvDes.Enabled = false;
                txtAtvEmp.Enabled = false;

                txtTrabAna.Enabled = false;
                txtTrabDes.Enabled = false;
                txtTrabEmp.Enabled = false;

                txtP1Ana.Enabled = false;
                txtP1Des.Enabled = false;
                txtP1Emp.Enabled = false;

                txtP2Ana.Enabled = false;
                txtP2Des.Enabled = false;
                txtP2Emp.Enabled = false;

                a.atvBanco = Convert.ToInt32(txtAtvBanco.Text);
                a.atvLinguagem = Convert.ToInt32(txtAtvLing.Text);
                a.atvProgramacao = Convert.ToInt32(txtAtvProg.Text);
                a.atvRedes = Convert.ToInt32(txtAtvRedes.Text);

                a.trabBanco = Convert.ToInt32(txtTrabBanco.Text);
                a.trabLinguagem = Convert.ToInt32(txtTrabLing.Text);
                a.trabProgramacao = Convert.ToInt32(txtTrabProg.Text);
                a.trabRedes = Convert.ToInt32(txtTrabRedes.Text);

                a.p1Banco = Convert.ToInt32(txtP1Banco.Text);
                a.p1Linguagem = Convert.ToInt32(txtP1Ling.Text);
                a.p1Programacao = Convert.ToInt32(txtP1Prog.Text);
                a.p1Redes = Convert.ToInt32(txtP1Redes.Text);

                a.p2Banco = Convert.ToInt32(txtP2Banco.Text);
                a.p2Linguagem = Convert.ToInt32(txtP2Ling.Text);
                a.p2Programacao = Convert.ToInt32(txtP2Prog.Text);
                a.p2Redes = Convert.ToInt32(txtP2Redes.Text);

                txtTotBanco.Text = Convert.ToString(a.atvBanco + a.trabBanco + a.p1Banco + a.p2Banco);
                txtTotLing.Text = Convert.ToString(a.atvLinguagem + a.trabLinguagem + a.p1Linguagem + a.p2Linguagem);
                txtTotProg.Text = Convert.ToString(a.atvProgramacao + a.trabProgramacao + a.p1Programacao + a.p2Programacao);
                txtTotRedes.Text = Convert.ToString(a.atvRedes + a.trabRedes + a.p1Redes + a.p2Redes);
            }

            if(a.etapa == "3")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = false;
                txtAtvLing.Enabled = false;
                txtAtvProg.Enabled = false;
                txtAtvRedes.Enabled = false;

                txtTrabBanco.Enabled = false;
                txtTrabLing.Enabled = false;
                txtTrabProg.Enabled = false;
                txtTrabRedes.Enabled = false;

                txtP1Banco.Enabled = false;
                txtP1Ling.Enabled = false;
                txtP1Prog.Enabled = false;
                txtP1Redes.Enabled = false;

                txtP2Banco.Enabled = false;
                txtP2Ling.Enabled = false;
                txtP2Prog.Enabled = false;
                txtP2Redes.Enabled = false;

                txtAtvAna.Enabled = true;
                txtAtvDes.Enabled = true;
                txtAtvEmp.Enabled = true;

                txtTrabAna.Enabled = true;
                txtTrabDes.Enabled = true;
                txtTrabEmp.Enabled = true;

                txtP1Ana.Enabled = true;
                txtP1Des.Enabled = true;
                txtP1Emp.Enabled = true;

                txtP2Ana.Enabled = true;
                txtP2Des.Enabled = true;
                txtP2Emp.Enabled = true;

               
                a.atvAnalise = Convert.ToInt32(txtAtvAna.Text);
                a.atvDesign = Convert.ToInt32(txtAtvDes.Text);
                a.atvEmpreendedorismo = Convert.ToInt32(txtAtvEmp.Text);

                a.trabAnalise = Convert.ToInt32(txtTrabAna.Text);
                a.trabDesign = Convert.ToInt32(txtTrabDes.Text);
                a.trabEmpreendedorismo = Convert.ToInt32(txtTrabEmp.Text);

                a.p1Analise = Convert.ToInt32(txtP1Ana.Text);
                a.p1Design = Convert.ToInt32(txtP1Des.Text);
                a.p1Empreendedorismo = Convert.ToInt32(txtP1Emp.Text);
                
                a.p2Analise = Convert.ToInt32(txtP2Ana.Text);
                a.p2Design = Convert.ToInt32(txtP2Des.Text);
                a.p2Empreendedorismo = Convert.ToInt32(txtP2Emp.Text);

                txtTotAna.Text = Convert.ToString(a.atvAnalise + a.trabAnalise + a.p1Analise + a.p2Analise);
                txtTotDes.Text = Convert.ToString(a.atvDesign + a.trabDesign + a.p1Design + a.p2Design);
                txtTotEmp.Text = Convert.ToString(a.atvEmpreendedorismo + a.trabEmpreendedorismo + a.p1Empreendedorismo + a.p2Empreendedorismo);

            }

            Aluno.AdicionarAluno(a);
            alunos = Aluno.ListarAlunos();
            dgvCadastro.DataSource = alunos;

            txtMat.Clear();
            txtNome.Clear();
            txtTel.Clear();
            cmbEtapa.Text = "Selecione a Etapa";
            cmbEtapaNotas.Text = "Selecione a Etapa";

            txtAtvArq.Text = "0";
            txtAtvLog.Text = "0";
            txtAtvSist.Text = "0";

            txtTrabArq.Text = "0";
            txtTrabLog.Text = "0";
            txtTrabSist.Text = "0";

            txtP1Arq.Text = "0";
            txtP1Log.Text = "0";
            txtP1Sist.Text = "0";

            txtP2Arq.Text = "0";
            txtP2Log.Text = "0";
            txtP2Sist.Text = "0";

            txtAtvBanco.Text = "0";
            txtAtvLing.Text = "0";
            txtAtvProg.Text = "0";
            txtAtvRedes.Text = "0";

            txtTrabBanco.Text = "0";
            txtTrabLing.Text = "0";
            txtTrabProg.Text = "0";
            txtTrabRedes.Text = "0";

            txtP1Banco.Text = "0";
            txtP1Ling.Text = "0";
            txtP1Prog.Text = "0";
            txtP1Redes.Text = "0";

            txtP2Banco.Text = "0";
            txtP2Ling.Text = "0";
            txtP2Prog.Text = "0";
            txtP2Redes.Text = "0";

            txtAtvAna.Text = "0";
            txtAtvDes.Text = "0";
            txtAtvEmp.Text = "0";

            txtTrabAna.Text = "0";
            txtTrabDes.Text = "0";
            txtTrabEmp.Text = "0";

            txtP1Ana.Text = "0";
            txtP1Des.Text = "0";
            txtP1Emp.Text = "0";

            txtP2Ana.Text = "0";
            txtP2Des.Text = "0";
            txtP2Emp.Text = "0";
        }

        //Clicar no botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {

            Aluno a = new Aluno()
            {
                matricula = Convert.ToInt32(txtMat.Text),
                nome = txtNome.Text,
                telefone = txtTel.Text,
                etapa = cmbEtapa.Text
            };

            if (a.etapa == "1")
            {
                txtAtvArq.Enabled = true;
                txtAtvLog.Enabled = true;
                txtAtvSist.Enabled = true;

                txtTrabArq.Enabled = true;
                txtTrabLog.Enabled = true;
                txtTrabSist.Enabled = true;

                txtP1Arq.Enabled = true;
                txtP1Log.Enabled = true;
                txtP1Sist.Enabled = true;

                txtP2Arq.Enabled = true;
                txtP2Log.Enabled = true;
                txtP2Sist.Enabled = true;

                txtAtvBanco.Enabled = false;
                txtAtvLing.Enabled = false;
                txtAtvProg.Enabled = false;
                txtAtvRedes.Enabled = false;

                txtTrabBanco.Enabled = false;
                txtTrabLing.Enabled = false;
                txtTrabProg.Enabled = false;
                txtTrabRedes.Enabled = false;

                txtP1Banco.Enabled = false;
                txtP1Ling.Enabled = false;
                txtP1Prog.Enabled = false;
                txtP1Redes.Enabled = false;

                txtP2Banco.Enabled = false;
                txtP2Ling.Enabled = false;
                txtP2Prog.Enabled = false;
                txtP2Redes.Enabled = false;

                txtAtvAna.Enabled = false;
                txtAtvDes.Enabled = false;
                txtAtvEmp.Enabled = false;

                txtTrabAna.Enabled = false;
                txtTrabDes.Enabled = false;
                txtTrabEmp.Enabled = false;

                txtP1Ana.Enabled = false;
                txtP1Des.Enabled = false;
                txtP1Emp.Enabled = false;

                txtP2Ana.Enabled = false;
                txtP2Des.Enabled = false;
                txtP2Emp.Enabled = false;

                a.atvArquitetura = Convert.ToInt32(txtAtvArq.Text);
                a.atvLogica = Convert.ToInt32(txtAtvLog.Text);
                a.atvSistemas = Convert.ToInt32(txtAtvSist.Text);

                a.trabArquitetura = Convert.ToInt32(txtTrabArq.Text);
                a.trabLogica = Convert.ToInt32(txtTrabLog.Text);
                a.trabSistemas = Convert.ToInt32(txtTrabSist.Text);

                a.p1Arquitetura = Convert.ToInt32(txtP1Arq.Text);
                a.p1Logica = Convert.ToInt32(txtP1Log.Text);
                a.p1Sistemas = Convert.ToInt32(txtP1Sist.Text);

                a.p2Arquitetura = Convert.ToInt32(txtP2Arq.Text);
                a.p2Logica = Convert.ToInt32(txtP2Log.Text);
                a.p2Sistemas = Convert.ToInt32(txtP2Sist.Text);

                txtTotArq.Text = Convert.ToString(a.atvArquitetura + a.trabArquitetura + a.p1Arquitetura + a.p2Arquitetura);
                txtTotLog.Text = Convert.ToString(a.atvLogica + a.trabLogica + a.p1Logica + a.p2Logica);
                txtTotSist.Text = Convert.ToString(a.atvSistemas + a.trabLogica + a.p1Sistemas + a.p2Sistemas);
            }

            if (a.etapa == "2")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = true;
                txtAtvLing.Enabled = true;
                txtAtvProg.Enabled = true;
                txtAtvRedes.Enabled = true;

                txtTrabBanco.Enabled = true;
                txtTrabLing.Enabled = true;
                txtTrabProg.Enabled = true;
                txtTrabRedes.Enabled = true;

                txtP1Banco.Enabled = true;
                txtP1Ling.Enabled = true;
                txtP1Prog.Enabled = true;
                txtP1Redes.Enabled = true;

                txtP2Banco.Enabled = true;
                txtP2Ling.Enabled = true;
                txtP2Prog.Enabled = true;
                txtP2Redes.Enabled = true;

                txtAtvAna.Enabled = false;
                txtAtvDes.Enabled = false;
                txtAtvEmp.Enabled = false;

                txtTrabAna.Enabled = false;
                txtTrabDes.Enabled = false;
                txtTrabEmp.Enabled = false;

                txtP1Ana.Enabled = false;
                txtP1Des.Enabled = false;
                txtP1Emp.Enabled = false;

                txtP2Ana.Enabled = false;
                txtP2Des.Enabled = false;
                txtP2Emp.Enabled = false;

                a.atvBanco = Convert.ToInt32(txtAtvBanco.Text);
                a.atvLinguagem = Convert.ToInt32(txtAtvLing.Text);
                a.atvProgramacao = Convert.ToInt32(txtAtvProg.Text);
                a.atvRedes = Convert.ToInt32(txtAtvRedes.Text);

                a.trabBanco = Convert.ToInt32(txtTrabBanco.Text);
                a.trabLinguagem = Convert.ToInt32(txtTrabLing.Text);
                a.trabProgramacao = Convert.ToInt32(txtTrabProg.Text);
                a.trabRedes = Convert.ToInt32(txtTrabRedes.Text);

                a.p1Banco = Convert.ToInt32(txtP1Banco.Text);
                a.p1Linguagem = Convert.ToInt32(txtP1Ling.Text);
                a.p1Programacao = Convert.ToInt32(txtP1Prog.Text);
                a.p1Redes = Convert.ToInt32(txtP1Redes.Text);

                a.p2Banco = Convert.ToInt32(txtP2Banco.Text);
                a.p2Linguagem = Convert.ToInt32(txtP2Ling.Text);
                a.p2Programacao = Convert.ToInt32(txtP2Prog.Text);
                a.p2Redes = Convert.ToInt32(txtP2Redes.Text);

                txtTotBanco.Text = Convert.ToString(a.atvBanco + a.trabBanco + a.p1Banco + a.p2Banco);
                txtTotLing.Text = Convert.ToString(a.atvLinguagem + a.trabLinguagem + a.p1Linguagem + a.p2Linguagem);
                txtTotProg.Text = Convert.ToString(a.atvProgramacao + a.trabProgramacao + a.p1Programacao + a.p2Programacao);
                txtTotRedes.Text = Convert.ToString(a.atvRedes + a.trabRedes + a.p1Redes + a.p2Redes);
            }

            if (a.etapa == "3")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = false;
                txtAtvLing.Enabled = false;
                txtAtvProg.Enabled = false;
                txtAtvRedes.Enabled = false;

                txtTrabBanco.Enabled = false;
                txtTrabLing.Enabled = false;
                txtTrabProg.Enabled = false;
                txtTrabRedes.Enabled = false;

                txtP1Banco.Enabled = false;
                txtP1Ling.Enabled = false;
                txtP1Prog.Enabled = false;
                txtP1Redes.Enabled = false;

                txtP2Banco.Enabled = false;
                txtP2Ling.Enabled = false;
                txtP2Prog.Enabled = false;
                txtP2Redes.Enabled = false;

                txtAtvAna.Enabled = true;
                txtAtvDes.Enabled = true;
                txtAtvEmp.Enabled = true;

                txtTrabAna.Enabled = true;
                txtTrabDes.Enabled = true;
                txtTrabEmp.Enabled = true;

                txtP1Ana.Enabled = true;
                txtP1Des.Enabled = true;
                txtP1Emp.Enabled = true;

                txtP2Ana.Enabled = true;
                txtP2Des.Enabled = true;
                txtP2Emp.Enabled = true;

                a.atvAnalise = Convert.ToInt32(txtAtvAna.Text);
                a.atvDesign = Convert.ToInt32(txtAtvDes.Text);
                a.atvEmpreendedorismo = Convert.ToInt32(txtAtvEmp.Text);

                a.trabAnalise = Convert.ToInt32(txtTrabAna.Text);
                a.trabDesign = Convert.ToInt32(txtTrabDes.Text);
                a.trabEmpreendedorismo = Convert.ToInt32(txtTrabEmp.Text);

                a.p1Analise = Convert.ToInt32(txtP1Ana.Text);
                a.p1Design = Convert.ToInt32(txtP1Des.Text);
                a.p1Empreendedorismo = Convert.ToInt32(txtP1Emp.Text);

                a.p2Analise = Convert.ToInt32(txtP2Ana.Text);
                a.p2Design = Convert.ToInt32(txtP2Des.Text);
                a.p2Empreendedorismo = Convert.ToInt32(txtP2Emp.Text);

                txtTotAna.Text = Convert.ToString(a.atvAnalise + a.trabAnalise + a.p1Analise + a.p2Analise);
                txtTotDes.Text = Convert.ToString(a.atvDesign + a.trabDesign + a.p1Design + a.p2Design);
                txtTotEmp.Text = Convert.ToString(a.atvEmpreendedorismo + a.trabEmpreendedorismo + a.p1Empreendedorismo + a.p2Empreendedorismo);

            }

            Aluno.AdicionarAluno(a);

            if (dgvCadastro.SelectedRows.Count > 0)
            {
                int indice = dgvCadastro.SelectedRows[0].Index;
                Aluno.ExcluirAluno(alunos[indice].matricula);
                alunos = Aluno.ListarAlunos();
                dgvCadastro.DataSource = alunos;
            }

            alunos = Aluno.ListarAlunos();
            dgvCadastro.DataSource = alunos;

            txtMat.Clear();
            txtNome.Clear();
            txtTel.Clear();
            cmbEtapa.Text = "Selecione a Etapa";
            cmbEtapaNotas.Text = "Selecione a Etapa";

            txtAtvArq.Text = "0";
            txtAtvLog.Text = "0";
            txtAtvSist.Text = "0";

            txtTrabArq.Text = "0";
            txtTrabLog.Text = "0";
            txtTrabSist.Text = "0";

            txtP1Arq.Text = "0";
            txtP1Log.Text = "0";
            txtP1Sist.Text = "0";

            txtP2Arq.Text = "0";
            txtP2Log.Text = "0";
            txtP2Sist.Text = "0";

            txtAtvBanco.Text = "0";
            txtAtvLing.Text = "0";
            txtAtvProg.Text = "0";
            txtAtvRedes.Text = "0";

            txtTrabBanco.Text = "0";
            txtTrabLing.Text = "0";
            txtTrabProg.Text = "0";
            txtTrabRedes.Text = "0";

            txtP1Banco.Text = "0";
            txtP1Ling.Text = "0";
            txtP1Prog.Text = "0";
            txtP1Redes.Text = "0";

            txtP2Banco.Text = "0";
            txtP2Ling.Text = "0";
            txtP2Prog.Text = "0";
            txtP2Redes.Text = "0";

            txtAtvAna.Text = "0";
            txtAtvDes.Text = "0";
            txtAtvEmp.Text = "0";

            txtTrabAna.Text = "0";
            txtTrabDes.Text = "0";
            txtTrabEmp.Text = "0";

            txtP1Ana.Text = "0";
            txtP1Des.Text = "0";
            txtP1Emp.Text = "0";

            txtP2Ana.Text = "0";
            txtP2Des.Text = "0";
            txtP2Emp.Text = "0";
        }

        //Clicar no botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                int indice = dgvCadastro.SelectedRows[0].Index;
                Aluno.ExcluirAluno(alunos[indice].matricula);
                alunos = Aluno.ListarAlunos();
                dgvCadastro.DataSource = alunos;
            }
        }

        //O que estiver selecionado no ComboBox 
        private void cmbEtapaNotas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbEtapaNotas.Text == "1")
            {
                panelNotas1.Visible = true;
                panelNotas2.Visible = false;
                panelNotas3.Visible = false;

                btnSalvar.Visible = true;
            }

            if (cmbEtapaNotas.Text == "2")
            {
                panelNotas1.Visible = false;
                panelNotas2.Visible = true;
                panelNotas3.Visible = false;

                btnSalvar.Visible = true;
            }

            if (cmbEtapaNotas.Text == "3")
            {
                panelNotas1.Visible = false;
                panelNotas2.Visible = false;
                panelNotas3.Visible = true;

                btnSalvar.Visible = true;
            }
        }

        //Quando clicar no botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno()
            {
                matricula = Convert.ToInt32(txtMat.Text),
                nome = txtNome.Text,
                telefone = txtTel.Text,
                etapa = cmbEtapa.Text
            };

            if (a.etapa == "1")
            {
                txtAtvArq.Enabled = true;
                txtAtvLog.Enabled = true;
                txtAtvSist.Enabled = true;

                txtTrabArq.Enabled = true;
                txtTrabLog.Enabled = true;
                txtTrabSist.Enabled = true;

                txtP1Arq.Enabled = true;
                txtP1Log.Enabled = true;
                txtP1Sist.Enabled = true;

                txtP2Arq.Enabled = true;
                txtP2Log.Enabled = true;
                txtP2Sist.Enabled = true;

                a.atvArquitetura = Convert.ToInt32(txtAtvArq.Text);
                a.atvLogica = Convert.ToInt32(txtAtvLog.Text);
                a.atvSistemas = Convert.ToInt32(txtAtvSist.Text);

                a.trabArquitetura = Convert.ToInt32(txtTrabArq.Text);
                a.trabLogica = Convert.ToInt32(txtTrabLog.Text);
                a.trabSistemas = Convert.ToInt32(txtTrabSist.Text);

                a.p1Arquitetura = Convert.ToInt32(txtP1Arq.Text);
                a.p1Logica = Convert.ToInt32(txtP1Log.Text);
                a.p1Sistemas = Convert.ToInt32(txtP1Sist.Text);

                a.p2Arquitetura = Convert.ToInt32(txtP2Arq.Text);
                a.p2Logica = Convert.ToInt32(txtP2Log.Text);
                a.p2Sistemas = Convert.ToInt32(txtP2Sist.Text);

                txtTotArq.Text = Convert.ToString(a.atvArquitetura + a.trabArquitetura + a.p1Arquitetura + a.p2Arquitetura);
                txtTotLog.Text = Convert.ToString(a.atvLogica + a.trabLogica + a.p1Logica + a.p2Logica);
                txtTotSist.Text = Convert.ToString(a.atvSistemas + a.trabSistemas + a.p1Sistemas + a.p2Sistemas);
            }

            if (a.etapa == "2")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = true;
                txtAtvLing.Enabled = true;
                txtAtvProg.Enabled = true;
                txtAtvRedes.Enabled = true;

                txtTrabBanco.Enabled = true;
                txtTrabLing.Enabled = true;
                txtTrabProg.Enabled = true;
                txtTrabRedes.Enabled = true;

                txtP1Banco.Enabled = true;
                txtP1Ling.Enabled = true;
                txtP1Prog.Enabled = true;
                txtP1Redes.Enabled = true;

                txtP2Banco.Enabled = true;
                txtP2Ling.Enabled = true;
                txtP2Prog.Enabled = true;
                txtP2Redes.Enabled = true;

                txtAtvAna.Enabled = false;
                txtAtvDes.Enabled = false;
                txtAtvEmp.Enabled = false;

                txtTrabAna.Enabled = false;
                txtTrabDes.Enabled = false;
                txtTrabEmp.Enabled = false;

                txtP1Ana.Enabled = false;
                txtP1Des.Enabled = false;
                txtP1Emp.Enabled = false;

                txtP2Ana.Enabled = false;
                txtP2Des.Enabled = false;
                txtP2Emp.Enabled = false;

                a.atvBanco = Convert.ToInt32(txtAtvBanco.Text);
                a.atvLinguagem = Convert.ToInt32(txtAtvLing.Text);
                a.atvProgramacao = Convert.ToInt32(txtAtvProg.Text);
                a.atvRedes = Convert.ToInt32(txtAtvRedes.Text);

                a.trabBanco = Convert.ToInt32(txtTrabBanco.Text);
                a.trabLinguagem = Convert.ToInt32(txtTrabLing.Text);
                a.trabProgramacao = Convert.ToInt32(txtTrabProg.Text);
                a.trabRedes = Convert.ToInt32(txtTrabRedes.Text);

                a.p1Banco = Convert.ToInt32(txtP1Banco.Text);
                a.p1Linguagem = Convert.ToInt32(txtP1Ling.Text);
                a.p1Programacao = Convert.ToInt32(txtP1Prog.Text);
                a.p1Redes = Convert.ToInt32(txtP1Redes.Text);

                a.p2Banco = Convert.ToInt32(txtP2Banco.Text);
                a.p2Linguagem = Convert.ToInt32(txtP2Ling.Text);
                a.p2Programacao = Convert.ToInt32(txtP2Prog.Text);
                a.p2Redes = Convert.ToInt32(txtP2Redes.Text);

                txtTotBanco.Text = Convert.ToString(a.atvBanco + a.trabBanco + a.p1Banco + a.p2Banco);
                txtTotLing.Text = Convert.ToString(a.atvLinguagem + a.trabLinguagem + a.p1Linguagem + a.p2Linguagem);
                txtTotProg.Text = Convert.ToString(a.atvProgramacao + a.trabProgramacao + a.p1Programacao + a.p2Programacao);
                txtTotRedes.Text = Convert.ToString(a.atvRedes + a.trabRedes + a.p1Redes+ a.p2Redes);
            }

            if (a.etapa == "3")
            {
                txtAtvArq.Enabled = false;
                txtAtvLog.Enabled = false;
                txtAtvSist.Enabled = false;

                txtTrabArq.Enabled = false;
                txtTrabLog.Enabled = false;
                txtTrabSist.Enabled = false;

                txtP1Arq.Enabled = false;
                txtP1Log.Enabled = false;
                txtP1Sist.Enabled = false;

                txtP2Arq.Enabled = false;
                txtP2Log.Enabled = false;
                txtP2Sist.Enabled = false;

                txtAtvBanco.Enabled = false;
                txtAtvLing.Enabled = false;
                txtAtvProg.Enabled = false;
                txtAtvRedes.Enabled = false;

                txtTrabBanco.Enabled = false;
                txtTrabLing.Enabled = false;
                txtTrabProg.Enabled = false;
                txtTrabRedes.Enabled = false;

                txtP1Banco.Enabled = false;
                txtP1Ling.Enabled = false;
                txtP1Prog.Enabled = false;
                txtP1Redes.Enabled = false;

                txtP2Banco.Enabled = false;
                txtP2Ling.Enabled = false;
                txtP2Prog.Enabled = false;
                txtP2Redes.Enabled = false;

                txtAtvAna.Enabled = true;
                txtAtvDes.Enabled = true;
                txtAtvEmp.Enabled = true;

                txtTrabAna.Enabled = true;
                txtTrabDes.Enabled = true;
                txtTrabEmp.Enabled = true;

                txtP1Ana.Enabled = true;
                txtP1Des.Enabled = true;
                txtP1Emp.Enabled = true;

                txtP2Ana.Enabled = true;
                txtP2Des.Enabled = true;
                txtP2Emp.Enabled = true;

                a.atvAnalise = Convert.ToInt32(txtAtvAna.Text);
                a.atvDesign = Convert.ToInt32(txtAtvDes.Text);
                a.atvEmpreendedorismo = Convert.ToInt32(txtAtvEmp.Text);

                a.trabAnalise = Convert.ToInt32(txtTrabAna.Text);
                a.trabDesign = Convert.ToInt32(txtTrabDes.Text);
                a.trabEmpreendedorismo = Convert.ToInt32(txtTrabEmp.Text);

                a.p1Analise = Convert.ToInt32(txtP1Ana.Text);
                a.p1Design = Convert.ToInt32(txtP1Des.Text);
                a.p1Empreendedorismo = Convert.ToInt32(txtP1Emp.Text);

                a.p2Analise = Convert.ToInt32(txtP2Ana.Text);
                a.p2Design = Convert.ToInt32(txtP2Des.Text);
                a.p2Empreendedorismo = Convert.ToInt32(txtP2Emp.Text);
                
                txtTotAna.Text = Convert.ToString(a.atvAnalise + a.trabAnalise + a.p1Analise + a.p2Analise);
                txtTotDes.Text = Convert.ToString(a.atvDesign + a.trabDesign + a.p1Design + a.p2Design);
                txtTotEmp.Text = Convert.ToString(a.atvEmpreendedorismo + a.trabEmpreendedorismo + a.p1Empreendedorismo + a.p2Empreendedorismo);
            }

            Aluno.AdicionarAluno(a);

            if (dgvCadastro.SelectedRows.Count > 0)
            {
                int indice = dgvCadastro.SelectedRows[0].Index;
                Aluno.ExcluirAluno(alunos[indice].matricula);
                alunos = Aluno.ListarAlunos();
                dgvCadastro.DataSource = alunos;
            }

            alunos = Aluno.ListarAlunos();
            dgvCadastro.DataSource = alunos;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtMat.Clear();
            txtNome.Clear();
            txtTel.Clear();
            cmbEtapa.Text = "Selecione a Etapa";
            cmbEtapaNotas.Text = "Selecione a Etapa";

            txtAtvArq.Text = "0";
            txtAtvLog.Text = "0";
            txtAtvSist.Text = "0";

            txtTrabArq.Text = "0";
            txtTrabLog.Text = "0";
            txtTrabSist.Text = "0";

            txtP1Arq.Text = "0";
            txtP1Log.Text = "0";
            txtP1Sist.Text = "0";

            txtP2Arq.Text = "0";
            txtP2Log.Text = "0";
            txtP2Sist.Text = "0";

            txtAtvBanco.Text = "0";
            txtAtvLing.Text = "0";
            txtAtvProg.Text = "0";
            txtAtvRedes.Text = "0";

            txtTrabBanco.Text = "0";
            txtTrabLing.Text = "0";
            txtTrabProg.Text = "0";
            txtTrabRedes.Text = "0";

            txtP1Banco.Text = "0";
            txtP1Ling.Text = "0";
            txtP1Prog.Text = "0";
            txtP1Redes.Text = "0";

            txtP2Banco.Text = "0";
            txtP2Ling.Text = "0";
            txtP2Prog.Text = "0";
            txtP2Redes.Text = "0";

            txtAtvAna.Text = "0";
            txtAtvDes.Text = "0";
            txtAtvEmp.Text = "0";

            txtTrabAna.Text = "0";
            txtTrabDes.Text = "0";
            txtTrabEmp.Text = "0";

            txtP1Ana.Text = "0";
            txtP1Des.Text = "0";
            txtP1Emp.Text = "0";

            txtP2Ana.Text = "0";
            txtP2Des.Text = "0";
            txtP2Emp.Text = "0";
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
