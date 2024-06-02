using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeQQ
{
	class Base64
	{
		public static Image Base64ToImage(string base64String)
		{
			// Convert Base64 String to byte[]
			byte[] imageBytes = Convert.FromBase64String(base64String);
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

			// Convert byte[] to Image
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		public static string BitmapToBase64(Image bitmap)
		{
			MemoryStream ms1 = new MemoryStream();
			bitmap.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] arr1 = new byte[ms1.Length];
			ms1.Position = 0;
			ms1.Read(arr1, 0, (int)ms1.Length);
			ms1.Close();
			return Convert.ToBase64String(arr1);
		}
	}
}
