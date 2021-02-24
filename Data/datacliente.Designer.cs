namespace conexão
{
    partial class datacliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datacliente));
            this.data_client = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_client)).BeginInit();
            this.SuspendLayout();
            // 
            // data_client
            // 
            this.data_client.AllowUserToAddRows = false;
            this.data_client.AllowUserToDeleteRows = false;
            this.data_client.AllowUserToResizeColumns = false;
            this.data_client.AllowUserToResizeRows = false;
            this.data_client.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_client.Location = new System.Drawing.Point(12, 12);
            this.data_client.Name = "data_client";
            this.data_client.ReadOnly = true;
            this.data_client.Size = new System.Drawing.Size(856, 352);
            this.data_client.TabIndex = 0;
            this.data_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_client_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exibir Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "datacliente";
            this.Text = "datacliente";
            this.Load += new System.EventHandler(this.datacliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_client;
        private System.Windows.Forms.Button button1;
    }
}