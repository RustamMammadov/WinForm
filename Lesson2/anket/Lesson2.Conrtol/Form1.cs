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

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            string name = textBox2.Text;
            string father_name = textBox3.Text;
            string country = textBox4.Text;
            string city = textBox5.Text;
            string phone = textBox6.Text;
            DateTime dt = dateTimePicker1.Value;
            string gender;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;
            User user = new(surname, name, father_name, country, city, phone, dt, gender);

            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(user);
            string file_name = $"{textBox2.Text}.json";
            File.WriteAllText(file_name, json);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var json = File.ReadAllText($"{textBox7.Text}.json");
                var obj = JsonSerializer.Deserialize<User>(json);
                textBox1.Text = obj?.Surname;
                textBox2.Text = obj?.Name;
                textBox3.Text = obj?.Father_name;
                textBox4.Text = obj?.Country;
                textBox5.Text = obj?.City;
                textBox6.Text = obj?.Phone;
                dateTimePicker1.Value = obj.Dt;
                if (obj.Gender == "Male")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //button2.Enabled = textBox1.Text.Length>0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = textBox7.Text.Length > 0;
        }
    }
}