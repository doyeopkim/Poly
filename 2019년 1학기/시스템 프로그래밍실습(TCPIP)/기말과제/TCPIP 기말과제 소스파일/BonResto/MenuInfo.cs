using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonResto
{
    public class MenuInfo
    {
        public ListView menu = new ListView();
        public ImageList menuimg = new ImageList();
        int menuindex;

        public MenuInfo(ListView menuType, ImageList img)
        {
            menu = menuType;
            menuimg = img;
            menuimg.ImageSize = new Size(100, 100);
        }

        //메뉴 객체에 이름, 가격, 사진을 저장
        public void addMenu(string name, string price, string imgpath)
        {
            menuindex = menu.Items.Count;
            menuimg.Images.Add(Image.FromFile(imgpath));
            menu.Items.Add(name, menuindex);
            menu.Items[menuindex].Tag = price;
        }

        //메뉴 종류에 맞는 경로에 사진파일을 저장
        public string FileCopy(string sourceFile, string destPath, string fileName)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            string filePath = Path.GetDirectoryName(sourceFile);  // 파일 경로
            string fileExt = Path.GetExtension(sourceFile); //파일 확장자
            fileName += fileExt;
            string newFile = Path.Combine(destPath, fileName);
            if (File.Exists(newFile))  // 파일의 존재 유무 확인 : 파일이 존재하면
            {
                File.Delete(newFile);  // 존재하는 파일 삭제
                File.Copy(sourceFile, newFile);
            }
            else   // 파일의 존재하지 않으면    

            {
                File.Copy(sourceFile, newFile);
            }
            return newFile;
        }
    }
}
