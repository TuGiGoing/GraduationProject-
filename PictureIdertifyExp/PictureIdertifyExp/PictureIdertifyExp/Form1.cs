using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureIdertifyExp
{
    public partial class SinglePictureIdentify : Form
    {
        /// <summary>被选择的图像路径</summary>
        private string imgPath;
        /// <summary>待识别的文件夹路径 </summary>
        private string filePath;
        /// <summary>图像识别对象 </summary>
        ImageAnalyze ia = new ImageAnalyze();
        /// <summary>存储待识别文件夹的bmp格式文件的路径 </summary>
        List<string> filesList = new List<string>();

        public SinglePictureIdentify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择照片按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            //在pictrureBox显示选择的图像
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                if ("" != openFilePicture.FileName)
                {
                    imgPath = openFilePicture.FileName;
                    picBox.ImageLocation = imgPath;
                }
            }
        }

        /// <summary>
        /// 识别按钮触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIdentify_Click(object sender, EventArgs e)
        {
            //识别被选择的图像
            int temp = ia.AnalyzeResult(imgPath);
            if (temp == -1)
            {
                MessageBox.Show("无法识别图像数字");
            }
            else {
                //显示识别的结果
                lalShowResult.Text = temp.ToString();
            }
        }

        /// <summary>
        /// 选择文件夹按钮触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSelectFiles_Click(object sender, EventArgs e)
        {
            int[] results = new int[10];    //记录每个数字的图像数
            int unknown = 0;               //记录不能被识别的图像数
            filesList.Clear();
            for (int i = 0; i < 10; i++)
            {
                results[i] = 0;
            }
            //选择文件夹
            if (fileSelct.ShowDialog() == DialogResult.OK)
            {
                filePath = fileSelct.SelectedPath;
                txtFiles.Text = filePath;
                try {
                    //获取被选择文件夹目录下所有的bmp格式图像
                    string[] files = Directory.GetFiles(filePath,"*.bmp",SearchOption.AllDirectories);
                    filesList.AddRange(files);
                }
                catch
                {
                    MessageBox.Show("识别文件夹图像失败！");
                    return;
                }
                //识别所有bmp格式图像，并记录结果
                for(int i = 0; i < filesList.Count; i++)
                {
                    int temp = ia.AnalyzeResult(filesList[i]);
                    if (temp == -1)
                    {
                        unknown++;
                    }
                    results[temp]++;
                }
                //将识别结果统计并显示
                listFileIdentifyResult.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    string s = string.Format("数字{0}： {1}张", i, results[i]);
                    listFileIdentifyResult.Items.Add(s);
                }
                if (0 != unknown)
                {
                    string s = string.Format("未知图像： {0}张", unknown);
                }
            }

        }
    }
}
