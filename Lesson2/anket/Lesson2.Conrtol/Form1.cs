using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace Lesson2.Conrtol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ButtonEnable()
        {
            button1.Enabled = (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && (radioButton1.Checked || radioButton2.Checked));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dc = new Dictionary<string, string>();
            string surname = textBox1.Text;
            string name = textBox2.Text;
            string father_name = textBox3.Text;
            string country = textBox4.Text;
            string city = textBox4.Text;
            string phone = textBox5.Text;
            string dt = dateTimePicker1.Value.ToString();
            string gender;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;
            dc.Add("surname", surname);
            dc.Add("name", name);
            dc.Add("father_name", father_name);
            dc.Add("country", country);
            dc.Add("city", city);
            dc.Add("phone", phone);
            dc.Add("date of birthday", dt);
            dc.Add("gender", gender);
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(dc);
            string file_name = $"{name}.json";
            File.WriteAllText(file_name, json);


        }

        private void TextRegex(System.Windows.Forms.TextBox textBox)
        {
            Regex regex1 = new("^[a-z0-9_-]{3,15}$");
            if (regex1.IsMatch(textBox.Text))
            {
                textBox.ForeColor = Color.Black;
            }
            else
                textBox.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextRegex(textBox1);
            ButtonEnable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextRegex(textBox2);
            ButtonEnable();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextRegex(textBox3);
            ButtonEnable();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextRegex(textBox4);
            ButtonEnable();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextRegex(textBox5);
            ButtonEnable();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Regex regex1 = new("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            if (regex1.IsMatch(textBox6.Text))
            {
                textBox6.ForeColor = Color.Black;
            }
            else
                textBox6.ForeColor = Color.Red;
            ButtonEnable();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonEnable();
            button2.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnable();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Enabled = textBox1.Text.Length>0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = textBox7.Text.Length > 0;
        }
    }
}