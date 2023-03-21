using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace TestadorDLL
{
    public partial class Fmr_TestadorDLL : Form
    {
        public Fmr_TestadorDLL()
        {
            InitializeComponent();
        }

        private void Lbl_DiretorioDLL_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Txt_ConteudoArquivoOriginal.Text = System.IO.File.ReadAllText(textBox1.Text);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void Fmr_TestadorDLL_Load(object sender, EventArgs e)
        {

        }

        private void Btn_BuscarArquivoEntrada_Click(object sender, EventArgs e)
        {
            FileDialog_ArquivoEntrada.ShowDialog();
            textBox1.Text = FileDialog_ArquivoEntrada.FileName;
        }

        private void Btn_BuscarDLL_Click(object sender, EventArgs e)
        {
            FileDialog_DLL.ShowDialog();
            textBox2.Text = FileDialog_DLL.FileName;
        }

        private void Btn_TestaDLL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                Lbl_mapLoad.Text = "A DLL, o arquivo de Input ou ambos não foram carregados.";
            }
            else
            {
               try
                  {

                    String DLL_Nome;                 //Arquivo *.dll
                    String Namespace;                //Namespace da DLL
                    String Classe_MAP;               //Namespace.MAP da DLL
                    String diretorioArquivoInput;    //Diretório do arquivo de Input;

                    DLL_Nome = textBox2.Text.Substring(textBox2.Text.LastIndexOf('\\') + 1);                    //DESTACA O NOME DA DLL
                    diretorioArquivoInput = textBox1.Text.Substring(0, textBox1.Text.LastIndexOf('\\') + 1);    //PEGA O DIRETÓRIO DO ARQUIVO DE INPUT
                    Namespace = DLL_Nome.Replace(".dll", "");                                                   //PEGA O NAMESPACE
                    Classe_MAP = Namespace + ".MAP";                                                            //PEGA O NOME DA CLASSE
                    
                    Lbl_mapLoad.Text = DLL_Nome + " sendo carregada...";

                    Assembly asm = Assembly.LoadFrom(textBox2.Text);            //ABRE A DLL
                    Type MapType = asm.GetType(Classe_MAP);                     //PEGA O TIPO
                    object mapa = Activator.CreateInstance(MapType);            //INSTANCIA UM OBJETO DE TIPO

                    Lbl_mapLoad.Text = "Mapeamento em Andamento...";
                    
                    if(checkB_CrossID.Checked == false)
                    {
                        //EXECUTA O MÉTODO RUN DA CLASSE MAP COM DOIS PARÂMETROS
                        MapType.InvokeMember("Run", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, mapa, new object[] { textBox1.Text, diretorioArquivoInput + "RESULTADO.TXT" }); //OK

                        //LÊ O CONTEUDO DO ARQUIVO E PRINTA NA TELA
                        Txt_ConteudoArquivoMapeado.Text = System.IO.File.ReadAllText(diretorioArquivoInput + "RESULTADO.TXT");

                        //PRINTA ONDE FOI SALVO O ARQUIVO RESULTADO
                        Lbl_mapLoad.Text = "Arquivo Mapeado gerado em: " + diretorioArquivoInput + "Resultado.txt";
                    }
                    if(checkB_CrossID.Checked == true)
                    {
                        //EXECUTA O MÉTODO RUN DA CLASSE MAP COM DOIS PARÂMETROS
                        MapType.InvokeMember("Run", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, mapa, new object[] { textBox1.Text, Lbl_DiretorioCrossID.Text, diretorioArquivoInput + "RESULTADO.TXT" }); //OK

                        //LÊ O CONTEUDO DO ARQUIVO E PRINTA NA TELA
                        Txt_ConteudoArquivoMapeado.Text = System.IO.File.ReadAllText(diretorioArquivoInput + "RESULTADO.TXT");

                        //PRINTA ONDE FOI SALVO O ARQUIVO RESULTADO
                        Lbl_mapLoad.Text = "Arquivo Mapeado gerado em: " + diretorioArquivoInput + "Resultado.txt";
                    }
                   
                  }catch(Exception ex)
                    {
                        Lbl_mapLoad.Text = "Houve um erro no mapeamento!";
                        Txt_ConteudoArquivoMapeado.Text = "";
                    }

            }

        }

        private void Btn_Limpa_Click(object sender, EventArgs e)
        {
            Lbl_mapLoad.Text = "Limpando Informações.";
            textBox1.Text = "";
            textBox2.Text = "";
            Txt_ConteudoArquivoMapeado.Text = "";
            Txt_ConteudoArquivoOriginal.Text = "";
            Lbl_DiretorioCrossID.Text = "";
        }

        private void checkB_CrossID_CheckedChanged(object sender, EventArgs e)
        {
            Btn_CrossID.Enabled = !Btn_CrossID.Enabled;
            Lbl_DiretorioCrossID.Enabled = !Lbl_DiretorioCrossID.Enabled;
            Lbl_DiretorioCrossID.Text = "";
        }

        private void Btn_CrossID_Click(object sender, EventArgs e)
        {
            FileDialog_ArquivoEntrada.ShowDialog();
            Lbl_DiretorioCrossID.Text = FileDialog_ArquivoEntrada.FileName;
        }

        private void Lbl_DiretorioCrossID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
