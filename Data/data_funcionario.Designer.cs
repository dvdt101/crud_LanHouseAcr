namespace conexão
{
    partial class data_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_funcionario));
            this.grid_func = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_func)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_func
            // 
            this.grid_func.AllowUserToAddRows = false;
            this.grid_func.AllowUserToDeleteRows = false;
            this.grid_func.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_func.Location = new System.Drawing.Point(12, 12);
            this.grid_func.Name = "grid_func";
            this.grid_func.ReadOnly = true;
            this.grid_func.Size = new System.Drawing.Size(1035, 402);
            this.grid_func.TabIndex = 0;
            this.grid_func.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_func_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exibir Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_func);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "data_funcionario";
            this.Text = "data_funcionario";
            this.Load += new System.EventHandler(this.data_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_func)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_func;
        private System.Windows.Forms.Button button1;
    }
}