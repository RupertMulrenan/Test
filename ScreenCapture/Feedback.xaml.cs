using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScreenCapture
{
    /// <summary>
    /// Interaction logic for Feedback.xaml
    /// </summary>
    public partial class Feedback : Window
    {
        public Feedback()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

        public static Bitmap CaptureWindow(IntPtr handle)
        {
            RECT rect = new RECT();
            GetWindowRect(handle, ref rect);

            var bounds = new System.Drawing.Rectangle((int)rect.left, (int)rect.top, (int)(rect.right - rect.left), (int)(rect.bottom - rect.top));

            var result = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new System.Drawing.Point(bounds.Left, bounds.Top), System.Drawing.Point.Empty, bounds.Size);
            }

            return result;
        }

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        Bitmap bitmap { get; set; }

        private void Load()
        {
            if(CaptureWindowPtr == IntPtr.Zero)
            {
                return;
            }
    



            bitmap = PrintWindow(CaptureWindowPtr);
            
            if (bitmap == null)
            {
                return;
            }

            bitmap.Save("Test.jpg", ImageFormat.Jpeg);

          //  Image.Source = ConvertBitmap(bitmap);

           

            //bitmap.Dispose();
        }

        public static Bitmap PrintWindow(IntPtr hwnd)
        {
            RECT rect = new RECT();
            GetWindowRect(hwnd, ref rect);
            var bounds = new System.Drawing.Rectangle((int)rect.left, (int)rect.top, (int)(rect.right - rect.left), (int)(rect.bottom - rect.top));

            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hwnd, hdcBitmap, 0);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }

        public BitmapImage ConvertBitmap(System.Drawing.Bitmap bitmap)
        {
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();

            return image;
        }

        public IntPtr CaptureWindowPtr { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(bitmap == null)
            {
                return;
            }

            bitmap.Save(@"Output.jpg", ImageFormat.Jpeg);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
