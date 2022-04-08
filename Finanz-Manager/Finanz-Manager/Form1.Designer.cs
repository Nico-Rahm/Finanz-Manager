
namespace Finanz_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kontenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBVerbindungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Description,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(14, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Datum";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Uhrzeit";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Beschreibung";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 450;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Betrag";
            this.Amount.MinimumWidth = 100;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1024, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kontenToolStripMenuItem
            // 
            this.kontenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesKontoToolStripMenuItem});
            this.kontenToolStripMenuItem.Name = "kontenToolStripMenuItem";
            this.kontenToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.kontenToolStripMenuItem.Text = "Konten";
            // 
            // neuesKontoToolStripMenuItem
            // 
            this.neuesKontoToolStripMenuItem.Name = "neuesKontoToolStripMenuItem";
            this.neuesKontoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.neuesKontoToolStripMenuItem.Text = "Neues Konto";
            this.neuesKontoToolStripMenuItem.Click += new System.EventHandler(this.neuesKontoToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBVerbindungToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // dBVerbindungToolStripMenuItem
            // 
            this.dBVerbindungToolStripMenuItem.Name = "dBVerbindungToolStripMenuItem";
            this.dBVerbindungToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.dBVerbindungToolStripMenuItem.Text = "DB-Verbindung";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(14, 32);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(62, 20);
            this.labelAccountName.TabIndex = 2;
            this.labelAccountName.Text = "Konto: -";
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Location = new System.Drawing.Point(907, 56);
            this.buttonTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(105, 61);
            this.buttonTransaction.TabIndex = 3;
            this.buttonTransaction.Text = "Neue Transaktion";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(907, 195);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(86, 61);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.Text = "Übertrag";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 599);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonTransaction);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Finanz-Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kontenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesKontoToolStripMenuItem;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBVerbindungToolStripMenuItem;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button buttonTransfer;
    }
}

