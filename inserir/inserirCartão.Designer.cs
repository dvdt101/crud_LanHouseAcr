namespace conexão
{
    partial class inserirCartão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inserirCartão));
            this.label1 = new System.Windows.Forms.Label();
            this.idcard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idclient = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.foundClient = new System.Windows.Forms.TextBox();
            this.Procurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id cartão:";
            // 
            // idcard
            // 
            this.idcard.Location = new System.Drawing.Point(67, 57);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(34, 20);
            this.idcard.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(58, 86);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(61, 20);
            this.saldo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id cliente:";
            // 
            // idclient
            // 
            this.idclient.Location = new System.Drawing.Point(67, 116);
            this.idclient.Name = "idclient";
            this.idclient.Size = new System.Drawing.Size(31, 20);
            this.idclient.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(181, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 60);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preencha os campos abaixo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Digite cpf ou cnpj do cliente ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Para descobrir a Id do cliente dono do cartão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Digite Aqui:";
            // 
            // foundClient
            // 
            this.foundClient.Location = new System.Drawing.Point(76, 235);
            this.foundClient.Name = "foundClient";
            this.foundClient.Size = new System.Drawing.Size(149, 20);
            this.foundClient.TabIndex = 11;
            // 
            // Procurar
            // 
            this.Procurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Procurar.BackgroundImage")));
            this.Procurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Procurar.Location = new System.Drawing.Point(231, 226);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(46, 37);
            this.Procurar.TabIndex = 12;
            this.Procurar.UseVisualStyleBackColor = true;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // inserirCartão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 326);
            this.Controls.Add(this.Procurar);
            this.Controls.Add(this.foundClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idclient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inserirCartão";
            this.Text = "inserirCartão";
            this.Load += new System.EventHandler(this.inserirCartão_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idcard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idclient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox foundClient;
        private System.Windows.Forms.Button Procurar;
    }
}