using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Easy_Model_Generator.JsonCreator
{

    class Create
    {

        protected Boolean ok = true;

        protected string path, modid, name;

        public Create(string modid, string name)
        {
            this.modid = modid;
            this.name = name;

            Validator validator = new Validator(modid, name);
            if (!validator.getOk())
            {
                validator.sendMessage();
                ok = false;
                return;
            }

            PathLookup lookup = new PathLookup();
            path = lookup.showAndGetPath();
            if (path == null)
            {
                lookup.sendMessage();
                ok = false;
                return;
            }

        }

        protected string replaceModidAndName(String toreplace) {
            return toreplace.Replace("${modid}", modid).Replace("${name}", name);
        }

        protected void writeFile(String filepath, String content) {
            filepath = path + "/" + filepath;
            FileInfo file = new System.IO.FileInfo(filepath);
            file.Directory.Create();
            File.WriteAllText(file.FullName, content);
        }

        protected void ready() {
            MessageBox.Show("Files created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
