using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IDictionary<string, string> luo;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Luo_Click(object sender, EventArgs e)
        {
            luo = new Dictionary<string, string>();
        }

        private void Lisää_Click(object sender, EventArgs e)
        {
            luo.Add(Enterkey.Text, keyValue.Text);
        }

        private void Haku_Click(object sender, EventArgs e)
        {
            if (luo.ContainsKey(Keyhaku.Text))
            {
                Valuehaku.Text = luo[Keyhaku.Text];
            }
            else
            {
                Valuehaku.Text = "unknown";
            }

        }
    }
}
