using System;
using System.IO;

namespace Crypt
{
    static class Algorithm
    {
        public static void Crypt(string src, string tgt, string pwd, string seed) //TODO: add parameter for file type
        {
            using (FileStream inStream = new FileStream(src, FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(inStream);
                Stream outStream = new FileStream(tgt, FileMode.Create);

                BinaryWriter writer = new BinaryWriter(outStream);

                char[] password = pwd.ToCharArray();

                bool seedIsInt = int.TryParse(seed, out int theSeed);

                if (!seedIsInt)
                {
                    throw new Exception("Seed wasn't an int :(");
                }

                Random generator = new Random(theSeed);

                int ix = 0;

                byte encryptedByte;

                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    encryptedByte = (byte)(reader.ReadByte() ^ (byte)(password[ix++] + generator.Next()));
                    writer.Write(encryptedByte);
                    if (ix == password.Length) ix = 0;
                }
                reader.Close();
                outStream.Close();
                writer.Close();
            }
        }
    }
}