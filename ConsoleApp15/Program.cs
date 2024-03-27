using System;

namespace ConsoleApp15
{
    internal class Program
    {
        public static Node<char> BuildTail()
        {
            char str;
            Node<char> list = null;
            Node<char> last = null;
            Node<char> p;
            str = char.Parse(Console.ReadLine());
            while (str != '0')
            {
                if (list == null)
                {
                    list = new Node<char>(str);
                    last = list;
                }
                else
                {
                    p = new Node<char>(str);
                    last.SetNext(p);
                    last = p;
                }
                str = char.Parse(Console.ReadLine());
            }
            return list;
        }
        public static Node<char> StringToNode(string str)
        {
            Node<char> list = null;
            Node<char> last = null;
            Node<char> p;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    if (list == null)
                    {
                        list = new Node<char>(str[i]);
                        last = list;
                    }
                    else
                    {
                        p = new Node<char>(str[i]);
                        last.SetNext(p);
                        last = p;
                    }
                }
                else i++;
            }
            return list;
        }
        public static string RemoveSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            { 
                if (str[i] == ' ')
                    str = str.Remove(i,1);
            }
            return str;
        }
        public static string ReplaceNode(Node<char> list, string str1, string str2)
        {
            string str = list.ToString();
            str = RemoveSpace(str);
            str = str.Replace(str1, str2);
            return str;
        }
        static void Main(string[] args)
        {
            Node<char> list = BuildTail();

            string str = ReplaceNode(list, "ab", "***");
            Console.WriteLine(str);

            //Back to Node<char>
            Console.WriteLine(StringToNode(str));
        }
    }
}