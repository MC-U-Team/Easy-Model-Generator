using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Model_Generator.JsonCreator
{
    class ItemNormalCreate : Create
    {
        protected string fileitemmodel;

        public ItemNormalCreate(string modid, string name) : base(modid, name)
        {
            if (!ok)
            {
                return;
            }

            fileitemmodel = "assets/" + modid + "/models/item/" + name + ".json";

            String itemmodel = Encoding.UTF8.GetString(Properties.Resources.baseitem_itemmodel);

            itemmodel = replaceModidAndName(itemmodel);

            writeFile(fileitemmodel, itemmodel);

            ready();
        }
    }
}
