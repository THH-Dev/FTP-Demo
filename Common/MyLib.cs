﻿using FTP_Demo.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnNguyen.Lib
{

    public enum eTypeFile
    {
        File_Bartender,
        File_Excel,
        File_SerialNumber,
        File_jpg,
    }

    public enum eCompanyReport
    {

        THH_Report,
        DLP_Report
    }

    public enum ePrintReport
    {
        Print_None,
        Print_Warehouse_Export,
        Print_THH_Handover,
        Print_DLP_Handover
    }


    public enum eViewWindow
    {
        View_None = -1,
        View_Home,
        View_Inventory,
        View_Import,
        View_Export,
        View_Account,
        View_Manager,
        View_Setting,
        View_Dev,
        View_LogOut,
    }
    public enum PrintSKUStatus
    {
        Print,
        Printed
    }
    public enum eActionProduct
    {
        Product_None,
        Product_Edit,
        Product_Create
    }

    public enum eStatusProduct
    {
        Cancel,
        Pending,
        Approved
    }

    public enum eFocus
    {
        Focus_Lost,
        Focus_Got
    }
    public enum eFilter
    {
        Filter_AnyText = 0,
        Filter_Prefix,
        Filter_Regex
    }

    public enum UserPermission
    {
        Admin,
        Accounting,
        Purchase,
        Warehouse,
        Guest,
    }

    public enum SQLTable
    {
        TABBLE_NULL = 0,
        TABLE_SKU,
        TABLE_INVENTORY,
        TABLE_INVENTORY_WARNING,
        TABLE_WEB_BRAND,
        TABLE_WEB_CATELOGY,
        TABLE_WEB_CUSTOMER,
        TABLE_WEB_PRODUCT,
        TABLE_WEB_USER,
        TABLE_WEB_WAREHOUSE,
        TABLE_WEB_UNIT
    }



    public enum ProductFormTable
    {
        TABLE_NONE = 0,
        TABLE_IMPORT,
        TABLE_EXPORT,
        TABLE_INVENTORY
    }

    public enum ActionTable
    {
        TABLE_NONE,
        TABLE_CREATE,
        TABLE_EDIT
    }
    public enum API_Type
    {
        //LogIn
        Login,


        //Web Brand
        Create_WebBrand,
        Edit_WebBrand,
        Del_WebBrand,
        Get_WebBrand,


        //Web Category
        Create_WebCategory,
        Edit_WebCategory,
        Del_WebCategory,
        Get_WebCategory,


        //WebUnit
        Create_WebUnit,
        Edit_WebUnit,
        Del_WebUnit,
        Get_WebUnit,

        //WebUser
        Create_WebUser,
        Edit_WebUser,
        Del_WebUser,
        Get_WebUser,


        //WebCustomer
        Create_WebCustomer,
        Edit_WebCustomer,
        Del_WebCustomer,
        Get_WebCustomer,

        //WebProduct
        Create_WebProduct,
        Edit_WebProduct,
        Del_WebProduct,
        Get_WebProduct,

        //WebWarehouse
        Create_WebWarehouse,
        Edit_WebWarehouse,
        Del_WebWarehouse,
        Get_WebWarehouse,

        //WebProductImport
        Create_WebProductImport,
        Edit_WebProductImport,
        Del_WebProductImport,
        Get_WebProductImport,


        //WebProductExport
        Create_WebProductExport,
        Edit_WebProductExport,
        Del_WebProductExport,
        Get_WebProductExport,


        //Find SKU
        Find_Product_bySKU,


        //Inventory
        Get_ProductInventory,
        Get_ProductInventory_Warning


    }



    public class PagingListviewSimplle
    {
        public UInt32 cur_page = 1;
        public UInt32 num_items_per_page = 20;

    }

    public class PagingListview
    {
        public UInt32 cur_page = 1;
        public UInt32 total_page = 1000;
        public UInt32 total_record = 20000;
        public UInt32 num_items_per_page = 20;

        public UInt32 record_start = 0;
        public UInt32 record_end = 20;
    }

    public class MyPermision
    {
        public bool view = false;
        public bool edit = true;
        public bool del = true;
        public bool create = true;

    }
    public static class ViewPermision
    {
        public static MyPermision home = new MyPermision()
        {
            view = true,
            edit = false,
            del = false,
            create = false
        };

        public static MyPermision inventory_all = new MyPermision()
        {
            view = true,
            edit = false,
            del = false,
            create = false
        };
        public static MyPermision inventory_warning = new MyPermision()
        {
            view = true,
            edit = false,
            del = false,
            create = false
        };
        public static MyPermision inventory_list_sku = new MyPermision()
        {
            view = true,
            edit = false,
            del = false,
            create = false
        };


        public static MyPermision import;
        public static MyPermision export;

        public static MyPermision product;
        public static MyPermision customer;
        public static MyPermision warehouse;
        public static MyPermision user;
        public static MyPermision brand;
        public static MyPermision category;
        public static MyPermision unit;

        public static MyPermision setting;
        public static MyPermision dev;
    }

    public class MyDefine
    {
        public static uint NUM_THREAD = 2;

        public static uint WM_LBUTTONDOWN = 0x201;
        public static uint WM_LBUTTONUP = 0x202;

        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public static readonly string workspaceDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string resources_folder = String.Format($"{workingDirectory}\\resources");

        public static readonly string regex_get_image_file = @"[^\s]+(.*?)\.(jpg|jpeg|png|gif|JPG|JPEG|PNG|GIF)$";
        public static readonly string regex_get_ip = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";


        #region Path file json
        public static readonly string file_brand = String.Format($"{workingDirectory}\\Configs\\brand.json");
        public static readonly string file_category = String.Format($"{workingDirectory}\\Configs\\category.json");
        public static readonly string file_user = String.Format($"{workingDirectory}\\Configs\\user.json");
        public static readonly string file_customer = String.Format($"{workingDirectory}\\Configs\\customer.json");
        public static readonly string file_warehouse = String.Format($"{workingDirectory}\\Configs\\warehouse.json");
        public static readonly string file_product = String.Format($"{workingDirectory}\\Configs\\product.json");
        public static readonly string file_unit = String.Format($"{workingDirectory}\\Configs\\unit.json");
        public static readonly string file_setting = String.Format($"{workingDirectory}\\Configs\\setting.json");
        public static readonly string file_import_product_manager = String.Format($"{workingDirectory}\\Configs\\product_import_manager.json");
        public static readonly string file_export_product_manager = String.Format($"{workingDirectory}\\Configs\\product_export_manager.json");
        public static readonly string import_product_tmp = String.Format($"{workingDirectory}\\Data\\Import\\") + @"product_import_{0}_{1}_{2}.json";
        public static readonly string export_product_tmp = String.Format($"{workingDirectory}\\Data\\Export\\") + @"product_export_{0}_{1}_{2}.json";


        public static readonly string file_config = String.Format($"{workingDirectory}\\Configs\\config_param.json");
        public static readonly string file_excel = String.Format($"{workingDirectory}\\Data\\ImportData.xlsx");

        public static readonly string file_config_format_data = String.Format($"{workingDirectory}\\Data\\configs\\format_data.json");
        public static readonly string file_config_common_param = String.Format($"{workingDirectory}\\Data\\configs\\common_param.json");
        public static readonly string file_config_filter_window = String.Format($"{workingDirectory}\\Data\\configs\\filter_window.json");
        public static readonly string path_load_img_database = @"C:\Program Files\Cognex\VisionPro\Images";
        public static readonly string path_load_vpp_file = @"C:\Users\Admin\Desktop\Vpp_file";
        public static readonly string path_save_images = String.Format("{0}\\Images", projectDirectory);

        public static readonly string key_thh = @"https://tanhungha.com.vn/";
        public static readonly string hash_key = "";
        #endregion

        #region api
        public static string API_OK = "success";
        public static string API_NG = "error";
        public static string API_Warning = "warning";
        public static string API_LOSS_CONNECTION = "network";
        #endregion

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

    }

    public class SaveLoadParameter
    {
        public static void Save_Parameter(object param)
        {
            //save
            if (MyLib.File_Is_Exist(MyDefine.file_config))
            {
                Save_Parameter(param, MyDefine.file_config);
            }
            else
            {
                //create folder
                FileInfo fileInfo = new FileInfo(MyDefine.file_config);
                if (!fileInfo.Exists)
                    Directory.CreateDirectory(fileInfo.Directory.FullName);

                //create file
                using (FileStream f = File.Create(MyDefine.file_config))
                {
                    f.Close();
                    Console.WriteLine($"Create file {MyDefine.file_config}");
                }

                //save param to file
                Save_Parameter(param, MyDefine.file_config);
            }
        }

        public static object Load_Parameter(object param)
        {
            if (MyLib.File_Is_Exist(MyDefine.file_config))
            {
                using (StreamReader file = File.OpenText(MyDefine.file_config))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    param = serializer.Deserialize(file, param.GetType());
                }
            }
            else
            {
                MyLib.ShowDlgError($"Not found {MyDefine.file_config}");
            }

            return param;
        }

        public static void Save_Parameter(object param, string file_name)
        {
            //save
            if (MyLib.File_Is_Exist(file_name))
            {
                // serialize JSON directly to a file
                Console.WriteLine("Save parameter to file " + file_name);
                using (StreamWriter file = File.CreateText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, param);
                }
            }
            else
            {
                //create folder
                FileInfo fileInfo = new FileInfo(file_name);
                if (!fileInfo.Exists)
                    Directory.CreateDirectory(fileInfo.Directory.FullName);

                //create file
                using (FileStream f = File.Create(file_name))
                {
                    f.Close();
                    Console.WriteLine($"Create file {file_name}");
                }

                // serialize JSON directly to a file
                Console.WriteLine("Save parameter to file " + file_name);
                using (StreamWriter file = File.CreateText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, param);
                }
            }
        }

        public static object Load_Parameter(object param, string file_name)
        {
            if (MyLib.File_Is_Exist(file_name))
            {
                using (StreamReader file = File.OpenText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    param = serializer.Deserialize(file, param.GetType());
                }
            }
            else
            {
                MyLib.ShowDlgError($"Not found {file_name}");
            }

            return param;
        }
    }


    public enum eTaskLoop
    {
        Task_Producer,
        Task_Comsummer
    }


    

    public sealed class AsyncLock
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        public async Task<IDisposable> LockAsync()
        {
            await _semaphore.WaitAsync();
            return new Handler(_semaphore);
        }

        private sealed class Handler : IDisposable
        {
            private readonly SemaphoreSlim _semaphore;
            private bool _disposed = false;

            public Handler(SemaphoreSlim semaphore)
            {
                _semaphore = semaphore;
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    _semaphore.Release();
                    _disposed = true;
                }
            }
        }
    }


    
    public class TaskLoop
    {

        #region Implementation of INotifyPropertyChanged

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (this.PropertyChanged != null)
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}

        #endregion

        private CancellationTokenSource _cancelSource;
        private readonly AsyncLock _lock = new AsyncLock();
        
        public CancellationTokenSource CancelSource { get => _cancelSource; set => _cancelSource = value; }

        public TaskLoop()
        {
            CancelSource = new CancellationTokenSource();
        }

        ~TaskLoop()
        {
            CancelSource?.Dispose();
        }


        public void ResetToken()
        {
            CancelSource?.Dispose();
            CancelSource = new CancellationTokenSource();
        }

        public void StopLoop()
        {
            CancelSource?.Cancel();
        }



        public async Task RunLoop(int interval, Action action)
        {
            if (action == null)
                return;

            using (await _lock.LockAsync())
            {
                while (!CancelSource.IsCancellationRequested)
                {
                    await Task.Run(() => action());
                    await Task.Delay(interval);
                }
            }
        }

    }



    public class MyLib
    {

        public static string GetLocalIPAddress()
        {
            var localhost = "127.0.0.1";
            bool isNetwork = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (isNetwork)
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return localhost;
            }
            else
            {
                return localhost;
            }
        }

        public static bool File_Is_Exist(string file_name)
        {
            return File.Exists(file_name);
        }

        public static void ShowDlgWarning(string message)
        {
            MessageBox.Show(message);
        }

        public static void ShowDlgError(string message)
        {
            MessageBox.Show(message);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void DragWindow(IntPtr hwnd)
        {
            ReleaseCapture();
            SendMessage(hwnd, 0x112, 0xf012, 0);
        }


        
        public static string OpenFileDialog(eTypeFile type_file, string initDirectory = null)
        {
            string file_name = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if(!String.IsNullOrEmpty(initDirectory))
                openFileDialog.InitialDirectory = initDirectory;

            switch(type_file)
            {
                case eTypeFile.File_Bartender:
                    openFileDialog.Title = "Browse BarTender Files";
                    openFileDialog.DefaultExt = "btw";
                    openFileDialog.Filter = "bartender files (*.btw)|*.btw|All files (*.*)|*.*";
                    break;

                case eTypeFile.File_Excel:
                    openFileDialog.Title = "Browse Excel Files";
                    openFileDialog.DefaultExt = "xlsx";
                    openFileDialog.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    break;
                case eTypeFile.File_SerialNumber:
                    openFileDialog.Title = "Browse File Serial Number";
                    openFileDialog.DefaultExt = "xlsx";
                    openFileDialog.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    break;
                case eTypeFile.File_jpg:
                    openFileDialog.Title = "Browse File Jpg";
                    openFileDialog.DefaultExt = "jpg";
                    openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                    break;
            }
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = openFileDialog.FileName;
            }

            return file_name;
        }

        public static List<string> Get_List_Printer()
        {
            List<string> list_printer = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToList();
            return list_printer;
        }

        

        public static DateTime Timestamp_To_Datetime(UInt64 timestamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timestamp).ToLocalTime();
            return dtDateTime;
        }

        public static UInt64 Datetime_To_TimeStamp(DateTime datetime)
        {
            return (UInt64)(TimeZoneInfo.ConvertTimeToUtc(datetime) - new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        public static Image Download_Image(string fromUrl)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                try
                {
                    using (Stream stream = webClient.OpenRead(fromUrl))
                    {
                        return Image.FromStream(stream);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Download {fromUrl} -> exception: {e.Message}");
                    return null;
                }

            }

            //Image img = null;
            //try
            //{
            //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fromUrl);
            //    request.Timeout = 3000;
            //    request.ReadWriteTimeout = 3000;

            //    var wresp = (HttpWebResponse)request.GetResponse();

            //    using (Stream stream = File.OpenRead(fromUrl))
            //    {
            //        img = Image.FromStream(stream);
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Download exception: {e.Message}");

            //}

            //return img;
        }

        static public bool Download_Image(string url, string path2save)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                try
                {
                    webClient.DownloadFileAsync(new Uri(url), path2save);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Download exception: {e.Message}");
                    return false;
                }

            }
            return true;
        }

        public static void Upload_Image(string dest_address, string file_name, string fpt_username, string pass_word)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential(fpt_username, pass_word);
                    client.UploadFile(dest_address, WebRequestMethods.Ftp.UploadFile, file_name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Upload exception: {e.Message}");
            }

        }

        public static async void UploadImage(string file_name)
        {
            bool result = true;
            string ftp_dest = "";
            Action upload_action = () =>
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        ftp_dest = string.Format($"ftp://{MyParam.ftpServer}/{MyParam.ftpDir}/{Path.GetFileName(file_name)}");
                        client.Credentials = new NetworkCredential(MyParam.userName, MyParam.passWord);
                        client.UploadFile(ftp_dest, WebRequestMethods.Ftp.UploadFile, file_name);
                    }
                }
                catch (Exception e)
                {
                    MyLib.ShowDlgWarning($"Upload exception: {e.Message}");
                    result = false;
                }
            };

            Task task = new Task(upload_action);
            task.Start();
            await task;
            MyLib.ShowDlgWarning($"Upload {Path.GetFileName(file_name)} to {ftp_dest} = {result}");
        }


       public static void DownloadFileFTP()
        {
            string inputfilepath = @"F:\abc.bmp";
            string ftphost = MyParam.ftpServer;
            string ftpfilepath = $"/{MyParam.ftpDir}/cafe.bmp";

            string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            try
            {
                using (WebClient request = new WebClient())
                {
                    request.Credentials = new NetworkCredential(MyParam.userName, MyParam.passWord);
                    byte[] fileData = request.DownloadData(ftpfullpath);

                    using (FileStream file = File.Create(inputfilepath))
                    {
                        file.Write(fileData, 0, fileData.Length);
                        file.Close();
                    }
                    MessageBox.Show("Download Complete");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        
        public static void DownloadFileFTP(string host, string user, string password, string fileftp, string path2save)
        {
            string inputfilepath = path2save;
            string ftphost = host;
            string ftpfilepath = fileftp;

            string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            using (WebClient request = new WebClient())
            {
                request.Credentials = new NetworkCredential(user, password);
                byte[] fileData = request.DownloadData(ftpfullpath);

                using (FileStream file = File.Create(inputfilepath))
                {
                    file.Write(fileData, 0, fileData.Length);
                    file.Close();
                }
                MessageBox.Show("Download Complete");
            }
        }

        static readonly string s1 = @"ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠạẢảẤấẦầẨẩẪẫẬậẮắẰằẲẳẴẵẶặẸẹẺẻẼẽẾếỀềỂểỄễỆệỈỉỊịỌọỎỏỐốỒồỔổỖỗỘộỚớỜờỞởỠỡỢợỤụỦủỨứỪừỬửỮữỰựỲỳỴỵỶỷỸỹ";
        static readonly string s0 = @"AAAAEEEIIOOOOUUYaaaaeeeiioooouuyAaDdIiUuOoUuAaAaAaAaAaAaAaAaAaAaAaAaEeEeEeEeEeEeEeEeIiIiOoOoOoOoOoOoOoOoOoOoOoOoUuUuUuUuUuUuUuYyYyYyYy";
        public static string RemoveDiacritics(string accentedStr)
        {
            List<char> list_char = new List<char>();
            foreach (var c in accentedStr)
            {
                var pos = s1.IndexOf(c);
                if (pos >= 0)
                {
                    list_char.Add(s0[pos]);
                }
                else
                {
                    list_char.Add(c);
                }
            }
            return new string(list_char.ToArray());
        }


        public static bool CreateFolder(string path_folder)
        {
            bool result = Directory.Exists(path_folder);
            if (!result)
            {
                Directory.CreateDirectory(path_folder);
                result = Directory.Exists(path_folder);
            }
            return result;
        }
        public static string GenerateNameImage()
        {
            CreateFolder(MyDefine.path_save_images);
            return String.Format("{0}\\{1}.jpg", MyDefine.path_save_images, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        }

        public static void Save_BitMap(Bitmap bm)
        {
            string file_name = GenerateNameImage();
            bm.Save(file_name, ImageFormat.Jpeg);
            Console.WriteLine("Saved file {0}", file_name);
        }


        public static List<string> Get_All_File_In_Folder(string path, bool debug = false)
        {
            List<string> list_files = null;
            try
            {
                string[] files_xxx = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                list_files = new List<string>(files_xxx);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception {e.Message}");
            }


            if (debug)
            {
                foreach (var file in list_files)
                {
                    Console.WriteLine(file);
                }
            }
            return list_files;
        }

        public static bool IsImagePath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return false;
            Regex regex = new Regex(MyDefine.regex_get_image_file);
            Match match = regex.Match(path);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsIPAddress(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                return false;
            Regex regex = new Regex(MyDefine.regex_get_ip);
            Match match = regex.Match(ip);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public static List<string> Filter_Software_Type(List<string> list_files, string type, bool debug = false)
        {
            List<string> list_files_filter = new List<string>();
            Regex regex = new Regex(type);

            foreach (var file in list_files)
            {
                Match match = regex.Match(file);
                if (match.Success)
                {
                    list_files_filter.Add(file);
                }
            }

            if (debug)
            {
                foreach (var file in list_files_filter)
                {
                    Console.WriteLine(file);
                }
            }
            return list_files_filter;
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }




    }
}
