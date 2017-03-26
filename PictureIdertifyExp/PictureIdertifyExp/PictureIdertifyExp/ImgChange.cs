using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureIdertifyExp
{
    class ImgChange
    {
        public Bitmap ImgSource { get; }
        public Bitmap ImgChanged { get; }

        public ImgChange(string path)
        {
            ImgSource = new Bitmap(path);          
            ImgChanged = ImgSource.Clone(new Rectangle(0, 0, ImgSource.Width,
                ImgSource.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            GrayImg();
        }

        /// <summary>
        /// 将图像bitImg转换为黑白图
        /// </summary>
        private void GrayImg()
        {
            int thredshold = GetThresholdValue();
            for(int i = 0; i < ImgSource.Width; i++)
            {
                for(int j = 0; j < ImgSource.Height; j++)
                {
                    Color c = ImgSource.GetPixel(i, j);
                    //灰度值大于等于阈值的像素设为白颜色，否则为黑颜色  
                    if (Gray(c) >= thredshold)
                    {
                        ImgChanged.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        ImgChanged.SetPixel(i, j, Color.Black);
                    }
                }
            }
        }

        /// <summary>
        /// 获取颜色的灰度值
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private int Gray(Color c)
        {
            return (c.R * 30 + c.G * 59 + c.B * 11) / 100;
        }

        /// <summary>
        /// 计算灰度值的阈值
        /// </summary>
        /// <returns></returns>
        private int GetThresholdValue()
        {
            int[] grayNum = new int[256];
            int sum=0;
            int total = ImgSource.Width * ImgSource.Height;
            double percentage = 0.4;    //阈值为0.3
            //数组初始化
            for(int i = 0; i < 256; i++)
            {
                grayNum[i] = 0;
            }
            //计算每个灰度值的像素数量以及图像总灰度值
            for(int i = 0; i < ImgSource.Width; i++)
            {
                for(int j = 0; j < ImgSource.Height; j++)
                {
                    Color c = ImgSource.GetPixel(i, j);
                    grayNum[Gray(c)]++;
                }
            }

            for(int i = 0; i < 256; i++)
            {
                sum += grayNum[i];
                if (sum == total) return i - 1;
                if (sum >= total * percentage)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
