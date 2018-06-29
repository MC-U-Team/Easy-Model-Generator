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

        private void NormalEntry_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Block Normal";
            setVariants(false);
        }

        private void MetadataEntry_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Block Metadata";
            setVariants(true);
        }

        private void setVariants(Boolean boolean)
        {
            VariantsStaticTextLabel.Enabled = boolean;
            VariantsTextBox.Enabled = boolean;
        }

        private void LogoPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://u-team.info");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (StatusLabel.Text == "Block Normal")
            {
                new JsonCreator.BlockNormalCreate(ModidTextBox.Text, NameTextBox.Text);
            }
            else if (StatusLabel.Text == "Block Metadata") {

                List<string> list = new List<string>();

                foreach (string value in VariantsTextBox.Lines) {
                    if (String.IsNullOrWhiteSpace(value)) {
                        continue;
                    }
                    list.Add(value);
                }
            
                new JsonCreator.BlockMetaDataCreate(ModidTextBox.Text, NameTextBox.Text, list);
            }
            else
            {
                MessageBox.Show("Model selection is none", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
