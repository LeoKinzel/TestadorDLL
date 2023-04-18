namespace TestadorDLL
{
    partial class Fmr_TestadorDLL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmr_TestadorDLL));
            this.Lbl_DiretorioDLL = new System.Windows.Forms.Label();
            this.Lbl_DiretorioINPUT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FileDialog_ArquivoEntrada = new System.Windows.Forms.OpenFileDialog();
            this.Btn_BuscarDLL = new System.Windows.Forms.Button();
            this.Btn_BuscarArquivoEntrada = new System.Windows.Forms.Button();
            this.FileDialog_DLL = new System.Windows.Forms.OpenFileDialog();
            this.Txt_ConteudoArquivoOriginal = new System.Windows.Forms.TextBox();
            this.Txt_ConteudoArquivoMapeado = new System.Windows.Forms.TextBox();
            this.Btn_TestaDLL = new System.Windows.Forms.Button();
            this.lbl_ArquivoOriginal = new System.Windows.Forms.Label();
            this.lbl_ArquivoMapeado = new System.Windows.Forms.Label();
            this.Lbl_mapLoad = new System.Windows.Forms.Label();
            this.Btn_Limpa = new System.Windows.Forms.Button();
            this.checkB_CrossID = new System.Windows.Forms.CheckBox();
            this.Lbl_CrossID = new System.Windows.Forms.Label();
            this.Lbl_DiretorioCrossID = new System.Windows.Forms.TextBox();
            this.Btn_CrossID = new System.Windows.Forms.Button();
            this.checkB_JSON = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_DiretorioDLL
            // 
            this.Lbl_DiretorioDLL.AutoSize = true;
            this.Lbl_DiretorioDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiretorioDLL.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lbl_DiretorioDLL.Location = new System.Drawing.Point(12, 53);
            this.Lbl_DiretorioDLL.Name = "Lbl_DiretorioDLL";
            this.Lbl_DiretorioDLL.Size = new System.Drawing.Size(120, 18);
            this.Lbl_DiretorioDLL.TabIndex = 0;
            this.Lbl_DiretorioDLL.Text = "Diretório da DLL:";
            this.Lbl_DiretorioDLL.Click += new System.EventHandler(this.Lbl_DiretorioDLL_Click);
            // 
            // Lbl_DiretorioINPUT
            // 
            this.Lbl_DiretorioINPUT.AutoSize = true;
            this.Lbl_DiretorioINPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiretorioINPUT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lbl_DiretorioINPUT.Location = new System.Drawing.Point(12, 21);
            this.Lbl_DiretorioINPUT.Name = "Lbl_DiretorioINPUT";
            this.Lbl_DiretorioINPUT.Size = new System.Drawing.Size(217, 18);
            this.Lbl_DiretorioINPUT.TabIndex = 1;
            this.Lbl_DiretorioINPUT.Text = "Diretório do arquivo de Entrada:";
            this.Lbl_DiretorioINPUT.Click += new System.EventHandler(this.Lbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(461, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(461, 20);
            this.textBox2.TabIndex = 3;
            // 
            // FileDialog_ArquivoEntrada
            // 
            this.FileDialog_ArquivoEntrada.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // Btn_BuscarDLL
            // 
            this.Btn_BuscarDLL.Location = new System.Drawing.Point(702, 51);
            this.Btn_BuscarDLL.Name = "Btn_BuscarDLL";
            this.Btn_BuscarDLL.Size = new System.Drawing.Size(86, 20);
            this.Btn_BuscarDLL.TabIndex = 4;
            this.Btn_BuscarDLL.Text = "Buscar";
            this.Btn_BuscarDLL.UseVisualStyleBackColor = true;
            this.Btn_BuscarDLL.Click += new System.EventHandler(this.Btn_BuscarDLL_Click);
            // 
            // Btn_BuscarArquivoEntrada
            // 
            this.Btn_BuscarArquivoEntrada.Location = new System.Drawing.Point(702, 20);
            this.Btn_BuscarArquivoEntrada.Name = "Btn_BuscarArquivoEntrada";
            this.Btn_BuscarArquivoEntrada.Size = new System.Drawing.Size(86, 20);
            this.Btn_BuscarArquivoEntrada.TabIndex = 5;
            this.Btn_BuscarArquivoEntrada.Text = "Buscar";
            this.Btn_BuscarArquivoEntrada.UseVisualStyleBackColor = true;
            this.Btn_BuscarArquivoEntrada.Click += new System.EventHandler(this.Btn_BuscarArquivoEntrada_Click);
            // 
            // FileDialog_DLL
            // 
            this.FileDialog_DLL.Filter = "Arquivos .DLL (*.dll)|*.dll|All files (*.*)|*.*";
            // 
            // Txt_ConteudoArquivoOriginal
            // 
            this.Txt_ConteudoArquivoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConteudoArquivoOriginal.Location = new System.Drawing.Point(12, 208);
            this.Txt_ConteudoArquivoOriginal.Multiline = true;
            this.Txt_ConteudoArquivoOriginal.Name = "Txt_ConteudoArquivoOriginal";
            this.Txt_ConteudoArquivoOriginal.ReadOnly = true;
            this.Txt_ConteudoArquivoOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_ConteudoArquivoOriginal.Size = new System.Drawing.Size(519, 417);
            this.Txt_ConteudoArquivoOriginal.TabIndex = 6;
            this.Txt_ConteudoArquivoOriginal.WordWrap = false;
            // 
            // Txt_ConteudoArquivoMapeado
            // 
            this.Txt_ConteudoArquivoMapeado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Txt_ConteudoArquivoMapeado.Location = new System.Drawing.Point(542, 208);
            this.Txt_ConteudoArquivoMapeado.Multiline = true;
            this.Txt_ConteudoArquivoMapeado.Name = "Txt_ConteudoArquivoMapeado";
            this.Txt_ConteudoArquivoMapeado.ReadOnly = true;
            this.Txt_ConteudoArquivoMapeado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_ConteudoArquivoMapeado.Size = new System.Drawing.Size(519, 417);
            this.Txt_ConteudoArquivoMapeado.TabIndex = 9;
            this.Txt_ConteudoArquivoMapeado.WordWrap = false;
            // 
            // Btn_TestaDLL
            // 
            this.Btn_TestaDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TestaDLL.Location = new System.Drawing.Point(801, 20);
            this.Btn_TestaDLL.Name = "Btn_TestaDLL";
            this.Btn_TestaDLL.Size = new System.Drawing.Size(123, 51);
            this.Btn_TestaDLL.TabIndex = 8;
            this.Btn_TestaDLL.Text = "Mapear";
            this.Btn_TestaDLL.UseVisualStyleBackColor = true;
            this.Btn_TestaDLL.Click += new System.EventHandler(this.Btn_TestaDLL_Click);
            // 
            // lbl_ArquivoOriginal
            // 
            this.lbl_ArquivoOriginal.AutoSize = true;
            this.lbl_ArquivoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArquivoOriginal.Location = new System.Drawing.Point(159, 174);
            this.lbl_ArquivoOriginal.Name = "lbl_ArquivoOriginal";
            this.lbl_ArquivoOriginal.Size = new System.Drawing.Size(206, 31);
            this.lbl_ArquivoOriginal.TabIndex = 9;
            this.lbl_ArquivoOriginal.Text = "Arquivo Original";
            // 
            // lbl_ArquivoMapeado
            // 
            this.lbl_ArquivoMapeado.AutoSize = true;
            this.lbl_ArquivoMapeado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArquivoMapeado.Location = new System.Drawing.Point(696, 174);
            this.lbl_ArquivoMapeado.Name = "lbl_ArquivoMapeado";
            this.lbl_ArquivoMapeado.Size = new System.Drawing.Size(225, 31);
            this.lbl_ArquivoMapeado.TabIndex = 10;
            this.lbl_ArquivoMapeado.Text = "Arquivo Mapeado";
            // 
            // Lbl_mapLoad
            // 
            this.Lbl_mapLoad.AutoSize = true;
            this.Lbl_mapLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mapLoad.Location = new System.Drawing.Point(12, 112);
            this.Lbl_mapLoad.Name = "Lbl_mapLoad";
            this.Lbl_mapLoad.Size = new System.Drawing.Size(0, 17);
            this.Lbl_mapLoad.TabIndex = 11;
            // 
            // Btn_Limpa
            // 
            this.Btn_Limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpa.Location = new System.Drawing.Point(938, 20);
            this.Btn_Limpa.Name = "Btn_Limpa";
            this.Btn_Limpa.Size = new System.Drawing.Size(123, 51);
            this.Btn_Limpa.TabIndex = 12;
            this.Btn_Limpa.Text = "Limpar";
            this.Btn_Limpa.UseVisualStyleBackColor = true;
            this.Btn_Limpa.Click += new System.EventHandler(this.Btn_Limpa_Click);
            // 
            // checkB_CrossID
            // 
            this.checkB_CrossID.AutoSize = true;
            this.checkB_CrossID.Location = new System.Drawing.Point(801, 86);
            this.checkB_CrossID.Name = "checkB_CrossID";
            this.checkB_CrossID.Size = new System.Drawing.Size(66, 17);
            this.checkB_CrossID.TabIndex = 13;
            this.checkB_CrossID.Text = "Cross ID";
            this.checkB_CrossID.UseVisualStyleBackColor = true;
            this.checkB_CrossID.CheckedChanged += new System.EventHandler(this.checkB_CrossID_CheckedChanged);
            // 
            // Lbl_CrossID
            // 
            this.Lbl_CrossID.AutoSize = true;
            this.Lbl_CrossID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CrossID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lbl_CrossID.Location = new System.Drawing.Point(12, 83);
            this.Lbl_CrossID.Name = "Lbl_CrossID";
            this.Lbl_CrossID.Size = new System.Drawing.Size(84, 18);
            this.Lbl_CrossID.TabIndex = 14;
            this.Lbl_CrossID.Text = "CROSS ID:";
            // 
            // Lbl_DiretorioCrossID
            // 
            this.Lbl_DiretorioCrossID.Enabled = false;
            this.Lbl_DiretorioCrossID.Location = new System.Drawing.Point(235, 83);
            this.Lbl_DiretorioCrossID.Name = "Lbl_DiretorioCrossID";
            this.Lbl_DiretorioCrossID.ReadOnly = true;
            this.Lbl_DiretorioCrossID.Size = new System.Drawing.Size(461, 20);
            this.Lbl_DiretorioCrossID.TabIndex = 15;
            this.Lbl_DiretorioCrossID.TextChanged += new System.EventHandler(this.Lbl_DiretorioCrossID_TextChanged);
            // 
            // Btn_CrossID
            // 
            this.Btn_CrossID.Enabled = false;
            this.Btn_CrossID.Location = new System.Drawing.Point(702, 83);
            this.Btn_CrossID.Name = "Btn_CrossID";
            this.Btn_CrossID.Size = new System.Drawing.Size(86, 20);
            this.Btn_CrossID.TabIndex = 16;
            this.Btn_CrossID.Text = "Buscar";
            this.Btn_CrossID.UseVisualStyleBackColor = true;
            this.Btn_CrossID.Click += new System.EventHandler(this.Btn_CrossID_Click);
            // 
            // checkB_JSON
            // 
            this.checkB_JSON.AutoSize = true;
            this.checkB_JSON.Location = new System.Drawing.Point(873, 86);
            this.checkB_JSON.Name = "checkB_JSON";
            this.checkB_JSON.Size = new System.Drawing.Size(84, 17);
            this.checkB_JSON.TabIndex = 17;
            this.checkB_JSON.Text = "Mapa JSON";
            this.checkB_JSON.UseVisualStyleBackColor = true;
            this.checkB_JSON.CheckedChanged += new System.EventHandler(this.checkB_JSON_CheckedChanged);
            // 
            // Fmr_TestadorDLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1073, 637);
            this.Controls.Add(this.checkB_JSON);
            this.Controls.Add(this.Btn_CrossID);
            this.Controls.Add(this.Lbl_DiretorioCrossID);
            this.Controls.Add(this.Lbl_CrossID);
            this.Controls.Add(this.checkB_CrossID);
            this.Controls.Add(this.Btn_Limpa);
            this.Controls.Add(this.Lbl_mapLoad);
            this.Controls.Add(this.lbl_ArquivoMapeado);
            this.Controls.Add(this.lbl_ArquivoOriginal);
            this.Controls.Add(this.Btn_TestaDLL);
            this.Controls.Add(this.Txt_ConteudoArquivoMapeado);
            this.Controls.Add(this.Txt_ConteudoArquivoOriginal);
            this.Controls.Add(this.Btn_BuscarArquivoEntrada);
            this.Controls.Add(this.Btn_BuscarDLL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_DiretorioINPUT);
            this.Controls.Add(this.Lbl_DiretorioDLL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fmr_TestadorDLL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste DLL";
            this.Load += new System.EventHandler(this.Fmr_TestadorDLL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DiretorioDLL;
        private System.Windows.Forms.Label Lbl_DiretorioINPUT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog FileDialog_ArquivoEntrada;
        private System.Windows.Forms.Button Btn_BuscarDLL;
        private System.Windows.Forms.Button Btn_BuscarArquivoEntrada;
        private System.Windows.Forms.OpenFileDialog FileDialog_DLL;
        private System.Windows.Forms.TextBox Txt_ConteudoArquivoOriginal;
        private System.Windows.Forms.TextBox Txt_ConteudoArquivoMapeado;
        private System.Windows.Forms.Button Btn_TestaDLL;
        private System.Windows.Forms.Label lbl_ArquivoOriginal;
        private System.Windows.Forms.Label lbl_ArquivoMapeado;
        private System.Windows.Forms.Label Lbl_mapLoad;
        private System.Windows.Forms.Button Btn_Limpa;
        private System.Windows.Forms.CheckBox checkB_CrossID;
        private System.Windows.Forms.Label Lbl_CrossID;
        private System.Windows.Forms.TextBox Lbl_DiretorioCrossID;
        private System.Windows.Forms.Button Btn_CrossID;
        private System.Windows.Forms.CheckBox checkB_JSON;
    }
}

