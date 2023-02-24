using System.Collections;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson3.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool buttonBold = false;
        bool buttonUnderline = false;
        bool buttonItalic = false;
        List<float> fontSize = new() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }

            foreach (var size in fontSize)
            {
                comboBoxSize.Items.Add(size);
            }

            comboBoxColor.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();

            comboBoxSize.SelectedText = "11";
            comboBoxColor.SelectedItem = Color.Black;
        }

        private void defould()
        {

            textBoxLoad.Text = null;
            textBoxLoad.Text = "Enter name and load file";
            textBoxLoad.Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            textBoxLoad.ForeColor = Color.LightGray;
            textBoxSave.Text = null;
            textBoxSave.Text = "Tap to enter name and save";
            textBoxSave.Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            textBoxSave.ForeColor = Color.LightGray;
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (buttonBold)
            {
                buttonBold = false;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
            }
            else
            {
                buttonBold = true;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
            }
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            if (buttonUnderline)
            {
                buttonUnderline = false;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
            }
            else
            {
                buttonUnderline = true;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
            }
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            if (buttonItalic)
            {
                buttonItalic = false;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
            }
            else
            {
                buttonItalic = true;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBox1.SelectedItem.ToString() ?? richTextBox1.Font.Name, richTextBox1.Font.Size);
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(comboBoxSize.SelectedItem));
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = (Color)comboBoxColor.SelectedItem;
        }

        private void textBoxSave_Click(object sender, EventArgs e)
        {
            textBoxSave.Text = null;
            textBoxSave.ForeColor = Color.Black;
            textBoxSave.Font = new Font(richTextBox1.Font.FontFamily, 9f);

        }

        private void textBoxLoad_Click(object sender, EventArgs e)
        {
            textBoxLoad.Text = null;
            textBoxLoad.ForeColor = Color.Black;
            textBoxLoad.Font = new Font(richTextBox1.Font.FontFamily, 9f);
        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBoxLoad.Text;
            try
            {
                richTextBox1.Text = File.ReadAllText($"{openFileDialog1.FileName}.txt");
            }
            catch (Exception x)
            {
                MessageBox.Show($"{x.Message}", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            defould();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Text File| *.txt";
            saveFileDialog1.FileName = textBoxSave.Text;
            File.WriteAllText($"{saveFileDialog1.FileName}.txt", richTextBox1.Text);
            richTextBox1.Text = null;
            textBoxSave.Text = null;
            defould();
        }
    }
}