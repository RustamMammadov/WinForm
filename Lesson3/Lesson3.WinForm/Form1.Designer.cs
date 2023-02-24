namespace Lesson3.WinForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonLoad = new Button();
            buttonSave = new Button();
            textBoxLoad = new TextBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBoxColor = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBoxSave = new TextBox();
            richTextBox1 = new RichTextBox();
            comboBoxSize = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 13);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 12);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 13);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 2;
            label3.Text = "FontStyle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(311, 13);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 3;
            label4.Text = "Aligment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(424, 13);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Menu;
            buttonLoad.Location = new Point(722, 12);
            buttonLoad.Margin = new Padding(1);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 6;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.Menu;
            buttonSave.Location = new Point(722, 37);
            buttonSave.Margin = new Padding(1);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxLoad
            // 
            textBoxLoad.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLoad.ForeColor = SystemColors.ScrollBar;
            textBoxLoad.Location = new Point(521, 12);
            textBoxLoad.Margin = new Padding(1);
            textBoxLoad.Name = "textBoxLoad";
            textBoxLoad.Size = new Size(199, 24);
            textBoxLoad.TabIndex = 8;
            textBoxLoad.Text = "Enter name and load file";
            textBoxLoad.Click += textBoxLoad_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Menu;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(214, 37);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 10;
            button3.Text = "B";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonBold_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Menu;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // comboBoxColor
            // 
            comboBoxColor.BackColor = SystemColors.Menu;
            comboBoxColor.ForeColor = Color.Black;
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(394, 36);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(95, 23);
            comboBoxColor.TabIndex = 19;
            comboBoxColor.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Menu;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button4.Location = new Point(239, 37);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 20;
            button4.Text = "U";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonUnderline_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Menu;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(264, 37);
            button5.Margin = new Padding(1);
            button5.Name = "button5";
            button5.Size = new Size(23, 23);
            button5.TabIndex = 21;
            button5.Text = "I";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonItalic_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Menu;
            button6.Location = new Point(353, 36);
            button6.Margin = new Padding(1);
            button6.Name = "button6";
            button6.Size = new Size(23, 23);
            button6.TabIndex = 24;
            button6.Text = "R";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonR_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Menu;
            button7.Location = new Point(328, 36);
            button7.Margin = new Padding(1);
            button7.Name = "button7";
            button7.Size = new Size(23, 23);
            button7.TabIndex = 23;
            button7.Text = "C";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonC_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Menu;
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(303, 36);
            button8.Margin = new Padding(1);
            button8.Name = "button8";
            button8.Size = new Size(23, 23);
            button8.TabIndex = 22;
            button8.Text = "L";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonL_Click;
            // 
            // textBoxSave
            // 
            textBoxSave.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSave.ForeColor = SystemColors.ScrollBar;
            textBoxSave.Location = new Point(521, 38);
            textBoxSave.Margin = new Padding(1);
            textBoxSave.Name = "textBoxSave";
            textBoxSave.Size = new Size(199, 24);
            textBoxSave.TabIndex = 25;
            textBoxSave.Text = "Tap to enter name and save";
            textBoxSave.Click += textBoxSave_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(2, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(795, 401);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // comboBoxSize
            // 
            comboBoxSize.BackColor = SystemColors.Menu;
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(161, 38);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(49, 23);
            comboBoxSize.TabIndex = 28;
            comboBoxSize.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(comboBoxSize);
            Controls.Add(richTextBox1);
            Controls.Add(textBoxSave);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(comboBoxColor);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(textBoxLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonLoad;
        private Button buttonSave;
        private TextBox textBoxLoad;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBoxColor;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBoxSave;
        private RichTextBox richTextBox1;
        private ComboBox comboBoxSize;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}