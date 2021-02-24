namespace conexão
{
    partial class inserir_aluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inserir_aluguel));
            this.idaluguel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valordes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipopag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idfuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tempoA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idcard = new System.Windows.Forms.TextBox();
            this.gridpc = new System.Windows.Forms.DataGridView();
            this.grid_aluguelpc = new System.Windows.Forms.DataGridView();
            this.pc_nivel = new System.Windows.Forms.ComboBox();
            this.adcionar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.id_pc_adc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.delete_select = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aluguelpc)).BeginInit();
            this.SuspendLayout();
            // 
            // idaluguel
            // 
            this.idaluguel.Location = new System.Drawing.Point(324, 72);
            this.idaluguel.Name = "idaluguel";
            this.idaluguel.Size = new System.Drawing.Size(35, 20);
            this.idaluguel.TabIndex = 0;
            this.idaluguel.TextChanged += new System.EventHandler(this.idaluguel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Aluguel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(534, 126);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(72, 20);
            this.valor.TabIndex = 3;
            this.valor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Desconto:";
            // 
            // valordes
            // 
            this.valordes.Location = new System.Drawing.Point(534, 160);
            this.valordes.Name = "valordes";
            this.valordes.Size = new System.Drawing.Size(72, 20);
            this.valordes.TabIndex = 5;
            this.valordes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Pagamento:";
            // 
            // tipopag
            // 
            this.tipopag.Location = new System.Drawing.Point(156, 114);
            this.tipopag.Name = "tipopag";
            this.tipopag.Size = new System.Drawing.Size(59, 20);
            this.tipopag.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo Aluguel:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(324, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 57);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id Funcionario Envolvido";
            // 
            // idfuc
            // 
            this.idfuc.Location = new System.Drawing.Point(156, 88);
            this.idfuc.Name = "idfuc";
            this.idfuc.Size = new System.Drawing.Size(35, 20);
            this.idfuc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(612, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ex.:17:15:14";
            // 
            // tempoA
            // 
            this.tempoA.Location = new System.Drawing.Point(534, 84);
            this.tempoA.Name = "tempoA";
            this.tempoA.Size = new System.Drawing.Size(100, 20);
            this.tempoA.TabIndex = 17;
            this.tempoA.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Realizar Aluguel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(503, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 9);
            this.label9.TabIndex = 19;
            this.label9.Text = "obs.: Data e Hora dos alugueis são cadastradas ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(468, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 9);
            this.label10.TabIndex = 20;
            this.label10.Text = "automaticamente no banco de dados de acordo com a data e hora atual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id cartão cliente:";
            // 
            // idcard
            // 
            this.idcard.Location = new System.Drawing.Point(153, 137);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(38, 20);
            this.idcard.TabIndex = 22;
            this.idcard.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridpc
            // 
            this.gridpc.AllowUserToAddRows = false;
            this.gridpc.AllowUserToDeleteRows = false;
            this.gridpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpc.Location = new System.Drawing.Point(12, 229);
            this.gridpc.Name = "gridpc";
            this.gridpc.ReadOnly = true;
            this.gridpc.Size = new System.Drawing.Size(240, 150);
            this.gridpc.TabIndex = 23;
            // 
            // grid_aluguelpc
            // 
            this.grid_aluguelpc.AllowUserToAddRows = false;
            this.grid_aluguelpc.AllowUserToDeleteRows = false;
            this.grid_aluguelpc.AllowUserToResizeColumns = false;
            this.grid_aluguelpc.AllowUserToResizeRows = false;
            this.grid_aluguelpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aluguelpc.Location = new System.Drawing.Point(432, 229);
            this.grid_aluguelpc.Name = "grid_aluguelpc";
            this.grid_aluguelpc.ReadOnly = true;
            this.grid_aluguelpc.Size = new System.Drawing.Size(299, 150);
            this.grid_aluguelpc.TabIndex = 24;
            this.grid_aluguelpc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aluguelpc_CellContentClick);
            // 
            // pc_nivel
            // 
            this.pc_nivel.FormattingEnabled = true;
            this.pc_nivel.Location = new System.Drawing.Point(94, 202);
            this.pc_nivel.Name = "pc_nivel";
            this.pc_nivel.Size = new System.Drawing.Size(41, 21);
            this.pc_nivel.TabIndex = 25;
            // 
            // adcionar
            // 
            this.adcionar.Location = new System.Drawing.Point(281, 287);
            this.adcionar.Name = "adcionar";
            this.adcionar.Size = new System.Drawing.Size(145, 23);
            this.adcionar.TabIndex = 26;
            this.adcionar.Text = "Adicionar Computador";
            this.adcionar.UseVisualStyleBackColor = true;
            this.adcionar.Click += new System.EventHandler(this.adcionar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Id Computador:";
            // 
            // id_pc_adc
            // 
            this.id_pc_adc.Location = new System.Drawing.Point(335, 261);
            this.id_pc_adc.Name = "id_pc_adc";
            this.id_pc_adc.Size = new System.Drawing.Size(36, 20);
            this.id_pc_adc.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Procurar Computadores Disponiveis:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nivel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Computadores Adicionados";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(140, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(482, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Desfazer seleção:";
            // 
            // delete_select
            // 
            this.delete_select.Location = new System.Drawing.Point(580, 386);
            this.delete_select.Name = "delete_select";
            this.delete_select.Size = new System.Drawing.Size(34, 20);
            this.delete_select.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 22);
            this.button3.TabIndex = 35;
            this.button3.Text = "remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(12, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // inserir_aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 439);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete_select);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.id_pc_adc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.adcionar);
            this.Controls.Add(this.pc_nivel);
            this.Controls.Add(this.grid_aluguelpc);
            this.Controls.Add(this.gridpc);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tempoA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idfuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipopag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valordes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idaluguel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inserir_aluguel";
            this.Text = "inserir_aluguel";
            this.Load += new System.EventHandler(this.inserir_aluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aluguelpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idaluguel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valordes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipopag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idfuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tempoA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idcard;
        private System.Windows.Forms.DataGridView gridpc;
        private System.Windows.Forms.DataGridView grid_aluguelpc;
        private System.Windows.Forms.ComboBox pc_nivel;
        private System.Windows.Forms.Button adcionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_pc_adc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox delete_select;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}