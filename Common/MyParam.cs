using JohnNguyen.Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Demo.Common
{
    public static class MyParam
    {

        public static string ftpServer;
        public static string userName;
        public static string passWord;
        public static string ftpDir;

        public static string token = null;
        public static List<string> list_printer = MyLib.Get_List_Printer();

        public static eViewWindow cur_view = eViewWindow.View_None;

        public static ImageList my_image_list;
        public static List<string> my_list_image;
        static int number_create = 0;

        public static List<TaskLoop> taskLoops = new List<TaskLoop>();

        static MyParam()
        {
            my_image_list = new ImageList();
            my_image_list.ImageSize = new Size(100, 100);
            my_list_image = new List<string>();

            for (int i = 0; i < MyDefine.NUM_THREAD; i++)
            {
                taskLoops.Add(new TaskLoop());
            }

            Console.WriteLine($"Constructor MyParam = {number_create++}");

            ftpServer = "127.0.0.1";
            userName = "thh";
            passWord = "thh@2022";
            ftpDir = "robot";

        }

    }
}
