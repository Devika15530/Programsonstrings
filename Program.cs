using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsOnStrings
{
   public class Program
    {
        public string Honeywell(string param,int val)
        {
          
            string str1 = param.Substring(param.Length-3);//getting last 3 characters

            string str2 = param.Substring(0,param.Length-3);//getting char from first 
            string str3 = str1 + str2;//concatenation 

            return str3;
            

        }

        public string Stringreverse(string param)
        {
            char[] chararray = param.ToCharArray();//converting string to chararray
            char[] reversedchararray = new char[param.Length];//creating new array to store reversed chars
            int j = 0;
            for(int i=param.Length-1; i>=0; i--)//itterating through chararray from last
            {
                reversedchararray[j] = chararray[i];//stroing in reversedchararray
                j++;
            }
            string str = new string(reversedchararray);//converting array to string
            return str;
            

        }

        public int Findindexofchar(string param,char c)
        {
            char[] toChararray = param.ToCharArray();
            int index=0;
            for(int i=0;i<toChararray.Length;i++)
            {
                if(toChararray[i]==c)
                {
                    index = i;
                }
            }
            return index;

        }

        public string Sortingstring(string param)
        {

            char[] tochararray = param.ToCharArray();//converting string to char array
            Array.Sort(tochararray);//sorting of array using preexisting sort method in Array class



            return new string(tochararray);//converting that array to string and returning it
        }
       public static void Main(string[] args)
        {
            Console.WriteLine("helloworld");
            Program p = new Program();
            string str = p.Honeywell("honeywell", 3);
            Console.WriteLine(str);
            Console.WriteLine(p.Stringreverse("honeywell"));
            Console.WriteLine(p.Findindexofchar("honeywell", 'y'));
            Console.Write(p.Sortingstring("honeywell"));
            Console.Read();//to show the output


        }
    }
}
