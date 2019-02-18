using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook.ICloneable
{
    [Serializable]
    public class Company : IShallowCopy<Company>, IDeepCopy<Company>
    {
        public string[] Names;

        public Company(string[] names)
        {
            Names = names;
        }

        public Company ShallowCopy()
        {
            return (Company)MemberwiseClone();
        }

        public Company DeepCopy()
        {
            BinaryFormatter BF = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            BF.Serialize(ms, this);
            ms.Flush();
            ms.Position = 0;
            return (Company)BF.Deserialize(ms);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Names.Length; i++)
            {
                sb.Append(Names[i]);
                sb.Append(",");
            }
            return sb.ToString();
        }
    }

    public class CloneableTest
    {
        public void Test()
        {
            string[] names = {"Microsoft", "Apple", "Amazon", "Facebook", "Twitter" };
            Company company = new Company(names);
            Company company2 = company.ShallowCopy();
            company2.Names[1] = "Fake Apple";
            Console.WriteLine("--------ShallowCopy----------");
            Console.Write("Company2：");
            Console.WriteLine(company2);
            Console.Write("Company：");
            Console.WriteLine(company);
            Console.WriteLine("--------DeepCopy----------");
            Company company3 = company2.DeepCopy();
            company3.Names[1] = "Apple";
            Console.Write("Company3：");
            Console.WriteLine(company3);
            Console.Write("Company2：");
            Console.WriteLine(company2);
            Console.Write("Company：");
            Console.WriteLine(company);
        }
    }
}
