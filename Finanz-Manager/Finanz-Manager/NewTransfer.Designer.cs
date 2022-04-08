
namespace Finanz_Manager
{
    partial class NewTransfer
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
            this.labelSourceAccount = new System.Windows.Forms.Label();
            this.comboBoxSourceAccount = new System.Windows.Forms.ComboBox();
            this.comboBoxTargetAccount = new System.Windows.Forms.ComboBox();
            this.labelTargetAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSourceAccount
            // 
            this.labelSourceAccount.AutoSize = true;
            this.labelSourceAccount.Location = new System.Drawing.Point(12, 15);
            this.labelSourceAccount.Name = "labelSourceAccount";
            this.labelSourceAccount.Size = new System.Drawing.Size(85, 20);
            this.labelSourceAccount.TabIndex = 0;
            this.labelSourceAccount.Text = "Quellkonto:";
            // 
            // comboBoxSourceAccount
            // 
            this.comboBoxSourceAccount.FormattingEnabled = true;
            this.comboBoxSourceAccount.Location = new System.Drawing.Point(103, 12);
            this.comboBoxSourceAccount.Name = "comboBoxSourceAccount";
            this.comboBoxSourceAccount.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSourceAccount.TabIndex = 1;
            // 
            // comboBoxTargetAccount
            // 
            this.comboBoxTargetAccount.FormattingEnabled = true;
            this.comboBoxTargetAccount.Location = new System.Drawing.Point(103, 46);
            this.comboBoxTargetAccount.Name = "comboBoxTargetAccount";
            this.comboBoxTargetAccount.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTargetAccount.TabIndex = 2;
            // 
            // labelTargetAccount
            // 
            this.labelTargetAccount.AutoSize = true;
            this.labelTargetAccount.Location = new System.Drawing.Point(12, 49);
            this.labelTargetAccount.Name = "labelTargetAccount";
            this.labelTargetAccount.Size = new System.Drawing.Size(75, 20);
            this.labelTargetAccount.TabIndex = 3;
            this.labelTargetAccount.Text = "Zielkonto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Betrag:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(103, 113);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(151, 27);
            this.textBoxAmount.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(168, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 172);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(242, 104);
            this.textBoxDescription.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 149);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(101, 20);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Beschreibung:";
            // 
            // NewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 322);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTargetAccount);
            this.Controls.Add(this.comboBoxTargetAccount);
            this.Controls.Add(this.comboBoxSourceAccount);
            this.Controls.Add(this.labelSourceAccount);
            this.Name = "NewTransfer";
            this.Text = "Übertrag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceAccount;
        private System.Windows.Forms.ComboBox comboBoxSourceAccount;
        private System.Windows.Forms.ComboBox comboBoxTargetAccount;
        private System.Windows.Forms.Label labelTargetAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}