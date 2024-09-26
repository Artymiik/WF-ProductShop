using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WatermelonShop.Utils
{
    // Конвертируем фото в байты
    // ==========================
    public class UtilsApp
    {
        public byte[] ConvertImageToByte(Image image)
        {
            if (image != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                return null;
            }
        }

        // Обратное действие
        // ======================
        public Image ConvertByteToImage(byte[] image)
        {
            if (image != null)
            {
                using (var memoryStream = new MemoryStream(image))
                {
                    return Image.FromStream(memoryStream);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
