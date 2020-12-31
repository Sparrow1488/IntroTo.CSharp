
namespace VisualRenamer
{
    partial class AddTagForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exceprionPanel = new System.Windows.Forms.Panel();
            this.exceptionAcceptBtn = new System.Windows.Forms.Button();
            this.exceptionText = new System.Windows.Forms.TextBox();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.exceprionPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 48);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Write name tag to add it in tags list:";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.deleteBtn);
            this.leftPanel.Controls.Add(this.exceprionPanel);
            this.leftPanel.Controls.Add(this.addTagBtn);
            this.leftPanel.Controls.Add(this.textBox1);
            this.leftPanel.Controls.Add(this.textBox2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(3);
            this.leftPanel.Size = new System.Drawing.Size(200, 232);
            this.leftPanel.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(3, 77);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exceprionPanel
            // 
            this.exceprionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exceprionPanel.Controls.Add(this.exceptionAcceptBtn);
            this.exceprionPanel.Controls.Add(this.exceptionText);
            this.exceprionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exceprionPanel.Location = new System.Drawing.Point(3, 146);
            this.exceprionPanel.Name = "exceprionPanel";
            this.exceprionPanel.Size = new System.Drawing.Size(194, 83);
            this.exceprionPanel.TabIndex = 3;
            this.exceprionPanel.Visible = false;
            // 
            // exceptionAcceptBtn
            // 
            this.exceptionAcceptBtn.Location = new System.Drawing.Point(116, 57);
            this.exceptionAcceptBtn.Name = "exceptionAcceptBtn";
            this.exceptionAcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.exceptionAcceptBtn.TabIndex = 5;
            this.exceptionAcceptBtn.Text = "Принял";
            this.exceptionAcceptBtn.UseVisualStyleBackColor = true;
            this.exceptionAcceptBtn.Click += new System.EventHandler(this.exceptionAcceptBtn_Click);
            // 
            // exceptionText
            // 
            this.exceptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exceptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceptionText.Dock = System.Windows.Forms.DockStyle.Left;
            this.exceptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exceptionText.Location = new System.Drawing.Point(0, 0);
            this.exceptionText.MaxLength = 100;
            this.exceptionText.Multiline = true;
            this.exceptionText.Name = "exceptionText";
            this.exceptionText.ReadOnly = true;
            this.exceptionText.Size = new System.Drawing.Size(191, 83);
            this.exceptionText.TabIndex = 4;
            this.exceptionText.Text = "Возможно, Вы вели некорректный тэг, либо он уже существует";
            // 
            // addTagBtn
            // 
            this.addTagBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagBtn.Location = new System.Drawing.Point(3, 51);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(194, 23);
            this.addTagBtn.TabIndex = 2;
            this.addTagBtn.Text = "Add tag";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 226);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.listBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.rightPanel.Size = new System.Drawing.Size(161, 232);
            this.rightPanel.TabIndex = 4;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 232);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddTagForm";
            this.Text = "AddTagForm";
            this.Load += new System.EventHandler(this.AddTagForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.exceprionPanel.ResumeLayout(false);
            this.exceprionPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addTagBtn;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel exceprionPanel;
        private System.Windows.Forms.TextBox exceptionText;
        private System.Windows.Forms.Button exceptionAcceptBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}