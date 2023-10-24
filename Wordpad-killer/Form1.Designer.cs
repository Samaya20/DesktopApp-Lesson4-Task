namespace Wordpad_killer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            saveBtn = new Button();
            saveFilenameTextBox = new TextBox();
            loadBtn = new Button();
            loadFilenameTextBox = new TextBox();
            colorComboBox = new ComboBox();
            label11 = new Label();
            centerAlignmentBtn = new Label();
            rightAlignmentBtn = new Label();
            leftAlignmentBtn = new Label();
            label10 = new Label();
            underlineFontStyleBtn = new Label();
            cursiveFontStyleBtn = new Label();
            boldFontStyleBtn = new Label();
            label3 = new Label();
            sizeComboBox = new ComboBox();
            label2 = new Label();
            fontComboBox = new ComboBox();
            label1 = new Label();
            editTextRichTextBox = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(saveFilenameTextBox);
            panel1.Controls.Add(loadBtn);
            panel1.Controls.Add(loadFilenameTextBox);
            panel1.Controls.Add(colorComboBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(centerAlignmentBtn);
            panel1.Controls.Add(rightAlignmentBtn);
            panel1.Controls.Add(leftAlignmentBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(underlineFontStyleBtn);
            panel1.Controls.Add(cursiveFontStyleBtn);
            panel1.Controls.Add(boldFontStyleBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(sizeComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fontComboBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LightGreen;
            saveBtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(732, 37);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(56, 23);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // saveFilenameTextBox
            // 
            saveFilenameTextBox.Location = new Point(582, 37);
            saveFilenameTextBox.Name = "saveFilenameTextBox";
            saveFilenameTextBox.Size = new Size(135, 23);
            saveFilenameTextBox.TabIndex = 16;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.Gold;
            loadBtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loadBtn.Location = new Point(732, 8);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(56, 23);
            loadBtn.TabIndex = 15;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // loadFilenameTextBox
            // 
            loadFilenameTextBox.Location = new Point(582, 8);
            loadFilenameTextBox.Name = "loadFilenameTextBox";
            loadFilenameTextBox.ReadOnly = true;
            loadFilenameTextBox.Size = new Size(135, 23);
            loadFilenameTextBox.TabIndex = 14;
            // 
            // colorComboBox
            // 
            colorComboBox.BackColor = Color.Silver;
            colorComboBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Location = new Point(445, 32);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(113, 24);
            colorComboBox.TabIndex = 13;
            colorComboBox.SelectedIndexChanged += colorComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(481, 10);
            label11.Name = "label11";
            label11.Size = new Size(37, 16);
            label11.TabIndex = 12;
            label11.Text = "Color";
            // 
            // centerAlignmentBtn
            // 
            centerAlignmentBtn.AutoSize = true;
            centerAlignmentBtn.BackColor = Color.Silver;
            centerAlignmentBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            centerAlignmentBtn.Location = new Point(368, 33);
            centerAlignmentBtn.Name = "centerAlignmentBtn";
            centerAlignmentBtn.Padding = new Padding(3);
            centerAlignmentBtn.Size = new Size(21, 22);
            centerAlignmentBtn.TabIndex = 11;
            centerAlignmentBtn.Text = "C";
            centerAlignmentBtn.Click += centerAlignmentBtn_Click;
            // 
            // rightAlignmentBtn
            // 
            rightAlignmentBtn.AutoSize = true;
            rightAlignmentBtn.BackColor = Color.Silver;
            rightAlignmentBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rightAlignmentBtn.Location = new Point(395, 33);
            rightAlignmentBtn.Name = "rightAlignmentBtn";
            rightAlignmentBtn.Padding = new Padding(3);
            rightAlignmentBtn.Size = new Size(21, 22);
            rightAlignmentBtn.TabIndex = 10;
            rightAlignmentBtn.Text = "R";
            rightAlignmentBtn.Click += rightAlignmentBtn_Click;
            // 
            // leftAlignmentBtn
            // 
            leftAlignmentBtn.AutoSize = true;
            leftAlignmentBtn.BackColor = Color.Silver;
            leftAlignmentBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            leftAlignmentBtn.Location = new Point(343, 33);
            leftAlignmentBtn.Name = "leftAlignmentBtn";
            leftAlignmentBtn.Padding = new Padding(3);
            leftAlignmentBtn.Size = new Size(19, 22);
            leftAlignmentBtn.TabIndex = 9;
            leftAlignmentBtn.Text = "L";
            leftAlignmentBtn.Click += leftAlignmentBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(347, 9);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 8;
            label10.Text = "Alignment";
            // 
            // underlineFontStyleBtn
            // 
            underlineFontStyleBtn.AutoSize = true;
            underlineFontStyleBtn.BackColor = Color.Silver;
            underlineFontStyleBtn.Font = new Font("Arial", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            underlineFontStyleBtn.Location = new Point(265, 33);
            underlineFontStyleBtn.Name = "underlineFontStyleBtn";
            underlineFontStyleBtn.Padding = new Padding(3);
            underlineFontStyleBtn.Size = new Size(22, 22);
            underlineFontStyleBtn.TabIndex = 7;
            underlineFontStyleBtn.Text = "U";
            underlineFontStyleBtn.Click += underlineFontStyleBtn_Click;
            // 
            // cursiveFontStyleBtn
            // 
            cursiveFontStyleBtn.AutoSize = true;
            cursiveFontStyleBtn.BackColor = Color.Silver;
            cursiveFontStyleBtn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cursiveFontStyleBtn.Location = new Point(297, 33);
            cursiveFontStyleBtn.Name = "cursiveFontStyleBtn";
            cursiveFontStyleBtn.Padding = new Padding(3);
            cursiveFontStyleBtn.Size = new Size(17, 22);
            cursiveFontStyleBtn.TabIndex = 6;
            cursiveFontStyleBtn.Text = "/";
            cursiveFontStyleBtn.Click += cursiveFontStyleBtn_Click;
            // 
            // boldFontStyleBtn
            // 
            boldFontStyleBtn.AutoSize = true;
            boldFontStyleBtn.BackColor = Color.Silver;
            boldFontStyleBtn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            boldFontStyleBtn.Location = new Point(231, 31);
            boldFontStyleBtn.Name = "boldFontStyleBtn";
            boldFontStyleBtn.Padding = new Padding(3);
            boldFontStyleBtn.Size = new Size(24, 24);
            boldFontStyleBtn.TabIndex = 5;
            boldFontStyleBtn.Text = "B";
            boldFontStyleBtn.Click += boldFontStyleBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(238, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 4;
            label3.Text = "Font Style";
            // 
            // sizeComboBox
            // 
            sizeComboBox.BackColor = Color.Silver;
            sizeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Location = new Point(148, 31);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(58, 24);
            sizeComboBox.TabIndex = 3;
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 8);
            label2.Name = "label2";
            label2.Size = new Size(33, 16);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // fontComboBox
            // 
            fontComboBox.BackColor = Color.Silver;
            fontComboBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(15, 31);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(113, 24);
            fontComboBox.TabIndex = 1;
            fontComboBox.SelectedIndexChanged += fontComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 16);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // editTextRichTextBox
            // 
            editTextRichTextBox.Location = new Point(0, 67);
            editTextRichTextBox.Name = "editTextRichTextBox";
            editTextRichTextBox.Size = new Size(800, 381);
            editTextRichTextBox.TabIndex = 1;
            editTextRichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editTextRichTextBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Wordpad Killer";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox sizeComboBox;
        private Label label2;
        private ComboBox fontComboBox;
        private Label label1;
        private Label boldFontStyleBtn;
        private Label underlineFontStyleBtn;
        private Label cursiveFontStyleBtn;
        private Label centerAlignmentBtn;
        private Label rightAlignmentBtn;
        private Label leftAlignmentBtn;
        private Label label10;
        private ComboBox colorComboBox;
        private Label label11;
        private Button saveBtn;
        private TextBox saveFilenameTextBox;
        private Button loadBtn;
        private TextBox loadFilenameTextBox;
        private RichTextBox editTextRichTextBox;
    }
}