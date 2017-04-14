using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using System.Net.NetworkInformation;

namespace RSADecrypt
{
    public class DecryptUtil
    {
        public static byte[] DataEncrypted;
        public static byte[] DataSignature;

        //Verify Signature
        public static void ReadDataFromFile(string strFileName)
        {


            if (File.Exists(strFileName))
            {
                RSAEncryption rsa = new RSAEncryption();

                int iSizeOfData = 12 * rsa.uiKeySize / 8;
                int iSizeOfSig = rsa.uiKeySize / 8;

                FileStream fs = File.Open(strFileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                DataEncrypted = new byte[iSizeOfData];
                DataSignature = new byte[iSizeOfSig];

                br.Read(DataEncrypted, 0, iSizeOfData);
                br.Read(DataSignature, 0, iSizeOfSig);


                br.Close();
                fs.Close();
            }


        }
        public static String GetMacAddress(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            String version = s.Substring(0, 3);
            string strID = s.Substring(3, 17);
            return strID;
        }
        public static String GetMaSoThue(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            String maSoThue = s.Substring(20, 15);
            return maSoThue;
        }
        public static String Decrypt(byte[] DataEncrypted, int iBlock, Encoding endcoding)
        {
            int startPos = iBlock * 128;
            byte[] DataToDecrypt = new byte[128];
            //br.Read(DataEncrypted, startPos, 128);
            //DataEncrypted.CopyTo(DataToDecrypt, 0);

            Buffer.BlockCopy(DataEncrypted, startPos, DataToDecrypt, 0, 128);

            RSAEncryptionThread rsaThread = new RSAEncryptionThread();
            byte[] DataDecrypted = rsaThread.RSADecrypt(DataToDecrypt);

            //string strResult = Encoding.UTF8.GetString(DataDecrypted);
            string strResult = endcoding.GetString(DataDecrypted);
            return strResult;
        }
        public static String GetMaQuanHe(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            String version = s.Substring(0, 2);
            string strID = s.Substring(43, 7);
            return strID;
        }
        public static String GetMaQuanHeCapCha(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            string strID = s.Substring(50, 7);
            return strID;
        }
        public static String GetMaDonVi(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            string strID = s.Substring(57);
            string maDonVi = strID.Split('\0')[0];
            if (maDonVi != null) maDonVi = maDonVi.Trim();
            return maDonVi;
        }
        public static byte[] GetByte86(byte[] DataEncrypted, int iBlock)
        {
            int startPos = iBlock * 128;
            byte[] DataToDecrypt = new byte[128];
            //br.Read(DataEncrypted, startPos, 128);
            //DataEncrypted.CopyTo(DataToDecrypt, 0);

            //Buffer.BlockCopy(DataEncrypted, startPos, DataToDecrypt, 0, 128);
            Buffer.BlockCopy(DataEncrypted, startPos, DataToDecrypt, 0, 128);

            RSAEncryptionThread rsaThread = new RSAEncryptionThread();
            byte[] DataDecrypted = rsaThread.RSADecrypt(DataToDecrypt);
            byte[] ByteResult = new byte[86];
            Buffer.BlockCopy(DataDecrypted, 0, ByteResult, 0, 86);
            return ByteResult;
            ////string strResult = Encoding.UTF8.GetString(DataDecrypted);
            //string strResult = endcoding.GetString(DataDecrypted);
            //return strResult;
        }
        public static String GetTenDonVi(byte[] DataEncrypted)
        {
            byte[] DataDecrypted = new byte[430];
            Buffer.BlockCopy(GetByte86(DataEncrypted, 1), 0, DataDecrypted, 0, 86);
            Buffer.BlockCopy(GetByte86(DataEncrypted, 2), 0, DataDecrypted, 1 * 86, 86);
            Buffer.BlockCopy(GetByte86(DataEncrypted, 3), 0, DataDecrypted, 2 * 86, 86);
            Buffer.BlockCopy(GetByte86(DataEncrypted, 4), 0, DataDecrypted, 3 * 86, 86);
            Buffer.BlockCopy(GetByte86(DataEncrypted, 5), 0, DataDecrypted, 4 * 86, 86);

            string s = Encoding.UTF8.GetString(DataDecrypted);
            string strName = s.Split('\0')[0];
            if (strName != null) strName = strName.Trim();
            return strName;
        }
        public static String GetStartDate(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 6, Encoding.ASCII);
            String strID = s.Substring(10, 10);
            string sStartDate = strID.Split('\0')[0];
            return sStartDate;
        }
        public static String GetEndDate(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 6, Encoding.ASCII);
            String strID = s.Substring(0, 10);
            string sEndDate = strID.Split('\0')[0];
            return sEndDate;
        }
        public static string GetMaPhanMem(byte[] DataEncrypted)
        {
            String s = Decrypt(DataEncrypted, 0, Encoding.ASCII);
            string strID = s.Substring(4);
            string maPhanMem = strID.Split('\0')[0];
            return maPhanMem;
        }

        public static bool ValidateKey(string fileKeyPath, string maDonVi, DateTime ngayVersion)
        {
            if (File.Exists(fileKeyPath))
            {
                RSAEncryption rsa = new RSAEncryption();
                int iSizeOfData = 12 * rsa.uiKeySize / 8;
                int iSizeOfSig = rsa.uiKeySize / 8;
                FileStream fs = File.Open(fileKeyPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] localDataEncrypted = new byte[iSizeOfData];
                byte[] localDataSignature = new byte[iSizeOfSig];
                br.Read(localDataEncrypted, 0, iSizeOfData);
                br.Read(localDataSignature, 0, iSizeOfSig);
                br.Close();
                fs.Close();
                string keyMaDonVi = GetMaDonVi(localDataEncrypted);
                string keyMaQuanHeNganSach = GetMaQuanHe(localDataEncrypted);
                string keyMaPhanMem = GetMaPhanMem(localDataEncrypted);
                try
                {
                    if ((maDonVi != null) && (!maDonVi.Equals(keyMaDonVi)))
                    {
                        if (!maDonVi.Equals(keyMaQuanHeNganSach))
                        {
                            return false;
                        }
                    }
                    string strEndDate = GetEndDate(localDataEncrypted);
                    DateTime endDate = DateTime.Parse(strEndDate);
                    if (endDate.CompareTo(System.DateTime.Now) < 0)
                    {
                        return false;
                    }
                    if (ngayVersion.CompareTo(endDate) > 0)
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public static PhysicalAddress GetPhysicalAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }
        public static string GetMachineMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                String s = adapter.GetPhysicalAddress().ToString();
                string s1 = adapter.Name;
                //System.Console.WriteLine(s + ":" + s1 + ":" + adapter.NetworkInterfaceType.ToString());

                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
        public static bool ValidateKey(string maPhanMem, string fileKeyPath, string maDonVi, string maQuanHeNganSach, DateTime ngayVersion)
        {
            if (File.Exists(fileKeyPath))
            {
                RSAEncryption rsa = new RSAEncryption();
                int iSizeOfData = 12 * rsa.uiKeySize / 8;
                int iSizeOfSig = rsa.uiKeySize / 8;
                FileStream fs = File.Open(fileKeyPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] localDataEncrypted = new byte[iSizeOfData];
                byte[] localDataSignature = new byte[iSizeOfSig];
                br.Read(localDataEncrypted, 0, iSizeOfData);
                br.Read(localDataSignature, 0, iSizeOfSig);
                br.Close();
                fs.Close();
                string keyMaDonVi = GetMaDonVi(localDataEncrypted);
                string keyMaQuanHeNganSach = GetMaQuanHe(localDataEncrypted);
                string keyMaPhanMem = GetMaPhanMem(localDataEncrypted);
                try
                {
                        if ((maPhanMem != null) && (!maPhanMem.Equals(keyMaPhanMem)))
                        {
                            return false;
                        }

                        if ((maDonVi != null) && (!maDonVi.Equals(keyMaDonVi)))
                        {
                            return false;
                        }

                        if ((maQuanHeNganSach != null)&&(!maQuanHeNganSach.Equals(keyMaQuanHeNganSach)))
                        {
                            return false;
                        }
                        string strEndDate = GetEndDate(localDataEncrypted);
                        DateTime endDate = DateTime.Parse(strEndDate);
                        if (endDate.CompareTo(System.DateTime.Now) < 0)
                        {
                            return false;
                        }
                        if (ngayVersion.CompareTo(endDate)>0)
                        {
                            return false;
                        }
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
