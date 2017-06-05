using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMicrosoftAccess2017
{
    public class clsNewDataBase
    {
        private string vfileName;
        private string vtypeFile;
        private string vlocation;

     
        public string FileName
        {
            get { return vfileName;}
            set { vfileName = value;}
        }

        public string TypeFile
        {
            get { return vtypeFile; }
            set { vtypeFile = value;}
        }

        public string Location
        {
            get { return vlocation; }
            set { vlocation = value; }
        }

        public  clsNewDataBase(string FileName, string TypeFile, string Location)
        {
            this.FileName = FileName;
            this.TypeFile = TypeFile;
            this.Location = Location;
        }

        public string Afficher()
        {
            string info = "";
            info = info + "File Name :" + FileName + "\n";
            info = info + "Type :" + TypeFile + "\n";
           
            return info;
        }
    }
}
