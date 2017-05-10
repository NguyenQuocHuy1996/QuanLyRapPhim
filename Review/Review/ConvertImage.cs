using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

using DTO;
using BUS;

namespace Review
{
    public class ConvertImage
    {
        public static byte[] ConvertImageToByte(string Path)
        {
            FileStream fs;
            fs = new FileStream(Path, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];

            fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public static Image ConvertByteToImage(byte[] bytnp)
        {
            System.Drawing.Image picture;
            using (MemoryStream stream = new MemoryStream(bytnp))
            {
                picture = Image.FromStream(stream);
            }
            return picture;
        }
    }
}
