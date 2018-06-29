using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Model_Generator.JsonCreator
{
    class BlockMetaDataCreate : Create
    {
        protected string fileblockstate, pathblockmodel, pathitemmodel;

        public BlockMetaDataCreate(string modid, string name, List<string> variants) : base(modid, name)
        {
            if (!ok)
            {
                return;
            }

            if (variants.Count < 1) {
                MessageBox.Show("Variants cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fileblockstate = "assets/" + modid + "/blockstates/" + name + ".json";
            pathblockmodel = "assets/" + modid + "/models/block/" + name + "/";
            pathitemmodel = "assets/" + modid + "/models/item/" + name + "/";


            string blockstate = Encoding.UTF8.GetString(Properties.Resources.metablock_blockstate);
            string blockstate_include = Encoding.UTF8.GetString(Properties.Resources.metablock_blockstate_include);
            string blockmodel = Encoding.UTF8.GetString(Properties.Resources.metablock_blockmodel);
            string itemmodel = Encoding.UTF8.GetString(Properties.Resources.metablock_itemmodel);


            blockstate_include = replaceModidAndName(blockstate_include);
            blockmodel = replaceModidAndName(blockmodel);
            itemmodel = replaceModidAndName(itemmodel);

            string blockstate_added = "";

            foreach (string variant in variants) {
                string variantblockmodel = blockmodel.Replace("${variant}", variant);
                string variantitemmodel = itemmodel.Replace("${variant}", variant);
                string variantblockstate_include = blockstate_include.Replace("${variant}", variant);

                writeFile(pathblockmodel + variant + ".json", variantblockmodel);
                writeFile(pathitemmodel + variant + ".json", variantitemmodel);

                blockstate_added += variantblockstate_include + ",";

            }

            blockstate_added = blockstate_added.Substring(0, blockstate_added.Length - 1);

            blockstate = blockstate.Replace("${include}", blockstate_added);
            writeFile(fileblockstate, blockstate);
                       
            ready();
        }
    }
}
