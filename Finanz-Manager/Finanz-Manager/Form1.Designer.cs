
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kontenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonChooseAccount = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.time,
            this.Description,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kontenToolStripMenuItem
            // 
            this.kontenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesKontoToolStripMenuItem,
            this.kontenToolStripMenuItem1});
            this.kontenToolStripMenuItem.Name = "kontenToolStripMenuItem";
            this.kontenToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kontenToolStripMenuItem.Text = "Konten";
            // 
            // neuesKontoToolStripMenuItem
            // 
            this.neuesKontoToolStripMenuItem.Name = "neuesKontoToolStripMenuItem";
            this.neuesKontoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.neuesKontoToolStripMenuItem.Text = "Neues Konto";
            this.neuesKontoToolStripMenuItem.Click += new System.EventHandler(this.neuesKontoToolStripMenuItem_Click);
            // 
            // kontenToolStripMenuItem1
            // 
            this.kontenToolStripMenuItem1.Name = "kontenToolStripMenuItem1";
            this.kontenToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.kontenToolStripMenuItem1.Text = "Konten";
            this.kontenToolStripMenuItem1.Click += new System.EventHandler(this.kontenToolStripMenuItem1_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(12, 24);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(50, 15);
            this.labelAccountName.TabIndex = 2;
            this.labelAccountName.Text = "Konto: -";
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Location = new System.Drawing.Point(794, 42);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(92, 46);
            this.buttonTransaction.TabIndex = 3;
            this.buttonTransaction.Text = "Neue Transaktion";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(794, 146);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(90, 46);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.Text = "Übertrag";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonChooseAccount
            // 
            this.buttonChooseAccount.Location = new System.Drawing.Point(794, 406);
            this.buttonChooseAccount.Name = "buttonChooseAccount";
            this.buttonChooseAccount.Size = new System.Drawing.Size(92, 31);
            this.buttonChooseAccount.TabIndex = 6;
            this.buttonChooseAccount.Text = "Konto wählen";
            this.buttonChooseAccount.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.HeaderText = "Zeit";
            this.time.Name = "time";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 449);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonTransaction);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonChooseAccount);
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
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.ToolStripMenuItem kontenToolStripMenuItem1;
        private System.Windows.Forms.Button buttonChooseAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

