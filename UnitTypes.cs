using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace unit_converter
{
    public class UnitTypes
    {
        // insert strings to be converted to dicts
        public static Dictionary<string, List<string>> AddDictItems()
        {
            string ldict = "Length,Mile,Kilometer";
            Dictionary<string, List<string>> unitTypes = new Dictionary<string, List<string>>();
            //List<string> lkeyvalues = new List<string>();
            //List<string> lvalues = new List<string>();
            string[] akeyvalues = ldict.Split(",");
            List<string> lkeyvalues = akeyvalues.ToList();
            string lkey = lkeyvalues[0];
            lkeyvalues.RemoveAt(0);
            List<string> lvalues = lkeyvalues;
            unitTypes.Add(lkey, lvalues);
            return unitTypes;
        }

    }
}
