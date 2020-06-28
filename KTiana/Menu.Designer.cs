namespace KTiana
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonAddedClients = new System.Windows.Forms.Button();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgents
            // 
            this.buttonAgents.Location = new System.Drawing.Point(31, 69);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(113, 50);
            this.buttonAgents.TabIndex = 0;
            this.buttonAgents.Text = "Сотрудники";
            this.buttonAgents.UseVisualStyleBackColor = true;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(31, 124);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(113, 50);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Location = new System.Drawing.Point(31, 180);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(113, 50);
            this.buttonServices.TabIndex = 2;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.Location = new System.Drawing.Point(31, 236);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(113, 50);
            this.buttonContracts.TabIndex = 3;
            this.buttonContracts.Text = "Договоры";
            this.buttonContracts.UseVisualStyleBackColor = true;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonAddedClients
            // 
            this.buttonAddedClients.Location = new System.Drawing.Point(150, 69);
            this.buttonAddedClients.Name = "buttonAddedClients";
            this.buttonAddedClients.Size = new System.Drawing.Size(113, 50);
            this.buttonAddedClients.TabIndex = 4;
            this.buttonAddedClients.Text = "Добавленные клиенты";
            this.buttonAddedClients.UseVisualStyleBackColor = true;
            this.buttonAddedClients.Click += new System.EventHandler(this.buttonAddedClients_Click);
            // 
            // buttonSalary
            // 
            this.buttonSalary.Location = new System.Drawing.Point(150, 124);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(113, 50);
            this.buttonSalary.TabIndex = 5;
            this.buttonSalary.Text = "Зарплата";
            this.buttonSalary.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 340);
            this.Controls.Add(this.buttonSalary);
            this.Controls.Add(this.buttonAddedClients);
            this.Controls.Add(this.buttonContracts);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonAgents);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonAddedClients;
        private System.Windows.Forms.Button buttonSalary;
    }
}

