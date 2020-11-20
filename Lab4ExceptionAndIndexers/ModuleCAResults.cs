using System;
using System.Collections.Generic;

namespace Lab4ExceptionAndIndexers
{
    public class ModuleCAResults
    {
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public string StudentName { get; set; }
        private Dictionary<string, int> Results { get; set; }

        public ModuleCAResults()
        {
            Results = new Dictionary<string, int>();
        }

        public int this[string ca]
        {
            get
            {
                if (Results.ContainsKey(ca))
                {
                    return Results[ca];
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            set
            {
                int caNumber = Convert.ToInt16(ca[2..]);

                string checkCA = "CA" + (caNumber - 1);

                if (!Results.ContainsKey(ca) && ca[0..2] == "CA")
                {
                    if (Results.ContainsKey(checkCA) || caNumber == 1)
                    {
                        Results.Add(ca, value);
                    }
                    else
                    {
                        throw new Exception("Invalid Input");
                    }
                }
                else
                {
                    throw new Exception("Invalid Input");
                }
            }
        }

        public override string ToString()
        {
            string caResult = "";
            foreach (KeyValuePair<string, int> item in Results)
            {
                caResult += "\n" + item.Key + " -> " + item.Value + "\n";
            }

            return $"Module Name: {ModuleName}\n" +
                   $"Module Credits: {Credits}\n" +
                   $"Student Name: {StudentName}\n" +
                   $"CA Results: {caResult}";
        }
    }
}
