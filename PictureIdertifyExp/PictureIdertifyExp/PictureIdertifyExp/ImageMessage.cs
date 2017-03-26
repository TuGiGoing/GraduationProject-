using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureIdertifyExp
{
    class ImageMessage
    {
        public Bitmap bitImg { get; set; }
        /// <summary>10个区域的特征数 </summary>
        public int[] pixelNum = new int[15];

        public ImageMessage(Bitmap img)
        {
            bitImg = img;
            CalPixel();
        }

        /// <summary>
        /// 计算15个区域的特征数
        /// </summary>
        private void CalPixel()
        {
            int k = 0;
            int width, height,x,y;
            //将图像划分成5*3的15个区域，并去特征值
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    x = bitImg.Width / 3 * j;
                    y = bitImg.Height / 5 * i;
                    width = bitImg.Width / 3 * (j + 1);
                    height = bitImg.Height / 5 * (i + 1);
                    pixelNum[k] = CalPixelNumber(x, y, width, height);
                    k++;
                }
            }          
        }

        /// <summary>
        /// 计算某个区域的特征值
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private int CalPixelNumber(int x,int y,int width,int height)
        {
            int num = 0;
            //计算该区域黑色点的像素个数
            for(int i= x; i < width; i++)
            {
                for(int j= y; j < height; j++)
                {
                    Color c = bitImg.GetPixel(i, j);
                    int argb=c.ToArgb();
                    if (c.ToArgb()==Color.Black.ToArgb())
                    {
                        num++;
                    }
                }
            }
            return num;
        }

       
        

    }
}
