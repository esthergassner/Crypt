using System;
using System.IO;

namespace Crypt
{
    static class Algorithm
    {
        public static void Crypt(string src, string tgt, string pwd, int seed, string ext) //TODO: add parameter for file type
        {
            using (FileStream inStream = new FileStream(src, FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(inStream);

                Stream outStream = new FileStream(tgt, FileMode.Create);
                BinaryWriter writer = new BinaryWriter(outStream);

                char[] password = pwd.ToCharArray();
                Random generator = new Random(seed);
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