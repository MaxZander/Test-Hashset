using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Hashset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= DB.ID.Count-1; i++)
            {
                string id = DB.ID.ElementAt<string>(i);
                string pw = DB.PW.ElementAt<string>(i);
                bool vid = false;
                bool vpw = false;
                if(textBox1.Text == id)
                    vid = true;
                if (textBox2.Text == pw)
                    vpw = true;
                if (vid == vpw)
                {
                    MessageBox.Show("Connexion reussie !");
                    return;
                }
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog(this) == DialogResult.OK) // PROBLEME ICI !!!!!
            {
                if (f2.textBox1.Text != "")
                {
                    
                    if (f2.textBox2.Text != "" & f2.textBox3.Text != "")
                    {
                        if (f2.textBox2.Text == f2.textBox3.Text)
                        {
                            DB.ID.Add(f2.textBox1.Text);
                            DB.PW.Add(f2.textBox2.Text);
//                            MessageBox.Show("L'utilisateur est bien inscrit avec l'id : " + DB.ID.ElementAt(0) + " et le mot de passe : " + DB.PW.ElementAt(0), "Test");
//                            f2.Close();
                        }
                    }

                    

                }
            }
        }
    }
    public static class DB
    {
        private static HashSet<string> _id = new HashSet<string>();
        private static HashSet<string> _psw = new HashSet<string>();

        public static HashSet<string> ID { get => _id; set => _id = value; }
        public static HashSet<string> PW { get => _psw; set => _psw = value; }
    }
}
