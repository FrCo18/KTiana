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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сотрудники";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сотрудники";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 298);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

