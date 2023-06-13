namespace Union_of_the_Contents___Revision_for_the_Test
{
    partial class Form1
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
            this.rb_masc = new System.Windows.Forms.RadioButton();
            this.rb_fem = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_calc = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_peso = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.mask_alt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ck_materias = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_imc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_masc
            // 
            this.rb_masc.AutoSize = true;
            this.rb_masc.Location = new System.Drawing.Point(527, 133);
            this.rb_masc.Name = "rb_masc";
            this.rb_masc.Size = new System.Drawing.Size(89, 20);
            this.rb_masc.TabIndex = 0;
            this.rb_masc.TabStop = true;
            this.rb_masc.Text = "Masculino";
            this.rb_masc.UseVisualStyleBackColor = true;
            // 
            // rb_fem
            // 
            this.rb_fem.AutoSize = true;
            this.rb_fem.Location = new System.Drawing.Point(527, 159);
            this.rb_fem.Name = "rb_fem";
            this.rb_fem.Size = new System.Drawing.Size(83, 20);
            this.rb_fem.TabIndex = 1;
            this.rb_fem.TabStop = true;
            this.rb_fem.Text = "Feminino";
            this.rb_fem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha seu sexo:";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(527, 383);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(169, 71);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(214, 383);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(169, 71);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_calc
            // 
            this.bt_calc.Location = new System.Drawing.Point(530, 283);
            this.bt_calc.Name = "bt_calc";
            this.bt_calc.Size = new System.Drawing.Size(166, 50);
            this.bt_calc.TabIndex = 5;
            this.bt_calc.Text = "IMC";
            this.bt_calc.UseVisualStyleBackColor = true;
            this.bt_calc.Click += new System.EventHandler(this.bt_calc_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(214, 133);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 22);
            this.tx_nome.TabIndex = 6;
            // 
            // tx_peso
            // 
            this.tx_peso.Location = new System.Drawing.Point(214, 272);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(100, 22);
            this.tx_peso.TabIndex = 8;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(211, 101);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 16);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Nome";
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.Location = new System.Drawing.Point(211, 181);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(41, 16);
            this.lb_altura.TabIndex = 10;
            this.lb_altura.Text = "Altura";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.Location = new System.Drawing.Point(211, 243);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(39, 16);
            this.lb_peso.TabIndex = 11;
            this.lb_peso.Text = "Peso";
            // 
            // mask_alt
            // 
            this.mask_alt.Location = new System.Drawing.Point(214, 211);
            this.mask_alt.Mask = "0.00";
            this.mask_alt.Name = "mask_alt";
            this.mask_alt.Size = new System.Drawing.Size(100, 22);
            this.mask_alt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 78);
            this.label2.TabIndex = 13;
            this.label2.Text = "Revision";
            // 
            // ck_materias
            // 
            this.ck_materias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ck_materias.FormattingEnabled = true;
            this.ck_materias.Items.AddRange(new object[] {
            "Matemática",
            "Ciências",
            "Português",
            "Progrmação Orientada a Objetos"});
            this.ck_materias.Location = new System.Drawing.Point(814, 165);
            this.ck_materias.Name = "ck_materias";
            this.ck_materias.Size = new System.Drawing.Size(265, 94);
            this.ck_materias.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Assinale as matérias que tem no seu curso:";
            // 
            // lb_imc
            // 
            this.lb_imc.AutoSize = true;
            this.lb_imc.Location = new System.Drawing.Point(527, 216);
            this.lb_imc.Name = "lb_imc";
            this.lb_imc.Size = new System.Drawing.Size(0, 16);
            this.lb_imc.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_imc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ck_materias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mask_alt);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.bt_calc);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_fem);
            this.Controls.Add(this.rb_masc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_masc;
        private System.Windows.Forms.RadioButton rb_fem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_calc;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_peso;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.MaskedTextBox mask_alt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ck_materias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_imc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

