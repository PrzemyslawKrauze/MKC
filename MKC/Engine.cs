using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace MKC
{
    public static class Engine
    {
        static string MK_Matchkey = "MK_Matchkey";
        static string Outer_Matchkey = "Strabag_Matchkey";
        static string MK_ThinElementArea = "MK_ThinElementArea";
        static string MK_CorrectArea = "MK_CorrectArea";
        static string MK_Building = "IFC_BUILDING";
        static string MK_Element = "IFC_BUILDING_STOREY";
        static string USER_PHASE = "USER_PHASE";
        static bool ProjectExist = false;

        public static bool Run(string firmPath, string projectPath, bool overwrite)
        {
            if (projectPath != String.Empty)
            {
                ProjectExist = true;
            }
            Model model = new Model();
            try
            {

                Dictionary<string, string[]> firmDictionary = Utility.CreateDictionaryFromTxtFile(firmPath);
                List<ModelObject> partList = Utility.GetAllObjectsOfType(model, typeof(Part));

                foreach (Part p in partList)
                {
                    string c = p.Class;
                    string[] firm;
                    bool f_found = firmDictionary.TryGetValue(c, out firm);
                    if (f_found)
                    {
                        string currentMK_Matchkey = string.Empty;
                        p.GetUserProperty(MK_Matchkey, ref currentMK_Matchkey);
                        if (overwrite || (overwrite == false && currentMK_Matchkey.Length < 1))
                        {
                            p.SetUserProperty(MK_Matchkey, firm[0]);
                        }
                    }

                    if (ProjectExist)
                    {
                        Dictionary<string, string[]> projectDictionary = Utility.CreateDictionaryFromTxtFile(projectPath);
                        List<string> projPropertyList = Utility.CreatePropertyListFromTxtFile(projectPath);
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

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool RewriteMatchkeyToAssembly(bool overwrite)
        {
            Model model = new Model();
            try
            {
                List<ModelObject> assemblyList = Utility.GetAllObjectsOfType(model, typeof(Assembly));

                foreach (Assembly assembly in assemblyList)
                {
                    Part mainPart = assembly.GetMainPart() as Part;
                    if (mainPart != null)
                    {
                        string pMKMatchkey = string.Empty;
                        string aMKMatchkey = string.Empty;

                        mainPart.GetUserProperty(MK_Matchkey, ref pMKMatchkey);
                        assembly.GetUserProperty(MK_Matchkey, ref aMKMatchkey);

                        if (overwrite || (overwrite == false && aMKMatchkey.Length < 1))
                        {
                            assembly.SetUserProperty(MK_Matchkey, pMKMatchkey);
                        }

                        if (ProjectExist)
                        {
                            string pOuterMatchkey = string.Empty;
                            string aOuterMatchkey = string.Empty;

                            mainPart.GetUserProperty(Outer_Matchkey, ref pOuterMatchkey);
                            assembly.GetUserProperty(Outer_Matchkey, ref aOuterMatchkey);

                            if (overwrite || (overwrite == false && aOuterMatchkey.Length < 1))
                            {
                                assembly.SetUserProperty(Outer_Matchkey, pOuterMatchkey);
                            }
                        }
                    }
                }
                model.CommitChanges();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool RewriteIFCBUILDINGAndIFCBUILDINGSTOREYToAssembly(bool overwrite)
        {
            Model model = new Model();
            try
            {

                List<ModelObject> assemblyList = Utility.GetAllObjectsOfType(model, typeof(Assembly));

                foreach (Assembly assembly in assemblyList)
                {
                    Part mainPart = assembly.GetMainPart() as Part;
                    if (mainPart != null)
                    {
                        string pMKBuilding = string.Empty;
                        string aMKBuilding = string.Empty;
                        string pMKElement = string.Empty;
                        string aMKElement = string.Empty;
                        mainPart.GetUserProperty(MK_Building, ref pMKBuilding);
                        assembly.GetUserProperty(MK_Building, ref aMKBuilding);
                        mainPart.GetUserProperty(MK_Element, ref pMKElement);
                        assembly.GetUserProperty(MK_Element, ref aMKElement);
                        if (overwrite || (overwrite == false && aMKBuilding.Length < 1))
                        {
                            assembly.SetUserProperty(MK_Building, pMKBuilding);
                        }
                        if (overwrite || (overwrite == false && aMKElement.Length < 1))
                        {
                            assembly.SetUserProperty(MK_Element, pMKElement);
                        }
                    }
                }
                model.CommitChanges();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool CallculateCorrectAreaForAssembly(bool overwrite)
        {
            Model model = new Model();
            try
            {
                List<ModelObject> assemblyList = Utility.GetAllObjectsOfType(model, typeof(Assembly));

                foreach (Assembly assembly in assemblyList)
                {
                    assembly.SetUserProperty(MK_CorrectArea, 0);
                }

                List<ModelObject> partList = Utility.GetAllObjectsOfType(model, typeof(Part));

                foreach (Part part in partList)
                {
                    Assembly assembly = part.GetAssembly();
                    double pMKCorrectArea = 0;
                    double aMKCorrectArea = 0;
                    string pMKThinElementArea = string.Empty;
                    part.GetUserProperty(MK_CorrectArea, ref pMKCorrectArea);
                    assembly.GetUserProperty(MK_CorrectArea, ref aMKCorrectArea);
                    part.GetUserProperty(MK_ThinElementArea, ref pMKThinElementArea);

                    aMKCorrectArea += pMKCorrectArea;
                    assembly.SetUserProperty(MK_CorrectArea, aMKCorrectArea);
                    assembly.SetUserProperty(MK_ThinElementArea, pMKThinElementArea);
                }
                model.CommitChanges();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool CalculateCorrectArea(bool overwrite)
        {
            Model model = new Model();
            try
            {
                List<ModelObject> partList = Utility.GetAllObjectsOfType(model, typeof(Part));

                foreach (Part part in partList)
                {
                    double currentMK_CorrectArea = 0;
                    string currentMK_ThinElementArea = String.Empty;
                    bool readCorrectArea = part.GetUserProperty(MK_CorrectArea, ref currentMK_CorrectArea);
                    bool readThinElementArea = part.GetUserProperty(MK_ThinElementArea, ref currentMK_ThinElementArea);
                    if (!readThinElementArea)
                    {
                        part.SetUserProperty(MK_ThinElementArea, "Nie");
                    }
                    if (overwrite || (overwrite == false && currentMK_CorrectArea < 0.1))
                    {
                        bool getAreaAttribute = part.GetUserProperty("AREA", ref currentMK_CorrectArea);
                        bool getAreaParameter = part.GetReportProperty("AREA", ref currentMK_CorrectArea);
                        if (currentMK_ThinElementArea == "Tak")
                        {
                            currentMK_CorrectArea *= 0.5;
                        }
                        part.SetUserProperty(MK_CorrectArea, currentMK_CorrectArea);
                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool RewritePhaseToUDA(bool overwrite)
        {
            Model model = new Model();
            try
            {
                List<ModelObject> partList = Utility.GetAllObjectsOfType(model, typeof(Part));

                foreach (Part part in partList)
                {
                    part.GetPhase(out Phase phase);
                    int phaseNumber = phase.PhaseNumber;
                    string pUSERPHASE = string.Empty;
                    bool a = part.GetUserProperty(USER_PHASE, ref pUSERPHASE);

                    if (overwrite || (overwrite == false && pUSERPHASE.Length < 1))
                    {
                        part.SetUserProperty(USER_PHASE, phaseNumber);
                    }

                }
                model.CommitChanges();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        public static bool ChangePrefix(RebarSet[] rebarSetArr, string oldPrefix, string newPrefix)
        {
            try
            {
                foreach (RebarSet rebarSet in rebarSetArr)
                {
                    if (rebarSet.RebarProperties.NumberingSeries.Prefix == oldPrefix)
                    {
                        rebarSet.RebarProperties.NumberingSeries.Prefix = newPrefix;                       
                        rebarSet.Modify();
                    }
                    ModelObjectEnumerator modifiers = rebarSet.GetRebarModifiers();

                    List<ModelObject> modifierList = Utility.ToList(modifiers);

                    
                    foreach (BaseRebarModifier mod in modifierList)
                    {
                        if (mod.GetType() == typeof(RebarPropertyModifier))
                        {
                            var propmod = mod as RebarPropertyModifier;
                            if (propmod.RebarProperties.NumberingSeries.Prefix == oldPrefix)
                            {
                                propmod.RebarProperties.NumberingSeries.Prefix = newPrefix;
                            }
                            propmod.Modify();
                        }
                        
                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
                return false;
            }

            return true;
        }
        public static bool SetRebarSeqNumber(string prefix, int startNumber, int endNumber, int seqNumber)
        {
            string rebarPosName = "REBAR_POS";
            string rebarSeqName = "REBAR_SEQ_NO";
            Model model = new Model();
            //Check SingleRebar
            List<ModelObject> singleRebarList = Utility.GetAllObjectsOfType(model, typeof(SingleRebar));
            foreach (SingleRebar rebar in singleRebarList)
            {
                if (rebar.NumberingSeries.Prefix == prefix)
                {
                    string position = string.Empty;
                    rebar.GetReportProperty(rebarPosName, ref position);
                    position = position.Replace(prefix, "");
                    double number = Convert.ToDouble(position);
                    if (number >= startNumber && number < endNumber+1)
                    {
                        rebar.SetUserProperty(rebarSeqName, seqNumber);
                    }
                }
            }

            //Check RebarGroup
            List<ModelObject> rebarGroupList = Utility.GetAllObjectsOfType(model, typeof(RebarGroup));
            foreach (RebarGroup rebar in rebarGroupList)
            {
                if (rebar.NumberingSeries.Prefix == prefix)
                {
                    string position = string.Empty;
                    rebar.GetReportProperty(rebarPosName, ref position);
                    position = position.Replace(prefix, "");
                    double number = Convert.ToDouble(position);
                    if (number >= startNumber && number < endNumber + 1)
                    {
                        rebar.SetUserProperty(rebarSeqName, seqNumber);
                    }
                }
            }
            MessageBox.Show("True");
            return true;           
        }
    }
}
