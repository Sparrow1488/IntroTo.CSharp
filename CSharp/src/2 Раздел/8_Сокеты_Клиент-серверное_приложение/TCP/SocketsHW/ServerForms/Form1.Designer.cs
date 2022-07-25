
namespace ServerForms
{
    partial class Form1
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
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbWriteCommand = new System.Windows.Forms.TextBox();
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listConnections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(262, 17);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(212, 24);
            this.tbPort.TabIndex = 0;
            // 
            // tbWriteCommand
            // 
            this.tbWriteCommand.Location = new System.Drawing.Point(16, 354);
            this.tbWriteCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWriteCommand.Name = "tbWriteCommand";
            this.tbWriteCommand.Size = new System.Drawing.Size(478, 24);
            this.tbWriteCommand.TabIndex = 1;
            // 
            // tbAnswers
            // 
            this.tbAnswers.Location = new System.Drawing.Point(16, 55);
            this.tbAnswers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.Size = new System.Drawing.Size(348, 289);
            this.tbAnswers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP";
            // 
            // listConnections
            // 
            this.listConnections.FormattingEnabled = true;
            this.listConnections.ItemHeight = 19;
            this.listConnections.Location = new System.Drawing.Point(372, 55);
            this.listConnections.Name = "listConnections";
            this.listConnections.Size = new System.Drawing.Size(120, 289);
            this.listConnections.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 386);
            this.Controls.Add(this.listConnections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnswers);
            this.Controls.Add(this.tbWriteCommand);
            this.Controls.Add(this.tbPort);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbWriteCommand;
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listConnections;
    }
}

