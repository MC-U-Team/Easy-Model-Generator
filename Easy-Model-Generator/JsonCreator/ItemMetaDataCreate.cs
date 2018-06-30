using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Model_Generator.JsonCreator
{
    class ItemMetaDataCreate : Create
    {
        protected string pathitemmodel;

        public ItemMetaDataCreate(string modid, string name, List<string> variants) : base(modid, name)
        {
            if (!ok)
            {
                return;
            }

            if (variants.Count < 1)
            {
                MessageBox.Show("Variants cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pathitemmodel = "assets/" + modid + "/models/item/" + name + "/";

            string itemmodel = Encoding.UTF8.GetString(Properties.Resources.metaitem_itemmodel);

            itemmodel = replaceModidAndName(itemmodel);
                       
            foreach (string variant in variants)
            {
                string variantitemmodel = itemmodel.Replace("${variant}", variant);         
                writeFile(pathitemmodel + variant + ".json", variantitemmodel);
            }

            ready();
        }
    }
}

