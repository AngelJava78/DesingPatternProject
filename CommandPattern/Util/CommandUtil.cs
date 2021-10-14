using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Util
{
    public class CommandUtil
    {
        public static List<string> TokenizerArgs(string args)
        {
            List<String> tokens = new List<String>();
            char[] charArray = args.ToCharArray();
            string contact = "";
            bool inText = false;
            foreach (var c in charArray)
            {
                if (c == ' ' && !inText)
                {
                    if (contact.Length != 0)
                    {
                        tokens.Add(contact);
                        contact = "";
                    }
                }
                else if (c == '"')
                {
                    if (inText)
                    {
                        tokens.Add(contact);
                        contact = "";
                        inText = false;
                    }
                    else
                    {
                        inText = true;
                    }
                }
                else
                {
                    contact += c.ToString();
                }
            }
            if (contact.Trim().Length != 0)
            {
                tokens.Add(contact.Trim());
            }

            //String[] argsArray = new String[tokens.size()];
            //argsArray = tokens.toArray(argsArray);
            //return argsArray;
            return tokens;

        }
    }
}
