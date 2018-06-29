using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Model_Generator.JsonCreator
{
    class Validator
    {
        Boolean ok = true;

        public Validator(String modid, String name) {
            if (String.IsNullOrWhiteSpace(modid) || String.IsNullOrWhiteSpace(name)) {
                ok = false;
            } 
        }

        public Boolean getOk() {
            return ok;
        }

        public void sendMessage()
        {
            MessageBox.Show("Modid or name is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
