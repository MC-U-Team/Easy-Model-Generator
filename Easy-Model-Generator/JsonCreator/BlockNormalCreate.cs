using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Easy_Model_Generator.JsonCreator
{
    class BlockNormalCreate : Create 
    {
        protected string fileblockstate, fileblockmodel, fileitemmodel;

        public BlockNormalCreate(string modid, string name) : base(modid, name)
        {
            if (!ok) {
                return;
            }

            fileblockstate = "assets/" + modid + "/blockstates/" + name + ".json";
            fileblockmodel = "assets/" + modid + "/models/block/" + name + ".json";
            fileitemmodel = "assets/" + modid + "/models/item/" + name + ".json";

            String blockstate = Encoding.UTF8.GetString(Properties.Resources.baseblock_blockstate);
            String blockmodel = Encoding.UTF8.GetString(Properties.Resources.baseblock_blockmodel);
            String itemmodel = Encoding.UTF8.GetString(Properties.Resources.baseblock_itemmodel);

            blockstate = replaceModidAndName(blockstate);
            blockmodel = replaceModidAndName(blockmodel);
            itemmodel = replaceModidAndName(itemmodel);

            writeFile(fileblockstate, blockstate);
            writeFile(fileblockmodel, blockmodel);
            writeFile(fileitemmodel, itemmodel);

            ready();
        }
    }
}
