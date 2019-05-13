using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace QuanLyKTX.Support
{
    public class SupportImageToDb
    {
        private string ImageToBytes;

        public string ImageToBytes1 { get => ImageToBytes; set => ImageToBytes = value; }

        public byte[] converImgToByte(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public string GetPathImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            return "";
        }

        public Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }


        public Image ResizeByWidth(Image img, int width)
        {
            // lấy chiều rộng và chiều cao ban đầu của ảnh
            int originalW = img.Width;
            int originalH = img.Height;

            // lấy chiều rộng và chiều cao mới tương ứng với chiều rộng truyền vào của ảnh (nó sẽ giúp ảnh của chúng ta sau khi resize vần giứ được độ cân đối của tấm ảnh
            int resizedW = width;
            int resizedH = (originalH * resizedW) / originalW;

            // tạo một Bitmap có kích thước tương ứng với chiều rộng và chiều cao mới
            Bitmap bmp = new Bitmap(resizedW, resizedH);

            // tạo mới một đối tượng từ Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.High;

            // vẽ lại ảnh với kích thước mới
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);

            // gải phóng resource cho đối tượng graphic
            graphic.Dispose();

            // trả về anh sau khi đã resize
            return (Image)bmp;
        }
    }
}
