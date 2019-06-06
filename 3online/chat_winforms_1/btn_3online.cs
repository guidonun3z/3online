using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winforms_1
{
    public partial class btn_3online : UserControl
    {
        public btn_3online()
        {
            InitializeComponent();
        }
        public String posicion { get; set; }

        private void btn_3online_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //marcar_button('X'.ToString());
        }
        public void button1_Click(object sender, EventArgs e, string simbol)
        {
            button1.Text = simbol;
            button1.ForeColor = Color.Black;
        }

        public void marcar_button(String simbol)
        {
            button1.Text = simbol;
            button1.ForeColor = Color.Black;
        }
    }
}
