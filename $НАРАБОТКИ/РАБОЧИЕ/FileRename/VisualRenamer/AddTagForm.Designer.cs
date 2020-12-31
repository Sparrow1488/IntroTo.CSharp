
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.exceprionPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.textBox4);
            this.leftPanel.Controls.Add(this.textBox3);
            this.leftPanel.Controls.Add(this.deleteBtn);
            this.leftPanel.Controls.Add(this.exceprionPanel);
            this.leftPanel.Controls.Add(this.addTagBtn);
            this.leftPanel.Controls.Add(this.textBox1);
            this.leftPanel.Controls.Add(this.textBox2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(3);
            this.leftPanel.Size = new System.Drawing.Size(200, 282);
            this.leftPanel.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(3, 74);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(194, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exceprionPanel
            // 
            this.exceprionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exceprionPanel.Controls.Add(this.exceptionAcceptBtn);
            this.exceprionPanel.Controls.Add(this.exceptionText);
            this.exceprionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exceprionPanel.Location = new System.Drawing.Point(3, 196);
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
            this.listBox1.Size = new System.Drawing.Size(133, 276);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.listBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(337, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.rightPanel.Size = new System.Drawing.Size(139, 282);
            this.rightPanel.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(131, 276);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(137, 282);
            this.panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(3, 97);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(194, 42);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Write name collection to add it in project:";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Location = new System.Drawing.Point(3, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add collection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 282);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}