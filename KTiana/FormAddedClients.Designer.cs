﻿namespace KTiana
{
    partial class FormAddedClients
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(12, 83);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(211, 21);
            this.comboBoxWorkers.TabIndex = 1;
            this.comboBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkers_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client,
            this.Worker});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(242, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 197);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            this.Client.Width = 91;
            // 
            // Worker
            // 
            this.Worker.Text = "Сотрудник";
            this.Worker.Width = 107;
            // 
            // FormAddedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 274);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxWorkers);
            this.Controls.Add(this.label1);
            this.Name = "FormAddedClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавленные клиенты";
            this.Load += new System.EventHandler(this.FormAddedClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Worker;
    }
}