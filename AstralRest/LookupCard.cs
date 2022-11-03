using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstralRest
{
    public partial class LookupCard : UserControl
    {
        public LookupCard(string title, string data)
        {
            InitializeComponent();

            titlelbl.Text = title;
            cotnetnlbl.Text = data;
        }

        private void cotnetnlbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.cotnetnlbl.Text);
            MessageBox.Show($"{this.titlelbl.Text}`s data copied!");
        }
    }
}
