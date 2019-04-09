using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38.KeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == (Keys.Shift | Keys.Control))
                MessageBox.Show("Modifiers + Shift + Control");
            if ((e.KeyCode == Keys.A) && (e.Modifiers == (Keys.Shift | Keys.Alt)))
                MessageBox.Show("A + Shift + Alt");
        }
    }
}
