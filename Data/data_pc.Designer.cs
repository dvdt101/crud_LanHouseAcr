namespace conexão
{
    partial class data_pc
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
            this.grid_pc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_pc
            // 
            this.grid_pc.AllowUserToAddRows = false;
            this.grid_pc.AllowUserToDeleteRows = false;
            this.grid_pc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_pc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pc.Location = new System.Drawing.Point(3, 12);
            this.grid_pc.Name = "grid_pc";
            this.grid_pc.ReadOnly = true;
            this.grid_pc.Size = new System.Drawing.Size(517, 397);
            this.grid_pc.TabIndex = 0;
            this.grid_pc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_pc_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exibir dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_pc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_pc);
            this.Name = "data_pc";
            this.Text = "data_pc";
            this.Load += new System.EventHandler(this.data_pc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_pc;
        private System.Windows.Forms.Button button1;
    }
}