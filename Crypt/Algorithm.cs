using System;
using System.IO;
using System.Text;

namespace Crypt
{
    class Algorithm
    {
        const int MIN_ARGS = 4, MAX_ARGS = 4;

        /* 
         * 4 command line args are required, in the following order:
         * clArgs[0] - source : file
         * clArgs[1] - target : file
         * clArgs[2] - password : string
         * clArgs[3] - random seed : int 
         */
        public void Crypt(string src, string tgt, string pwd, string seed) //TODO: add parameter for file type
        {
            //if (clArgs.Length < MIN_ARGS || clArgs.Length > MAX_ARGS)
            //{
            //    ShutItDown();
            //}

            //else
            //{
                using (StreamReader sr = new StreamReader(src))
                {
                    StreamWriter sw = new StreamWriter(tgt);
                    char[] password = pwd.ToCharArray();

                    bool seedIsInt = int.TryParse(seed, out int theSeed);

                    if (!seedIsInt)
                    {
                    throw new Exception("Seed wasn't an int :(");
                    }

                    Random generator = new Random(theSeed);

                    int ix = 0;

                    StringBuilder result = new StringBuilder();

                    char encryptedChar;
                    byte[] input = Encoding.ASCII.GetBytes(sr.ReadToEnd().ToCharArray());
                    foreach (byte inByte in input)
                    {
                        encryptedChar = (char)(inByte ^ (password[ix++] + generator.Next(10)));
                        result.Append(encryptedChar);
                        if (ix == password.Length) ix = 0;
                    }
                    //Console.Write(result);
                    sw.Write(result);
                    sw.Close();
                }
            //}
        }

        private void ShutItDown()
        {
            Console.WriteLine("You have failed. Only those who know how can use this algorithm.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
