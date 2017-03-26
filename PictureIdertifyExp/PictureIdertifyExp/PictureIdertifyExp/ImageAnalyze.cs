using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PictureIdertifyExp
{
    class ImageAnalyze
    {
        /// <summary>存储训练图像路径的列表</summary>
        List<string> imagePaths = new List<string>();
        /// <summary>存储经过处理计算的训练图像及其信息</summary>
        List<ImageMessage> images = new List<ImageMessage>();

        public ImageAnalyze()
        {
            TrainImage();
        }

        /// <summary>
        /// 训练图像集合，得到训练集合特征值
        /// </summary>
        private void TrainImage()
        {
            //获取训练图像集合
            for (int i = 0; i < 10; i++)
            {
                string path = string.Format("识别图像数据\\test{0}", i);
                string[] files = Directory.GetFiles(path);
                imagePaths.AddRange(files);
            }
            //转换训练图像为黑白图
            for (int i = 0; i < imagePaths.Count; i++)
            {
                ImgChange ic = new ImgChange(imagePaths[i]);
                ImageMessage img = new ImageMessage(ic.ImgChanged);
                images.Add(img);
            }
        }

        /// <summary>
        /// 识别图像
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int AnalyzeResult(string path)
        {
            //转换待识别的图像
            ImgChange ic = new ImgChange(path);
            ImageMessage img = new ImageMessage(ic.ImgChanged);

            double distance = double.MaxValue;     //方差
            int num=-1;
                        
            //计算待识别图像与训练集合中每张图像特征值的方差               
            for(int i = 0; i < images.Count; i++)
            {
                double this_distance = 0;
                for(int j = 0; j < 15; j++)
                {
                    this_distance += Math.Pow(images[i].pixelNum[j] - img.pixelNum[j], 2.0);
                }
                this_distance = Math.Sqrt(this_distance);
                //取最小的距离
                if (distance > this_distance)
                {
                    distance = this_distance;
                    num = i
;                }
            }
            if (num == -1)
            {
                return -1;
            }
            return num/10;
        }

    }
}
