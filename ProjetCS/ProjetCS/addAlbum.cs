using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCS
{
    public partial class addAlbum : Form
    {
        public addAlbum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Album newalbum = new Album(textBox1.Text);
            ActiveForm.Close();
        }

        private void addAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
