using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MeuPrograma
{
    class Aluno
    {
        public int matricula { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string etapa { get; set; }

        public int atvArquitetura { get; set; }
        public int atvLogica { get; set; }
        public int atvSistemas { get; set; }
        public int atvBanco { get; set; }
        public int atvLinguagem { get; set; }
        public int atvProgramacao { get; set; }
        public int atvRedes { get; set; }
        public int atvAnalise { get; set; }
        public int atvDesign { get; set; }
        public int atvEmpreendedorismo { get; set; }

        public int trabArquitetura { get; set; }
        public int trabLogica { get; set; }
        public int trabSistemas { get; set; }
        public int trabBanco { get; set; }
        public int trabLinguagem { get; set; }
        public int trabProgramacao { get; set; }
        public int trabRedes { get; set; }
        public int trabAnalise { get; set; }
        public int trabDesign { get; set; }
        public int trabEmpreendedorismo { get; set; }

        public int p1Arquitetura { get; set; }
        public int p1Logica { get; set; }
        public int p1Sistemas { get; set; }
        public int p1Banco { get; set; }
        public int p1Linguagem { get; set; }
        public int p1Programacao { get; set; }
        public int p1Redes { get; set; }
        public int p1Analise { get; set; }
        public int p1Design { get; set; }
        public int p1Empreendedorismo { get; set; }

        public int p2Arquitetura { get; set; }
        public int p2Logica { get; set; }
        public int p2Sistemas { get; set; }
        public int p2Banco { get; set; }
        public int p2Linguagem { get; set; }
        public int p2Programacao { get; set; }
        public int p2Redes { get; set; }
        public int p2Analise { get; set; }
        public int p2Design { get; set; }
        public int p2Empreendedorismo { get; set; }
        
        //Listar Alunos
        public static List<Aluno> ListarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            XElement xml = XElement.Load("Alunos.xml");

            foreach (XElement x in xml.Elements())
            {
                Aluno a = new Aluno();

                a.matricula = int.Parse(x.Attribute("matricula").Value);
                a.nome = x.Attribute("nome").Value;
                a.telefone = x.Attribute("telefone").Value;
                a.etapa = x.Attribute("etapa").Value;

                if (a.etapa == "1")
                {
                    a.atvArquitetura = int.Parse(x.Attribute("atvArquitetura").Value);
                    a.atvLogica = int.Parse(x.Attribute("atvLogica").Value);
                    a.atvSistemas = int.Parse(x.Attribute("atvSistemas").Value);

                    a.trabArquitetura = int.Parse(x.Attribute("trabArquitetura").Value);
                    a.trabLogica = int.Parse(x.Attribute("trabLogica").Value);
                    a.trabSistemas = int.Parse(x.Attribute("trabSistemas").Value);
                    
                    a.p1Arquitetura = int.Parse(x.Attribute("p1Arquitetura").Value);
                    a.p1Logica = int.Parse(x.Attribute("p1Logica").Value);
                    a.p1Sistemas = int.Parse(x.Attribute("p1Sistemas").Value);

                    a.p2Arquitetura = int.Parse(x.Attribute("p2Arquitetura").Value);
                    a.p2Logica = int.Parse(x.Attribute("p2Logica").Value);
                    a.p2Sistemas = int.Parse(x.Attribute("p2Sistemas").Value);
                }

                if (a.etapa == "2")
                {
                    a.atvBanco = int.Parse(x.Attribute("atvBanco").Value);
                    a.atvLinguagem = int.Parse(x.Attribute("atvLinguagem").Value);
                    a.atvProgramacao = int.Parse(x.Attribute("atvProgramacao").Value);
                    a.atvRedes = int.Parse(x.Attribute("atvRedes").Value);

                    a.trabBanco = int.Parse(x.Attribute("trabBanco").Value);
                    a.trabLinguagem = int.Parse(x.Attribute("trabLinguagem").Value);
                    a.trabProgramacao = int.Parse(x.Attribute("trabProgramacao").Value);
                    a.trabRedes = int.Parse(x.Attribute("trabRedes").Value);

                    a.p1Banco = int.Parse(x.Attribute("p1Banco").Value);
                    a.p1Linguagem = int.Parse(x.Attribute("p1Linguagem").Value);
                    a.p1Programacao = int.Parse(x.Attribute("p1Programacao").Value);
                    a.p1Redes = int.Parse(x.Attribute("p1Redes").Value);

                    a.p2Banco = int.Parse(x.Attribute("p2Banco").Value);
                    a.p2Linguagem = int.Parse(x.Attribute("p2Linguagem").Value);
                    a.p2Programacao = int.Parse(x.Attribute("p2Programacao").Value);
                    a.p2Redes = int.Parse(x.Attribute("p2Redes").Value);
                }

                if (a.etapa == "3")
                {
                    a.atvAnalise = int.Parse(x.Attribute("atvAnalise").Value);
                    a.atvDesign = int.Parse(x.Attribute("atvDesign").Value);
                    a.atvEmpreendedorismo = int.Parse(x.Attribute("atvEmpreendedorismo").Value);

                    a.trabAnalise = int.Parse(x.Attribute("trabAnalise").Value);
                    a.trabDesign = int.Parse(x.Attribute("trabDesign").Value);
                    a.trabEmpreendedorismo = int.Parse(x.Attribute("trabEmpreendedorismo").Value);

                    a.p1Analise = int.Parse(x.Attribute("p1Analise").Value);
                    a.p1Design = int.Parse(x.Attribute("p1Design").Value);
                    a.p1Empreendedorismo = int.Parse(x.Attribute("p1Empreendedorismo").Value);

                    a.p2Analise = int.Parse(x.Attribute("p2Analise").Value);
                    a.p2Design = int.Parse(x.Attribute("p2Design").Value);
                    a.p2Empreendedorismo = int.Parse(x.Attribute("p2Empreendedorismo").Value);
                }

                alunos.Add(a);
            }
            return alunos;
        }

        //Adicionar Aluno
        public static void AdicionarAluno(Aluno a)
        {
            XElement x = new XElement("Aluno");

            x.Add(new XAttribute("matricula", a.matricula.ToString()));
            x.Add(new XAttribute("nome", a.nome));
            x.Add(new XAttribute("telefone", a.telefone));
            x.Add(new XAttribute("etapa", a.etapa));

            if (a.etapa == "1") 
            {
                x.Add(new XAttribute("atvArquitetura", a.atvArquitetura.ToString()));
                x.Add(new XAttribute("atvLogica", a.atvLogica.ToString()));
                x.Add(new XAttribute("atvSistemas", a.atvSistemas.ToString()));

                x.Add(new XAttribute("trabArquitetura", a.trabArquitetura.ToString()));
                x.Add(new XAttribute("trabLogica", a.trabLogica.ToString()));
                x.Add(new XAttribute("trabSistemas", a.trabSistemas.ToString()));

                x.Add(new XAttribute("p1Arquitetura", a.p1Arquitetura.ToString()));
                x.Add(new XAttribute("p1Logica", a.p1Logica.ToString()));
                x.Add(new XAttribute("p1Sistemas", a.p1Sistemas.ToString()));

                x.Add(new XAttribute("p2Arquitetura", a.p2Arquitetura.ToString()));
                x.Add(new XAttribute("p2Logica", a.p2Logica.ToString()));
                x.Add(new XAttribute("p2Sistemas", a.p2Sistemas.ToString()));
            }

            if (a.etapa == "2")
            {
                x.Add(new XAttribute("atvBanco", a.atvBanco.ToString()));
                x.Add(new XAttribute("atvLinguagem", a.atvLinguagem.ToString()));
                x.Add(new XAttribute("atvProgramacao", a.atvProgramacao.ToString()));
                x.Add(new XAttribute("atvRedes", a.atvRedes.ToString()));

                x.Add(new XAttribute("trabBanco", a.trabBanco.ToString()));
                x.Add(new XAttribute("trabLinguagem", a.trabLinguagem.ToString()));
                x.Add(new XAttribute("trabProgramacao", a.trabProgramacao.ToString()));
                x.Add(new XAttribute("trabRedes", a.trabRedes.ToString()));
                
                x.Add(new XAttribute("p1Banco", a.p1Banco.ToString()));
                x.Add(new XAttribute("p1Linguagem", a.p1Linguagem.ToString()));
                x.Add(new XAttribute("p1Programacao", a.p1Programacao.ToString()));
                x.Add(new XAttribute("p1Redes", a.p1Redes.ToString()));

                x.Add(new XAttribute("p2Banco", a.p2Banco.ToString()));
                x.Add(new XAttribute("p2Linguagem", a.p2Linguagem.ToString()));
                x.Add(new XAttribute("p2Programacao", a.p2Programacao.ToString()));
                x.Add(new XAttribute("p2Redes", a.p2Redes.ToString()));
            }

            if (a.etapa == "3")
            {
                x.Add(new XAttribute("atvAnalise", a.atvAnalise.ToString()));
                x.Add(new XAttribute("atvDesign", a.atvDesign.ToString()));
                x.Add(new XAttribute("atvEmpreendedorismo", a.atvEmpreendedorismo.ToString()));

                x.Add(new XAttribute("trabAnalise", a.trabAnalise.ToString()));
                x.Add(new XAttribute("trabDesign", a.trabDesign.ToString()));
                x.Add(new XAttribute("trabEmpreendedorismo", a.trabEmpreendedorismo.ToString()));

                x.Add(new XAttribute("p1Analise", a.p1Analise.ToString()));
                x.Add(new XAttribute("p1Design", a.p1Design.ToString()));
                x.Add(new XAttribute("p1Empreendedorismo", a.p1Empreendedorismo.ToString()));

                x.Add(new XAttribute("p2Analise", a.p2Analise.ToString()));
                x.Add(new XAttribute("p2Design", a.p2Design.ToString()));
                x.Add(new XAttribute("p2Empreendedorismo", a.p2Empreendedorismo.ToString()));
            }

            XElement xml = XElement.Load("Alunos.xml");
            xml.Add(x);
            xml.Save("Alunos.xml");
        }

        //Excluir Aluno
        public static void ExcluirAluno(int matricula)
        {
            XElement xml = XElement.Load("Alunos.xml");
            XElement x = xml.Elements().Where(a => a.Attribute("matricula").Value.Equals(matricula.ToString())).First();

            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Alunos.xml");
        }
        
        //Editar Aluno
        public static void EditarAluno(Aluno aluno)
        {
            XElement xml = XElement.Load("Alunos.xml");
            XElement x = xml.Elements().Where(a => a.Attribute("matricula").Value.Equals(aluno.matricula.ToString())).First();

            if (x != null)
            {
                x.Attribute("nome").SetValue(aluno.nome);
                x.Attribute("telefone").SetValue(aluno.telefone);
                x.Attribute("etapa").SetValue(aluno.etapa);

                if (aluno.etapa == "1")
                {
                    x.Attribute("atvArquitetura").SetValue(aluno.atvArquitetura);
                    x.Attribute("atvLogica").SetValue(aluno.atvLogica);
                    x.Attribute("atvSistemas").SetValue(aluno.atvSistemas);

                    x.Attribute("trabArquitetura").SetValue(aluno.trabArquitetura);
                    x.Attribute("trabLogica").SetValue(aluno.trabLogica);
                    x.Attribute("trabSistemas").SetValue(aluno.trabSistemas);

                    x.Attribute("p1Arquitetura").SetValue(aluno.p1Arquitetura);
                    x.Attribute("p1Logica").SetValue(aluno.p1Logica);
                    x.Attribute("p1Sistemas").SetValue(aluno.p1Sistemas);

                    x.Attribute("p2Arquitetura").SetValue(aluno.p2Arquitetura);
                    x.Attribute("p2Logica").SetValue(aluno.p2Logica);
                    x.Attribute("p2Sistemas").SetValue(aluno.p2Sistemas);
                }

                if(aluno.etapa == "2")
                {
                    x.Attribute("atvBanco").SetValue(aluno.atvBanco);
                    x.Attribute("atvLinguagem").SetValue(aluno.atvLinguagem);
                    x.Attribute("atvProgramacao").SetValue(aluno.atvProgramacao);
                    x.Attribute("atvRedes").SetValue(aluno.atvRedes);

                    x.Attribute("trabArquitetura").SetValue(aluno.trabArquitetura);
                    x.Attribute("trabLogica").SetValue(aluno.trabLogica);
                    x.Attribute("trabSistemas").SetValue(aluno.trabSistemas);

                    x.Attribute("p1Arquitetura").SetValue(aluno.p1Arquitetura);
                    x.Attribute("p1Logica").SetValue(aluno.p1Logica);
                    x.Attribute("p1Sistemas").SetValue(aluno.p1Sistemas);

                    x.Attribute("p2Arquitetura").SetValue(aluno.p2Arquitetura);
                    x.Attribute("p2Logica").SetValue(aluno.p2Logica);
                    x.Attribute("p2Sistemas").SetValue(aluno.p2Sistemas);
                }

                if (aluno.etapa == "3")
                {
                    x.Attribute("atvAnalise").SetValue(aluno.atvAnalise);
                    x.Attribute("atvDesign").SetValue(aluno.atvDesign);
                    x.Attribute("atvEmpreendedorismo").SetValue(aluno.atvEmpreendedorismo);

                    x.Attribute("trabAnalise").SetValue(aluno.trabAnalise);
                    x.Attribute("trabDesign").SetValue(aluno.trabDesign);
                    x.Attribute("trabEmpreendedorismo").SetValue(aluno.trabEmpreendedorismo);

                    x.Attribute("p1Analise").SetValue(aluno.p1Analise);
                    x.Attribute("p1Design").SetValue(aluno.p1Design);
                    x.Attribute("p1Empreendedorismo").SetValue(aluno.p1Empreendedorismo);

                    x.Attribute("p2Analise").SetValue(aluno.p2Analise);
                    x.Attribute("p2Design").SetValue(aluno.p2Design);
                    x.Attribute("p2Empreendedorismo").SetValue(aluno.p2Empreendedorismo);
                }
            }

            xml.Save("Alunos.xml");
        }
    }
}

