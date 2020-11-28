
namespace NewsBlog
{
    partial class MainBlogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AthtorTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.editNewsButton = new System.Windows.Forms.Button();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addNewsButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AthtorTextBox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.editNewsButton);
            this.panel1.Controls.Add(this.titleTextBox1);
            this.panel1.Controls.Add(this.descriptionTextBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 355);
            this.panel1.TabIndex = 0;
            // 
            // AthtorTextBox
            // 
            this.AthtorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AthtorTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthtorTextBox.Location = new System.Drawing.Point(455, 326);
            this.AthtorTextBox.Name = "AthtorTextBox";
            this.AthtorTextBox.ReadOnly = true;
            this.AthtorTextBox.Size = new System.Drawing.Size(128, 17);
            this.AthtorTextBox.TabIndex = 7;
            this.AthtorTextBox.Text = "Автор: Anon";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(611, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "R";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // editNewsButton
            // 
            this.editNewsButton.BackColor = System.Drawing.Color.Thistle;
            this.editNewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNewsButton.Location = new System.Drawing.Point(559, 3);
            this.editNewsButton.Name = "editNewsButton";
            this.editNewsButton.Size = new System.Drawing.Size(75, 23);
            this.editNewsButton.TabIndex = 5;
            this.editNewsButton.Text = "Edit";
            this.editNewsButton.UseVisualStyleBackColor = false;
            this.editNewsButton.Visible = false;
            this.editNewsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox1.Location = new System.Drawing.Point(14, 6);
            this.titleTextBox1.Multiline = true;
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.ReadOnly = true;
            this.titleTextBox1.Size = new System.Drawing.Size(539, 48);
            this.titleTextBox1.TabIndex = 4;
            this.titleTextBox1.Text = "Заголовок 1";
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox1.Location = new System.Drawing.Point(14, 60);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.ReadOnly = true;
            this.descriptionTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox1.Size = new System.Drawing.Size(613, 260);
            this.descriptionTextBox1.TabIndex = 3;
            this.descriptionTextBox1.Text = "Основной текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Проверка";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(550, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addNewsButton1
            // 
            this.addNewsButton1.BackColor = System.Drawing.Color.Thistle;
            this.addNewsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewsButton1.Location = new System.Drawing.Point(118, 391);
            this.addNewsButton1.Name = "addNewsButton1";
            this.addNewsButton1.Size = new System.Drawing.Size(154, 23);
            this.addNewsButton1.TabIndex = 2;
            this.addNewsButton1.Text = "Добавить новость";
            this.addNewsButton1.UseVisualStyleBackColor = false;
            this.addNewsButton1.Visible = false;
            this.addNewsButton1.Click += new System.EventHandler(this.addNewsButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(397, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Читать последние";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeFormButton.Location = new System.Drawing.Point(609, 3);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(25, 23);
            this.closeFormButton.TabIndex = 5;
            this.closeFormButton.Text = "X";
            this.closeFormButton.UseVisualStyleBackColor = false;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.closeFormButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 29);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Главное меню";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Проверка";
            this.label1.Visible = false;
            // 
            // MainBlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(637, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewsButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainBlogForm";
            this.Text = "MainBlogForm";
            this.Load += new System.EventHandler(this.MainBlogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addNewsButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editNewsButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AthtorTextBox;
        private System.Windows.Forms.Label label4;
    }
}