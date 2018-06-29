using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Easy_Model_Generator.JsonCreator
{
    class PathLookup
    {
        private OpenFileDialog dialog;

        public PathLookup() {
            dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = false;
            dialog.FileName = "assets";
            dialog.InitialDirectory = Application.StartupPath;
        }

        public string showAndGetPath() {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return Path.GetDirectoryName(dialog.FileName);
            }
            else
            {
                return null;
            }
        }

        public void sendMessage()
        {
            MessageBox.Show("Directory selection is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
