using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;


namespace MKC
{
    public class Utility
    {
        public static List<string> CreatePropertyListFromTxtFile(string path)
        {
            char[] separators = new char[] { ' ' };
            string[] text = System.IO.File.ReadAllLines(path);
            List<string> propertyList = new List<string>();
            foreach (string line in text)
            {
                if (line.StartsWith("set"))
                {
                    string[] splitedLine = line.Split(separators);
                    propertyList.Add(splitedLine[1]);
                }
            }
            return propertyList;
        }
        public static Dictionary<string, string[]> CreateDictionaryFromTxtFile(string path)
        {
            char[] separators = new char[] { ',', '/' };
            string[] text = System.IO.File.ReadAllLines(path);
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
            foreach (string line in text)
            {
                if (!line.StartsWith("//") || !line.StartsWith("set"))
                {
                    string[] splitedLine = line.Split(separators);
                    string c = splitedLine[0].Clone().ToString();
                    splitedLine = splitedLine.Skip(1).ToArray();
                    dictionary.Add(c, splitedLine);
                }
            }
            return dictionary;
        }
        public static List<ModelObject> ToList(ModelObjectEnumerator enumerator)
        {
            var list = new List<ModelObject>();
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                list.Add(current);
            }
            return list;
        }
        public static List<ModelObject> GetAllObjectsOfType(Model model,Type type)
        {
            Type[] Types = new Type[] { type };
            ModelObjectEnumerator moe = model.GetModelObjectSelector().GetAllObjectsWithType(Types);
            List<ModelObject> assemblyList = Utility.ToList(moe);
            return assemblyList;

        }

        public static RebarSet[] PickRebarSets()
        {
            Picker picker = new Picker();
            ModelObjectEnumerator modelObjectEnumerator = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_REINFORCEMENTS, "Pick rebar sets");
            RebarSet[] array = new RebarSet[modelObjectEnumerator.GetSize()];
            for (int i = 0; i < array.Length; i++)
            {
                modelObjectEnumerator.MoveNext();
                array[i] = modelObjectEnumerator.Current as RebarSet;
            }

            return array;
        }
    }
}
