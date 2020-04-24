using System;
using System.Collections.Generic;
using System.Text;

namespace prvi
{
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public Prototype Clone()
        {
            Dataset clone = new Dataset();
            for (int i = 0; i < data.Count; i++)
            {
                clone.data.Add(new List<string>());
                for (int j = 0; j < data[i].Count; j++)
                {
                    clone.data[i].Add(data[i][j]);
                }
            }
            return clone;
        }
        public void ChangeFirstString(string change)
        {
            data[0][0] = change;
        }
        public void Print()
        {
            int i, j;
            for (i = 0; i < data.Count; i++)
            {
                for (j = 0; j < data[i].Count; j++)
                {
                    Console.Write(data[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
