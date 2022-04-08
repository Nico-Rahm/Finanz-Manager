
namespace Finanz_Manager
{
    partial class NewTransaction
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
            this.radioButtonTaking = new System.Windows.Forms.RadioButton();
            this.radioButtonSpending = new System.Windows.Forms.RadioButton();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDesctiption = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // radioButtonTaking
            // 
            this.radioButtonTaking.AutoSize = true;
            this.radioButtonTaking.Location = new System.Drawing.Point(12, 12);
            this.radioButtonTaking.Name = "radioButtonTaking";
            this.radioButtonTaking.Size = new System.Drawing.Size(95, 24);
            this.radioButtonTaking.TabIndex = 0;
            this.radioButtonTaking.TabStop = true;
            this.radioButtonTaking.Text = "Einnahme";
            this.radioButtonTaking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpending
            // 
            this.radioButtonSpending.AutoSize = true;
            this.radioButtonSpending.Location = new System.Drawing.Point(12, 42);
            this.radioButtonSpending.Name = "radioButtonSpending";
            this.radioButtonSpending.Size = new System.Drawing.Size(88, 24);
            this.radioButtonSpending.TabIndex = 1;
            this.radioButtonSpending.TabStop = true;
            this.radioButtonSpending.Text = "Ausgabe";
            this.radioButtonSpending.UseVisualStyleBackColor = true;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(145, 14);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(52, 20);
            this.labelAccount.TabIndex = 2;
            this.labelAccount.Text = "Konto:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(145, 108);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(125, 27);
            this.textBoxAmount.TabIndex = 3;
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(145, 41);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(229, 28);
            this.comboBoxAccount.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(33, 111);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 20);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Betrag:";
            // 
            // labelDesctiption
            // 
            this.labelDesctiption.AutoSize = true;
            this.labelDesctiption.Location = new System.Drawing.Point(33, 144);
            this.labelDesctiption.Name = "labelDesctiption";
            this.labelDesctiption.Size = new System.Drawing.Size(96, 20);
            this.labelDesctiption.TabIndex = 7;
            this.labelDesctiption.Text = "Bezeichnung:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(145, 141);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(229, 122);
            this.textBoxDescription.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(280, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 317);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelDesctiption);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxAccount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.radioButtonSpending);
            this.Controls.Add(this.radioButtonTaking);
            this.Name = "NewTransaction";
            this.Text = "Neue Transaktion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonTaking;
        private System.Windows.Forms.RadioButton radioButtonSpending;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDesctiption;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}