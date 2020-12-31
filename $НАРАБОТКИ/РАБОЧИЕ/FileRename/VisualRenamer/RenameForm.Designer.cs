
namespace VisualRenamer
{
    partial class RenameForm
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
            this.filesList = new System.Windows.Forms.ListBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.getFilesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exceptionPanel = new System.Windows.Forms.Panel();
            this.exceptionAcceptBtn = new System.Windows.Forms.Button();
            this.exceptionText = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.correctExtensionTextBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.renamePanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateCreateTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.exceptionPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.renamePanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 20;
            this.filesList.Location = new System.Drawing.Point(0, 28);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(345, 364);
            this.filesList.TabIndex = 0;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.Location = new System.Drawing.Point(97, 4);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(266, 22);
            this.pathTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.getFilesButton);
            this.panel1.Controls.Add(this.filesList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 392);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(181, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find Files:";
            // 
            // getFilesButton
            // 
            this.getFilesButton.BackColor = System.Drawing.Color.White;
            this.getFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getFilesButton.Location = new System.Drawing.Point(262, 3);
            this.getFilesButton.Name = "getFilesButton";
            this.getFilesButton.Size = new System.Drawing.Size(75, 23);
            this.getFilesButton.TabIndex = 15;
            this.getFilesButton.Text = "GET FILES";
            this.getFilesButton.UseVisualStyleBackColor = false;
            this.getFilesButton.Click += new System.EventHandler(this.getFilesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(345, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 392);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.exceptionPanel);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.renamePanel);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 364);
            this.panel3.TabIndex = 3;
            // 
            // exceptionPanel
            // 
            this.exceptionPanel.BackColor = System.Drawing.Color.LightCoral;
            this.exceptionPanel.Controls.Add(this.exceptionAcceptBtn);
            this.exceptionPanel.Controls.Add(this.exceptionText);
            this.exceptionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exceptionPanel.Location = new System.Drawing.Point(0, 297);
            this.exceptionPanel.Name = "exceptionPanel";
            this.exceptionPanel.Size = new System.Drawing.Size(375, 67);
            this.exceptionPanel.TabIndex = 20;
            this.exceptionPanel.Visible = false;
            // 
            // exceptionAcceptBtn
            // 
            this.exceptionAcceptBtn.Location = new System.Drawing.Point(297, 41);
            this.exceptionAcceptBtn.Name = "exceptionAcceptBtn";
            this.exceptionAcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.exceptionAcceptBtn.TabIndex = 1;
            this.exceptionAcceptBtn.Text = "Принял";
            this.exceptionAcceptBtn.UseVisualStyleBackColor = true;
            this.exceptionAcceptBtn.Click += new System.EventHandler(this.exceptionAcceptBtn_Click);
            // 
            // exceptionText
            // 
            this.exceptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exceptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exceptionText.Location = new System.Drawing.Point(8, 2);
            this.exceptionText.MaxLength = 100;
            this.exceptionText.Multiline = true;
            this.exceptionText.Name = "exceptionText";
            this.exceptionText.ReadOnly = true;
            this.exceptionText.Size = new System.Drawing.Size(274, 62);
            this.exceptionText.TabIndex = 0;
            this.exceptionText.Text = "Exceprion warning text";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 70);
            this.panel8.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.correctExtensionTextBox);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(154, 70);
            this.panel10.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Extension";
            // 
            // correctExtensionTextBox
            // 
            this.correctExtensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctExtensionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctExtensionTextBox.Location = new System.Drawing.Point(82, 4);
            this.correctExtensionTextBox.Name = "correctExtensionTextBox";
            this.correctExtensionTextBox.Size = new System.Drawing.Size(57, 22);
            this.correctExtensionTextBox.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tagsListBox);
            this.panel9.Location = new System.Drawing.Point(154, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 70);
            this.panel9.TabIndex = 18;
            // 
            // tagsListBox
            // 
            this.tagsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 16;
            this.tagsListBox.Location = new System.Drawing.Point(0, 0);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(221, 70);
            this.tagsListBox.TabIndex = 18;
            this.tagsListBox.Visible = false;
            this.tagsListBox.DoubleClick += new System.EventHandler(this.tagsListBox_DoubleClick);
            // 
            // renamePanel
            // 
            this.renamePanel.Controls.Add(this.textBox2);
            this.renamePanel.Controls.Add(this.label11);
            this.renamePanel.Controls.Add(this.button3);
            this.renamePanel.Controls.Add(this.newNameTextBox);
            this.renamePanel.Controls.Add(this.label10);
            this.renamePanel.Location = new System.Drawing.Point(0, 209);
            this.renamePanel.Name = "renamePanel";
            this.renamePanel.Size = new System.Drawing.Size(375, 88);
            this.renamePanel.TabIndex = 19;
            this.renamePanel.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(97, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Result name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(2, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Result name";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(267, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "FAST RENAME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newNameTextBox.Location = new System.Drawing.Point(97, 5);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(266, 22);
            this.newNameTextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "New name";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 104);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(375, 35);
            this.panel11.TabIndex = 19;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.addTagBtn);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(375, 34);
            this.panel12.TabIndex = 19;
            // 
            // addTagBtn
            // 
            this.addTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTagBtn.Location = new System.Drawing.Point(288, 5);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(75, 26);
            this.addTagBtn.TabIndex = 18;
            this.addTagBtn.Text = "Add tag";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Find properties";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(165, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Set tags";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.dateCreateTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 27);
            this.panel7.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date create";
            // 
            // dateCreateTextBox
            // 
            this.dateCreateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateCreateTextBox.Enabled = false;
            this.dateCreateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCreateTextBox.Location = new System.Drawing.Point(97, 2);
            this.dateCreateTextBox.Name = "dateCreateTextBox";
            this.dateCreateTextBox.Size = new System.Drawing.Size(266, 22);
            this.dateCreateTextBox.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.fullNameTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 26);
            this.panel6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Full name";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTextBox.Enabled = false;
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTextBox.Location = new System.Drawing.Point(97, 2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(266, 22);
            this.fullNameTextBox.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.extensionTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 25);
            this.panel5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Extension";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extensionTextBox.Enabled = false;
            this.extensionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extensionTextBox.Location = new System.Drawing.Point(97, 2);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(57, 22);
            this.extensionTextBox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.nameTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 26);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(97, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(266, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(48, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pathTextBox);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(375, 29);
            this.panel13.TabIndex = 4;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RenameForm";
            this.Text = "Renamer 1.0";
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.exceptionPanel.ResumeLayout(false);
            this.exceptionPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.renamePanel.ResumeLayout(false);
            this.renamePanel.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateCreateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button getFilesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correctExtensionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel renamePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel exceptionPanel;
        private System.Windows.Forms.TextBox exceptionText;
        private System.Windows.Forms.Button exceptionAcceptBtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Button addTagBtn;
        private System.Windows.Forms.Panel panel13;
    }
}

