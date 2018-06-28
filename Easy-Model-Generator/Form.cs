using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Model_Generator
{
    public partial class Window : System.Windows.Forms.Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void NormalEntry_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Normal";
        }

        private void MetadataEntry_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Metadata";
        }
    }
}
