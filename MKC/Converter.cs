using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Tekla.Structures.Filtering;
using Tekla.Structures.Filtering.Categories;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using System.Windows.Forms;

namespace MKC
{
    public static class Converter
    {
        public static bool Run(string firmPath,string projectPath,bool overwrite)
        {
            Model model = new Model();
            try
            {

                Dictionary<string, string[]> firmDictionary = Utility.CreateDictionaryFromTxtFile(firmPath);
                Dictionary<string, string[]> projectDictionary = Utility.CreateDictionaryFromTxtFile(projectPath);
                List<string> projPropertyList = Utility.CreatePropertyListFromTxtFile(projectPath);
                Type[] Types = new Type[] { typeof(Part) };
                ModelObjectEnumerator moe = model.GetModelObjectSelector().GetAllObjectsWithType(Types);
                var partList = Utility.ToList(moe);

                foreach (Part p in partList)
                {
                    string c = p.Class;
                    string[] firm;
                    bool f_found = firmDictionary.TryGetValue(c, out firm);
                    if (f_found)
                    {
                        string currentMK_Matchkey = string.Empty;
                        p.GetUserProperty("MK_Matchkey", ref currentMK_Matchkey);
                        if (overwrite || (overwrite == false && currentMK_Matchkey.Length < 1))
                        {
                            p.SetUserProperty("MK_Matchkey", firm[0]);
                        }
                    }
                    string[] proj;
                    bool p_found = projectDictionary.TryGetValue(c, out proj);
                    if (p_found)
                    {
                        for (int i = 0; i < projPropertyList.Count; i++)
                        {
                            if (proj.Length > i)
                            {
                                string currentParameterName = string.Empty;
                                p.GetUserProperty(projPropertyList[i], ref currentParameterName);
                                if (overwrite || (overwrite == false && currentParameterName.Length < 1))
                                {
                                    p.SetUserProperty(projPropertyList[i], proj[i]);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;

        }
    }
}
