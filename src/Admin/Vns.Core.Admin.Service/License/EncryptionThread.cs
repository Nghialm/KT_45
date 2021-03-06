using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace RSADecrypt
{
    public class RSAEncryptionThread
    {
        public RSAEncryptionThread()
        {
           
        }

        //public byte[] RSAEncrypt(byte[] DataToEncrypt)
        //{
        //    try
        //    {
        //        // TODO: Add Proper Exception Handlers
        //        RSAEncryption rsa = new RSAEncryption();

        //        int keySize = rsa.uiKeySize / 8;
        //        int maxLength = keySize - 42;
        //        int dataLength = DataToEncrypt.Length;
        //        int iterations = dataLength / maxLength;

        //        byte[] byteBuilder = new byte[(iterations + 1) * rsa.uiKeySize / 8];
        //        byteBuilder.Initialize();

        //        int iNextOffset = 0;
        //        for (int i = 0; i <= iterations; i++)
        //        {
        //            byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
        //            Buffer.BlockCopy(DataToEncrypt, maxLength * i, tempBytes, 0, tempBytes.Length);
        //            byte[] encryptedBytes = rsa.PrivateEncryption(tempBytes);

        //            Buffer.BlockCopy(encryptedBytes, 0, byteBuilder, iNextOffset, encryptedBytes.Length);
        //            iNextOffset += encryptedBytes.Length;
        //        }
        //        return byteBuilder;
        //    }
        //    catch (CryptographicException e)
        //    {
        //        //Console.WriteLine(e.ToString());
        //        return null;
        //    }

        //}

        public byte[] RSADecrypt(byte[] DataToDecrypt)
        {
            try
            {
                RSAEncryption rsa = new RSAEncryption();

                int iDataLenght = rsa.uiKeySize / 8;
                int iterations = DataToDecrypt.Length / iDataLenght;
                int iNextOffset = 0;

                byte[] byteBuilder = new byte[iterations * iDataLenght];
                byteBuilder.Initialize();

                for (int i = 0; i < iterations; i++)
                {
                    byte[] Temp = new byte[iDataLenght];

                    Buffer.BlockCopy(DataToDecrypt, i * iDataLenght, Temp, 0, iDataLenght);

                    //use private encryption
                    byte[] DecryptedBytes = rsa.PublicDecryption(Temp);

                    Buffer.BlockCopy(DecryptedBytes, 0, byteBuilder, iNextOffset, DecryptedBytes.Length);
                    iNextOffset += DecryptedBytes.Length;
                }
                return byteBuilder;
            }
            catch (CryptographicException e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }
        }


        //hash function
        public byte[] SHAComputeHash(byte[] dataArray)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(dataArray);
        }

        //Verify Signature
        public bool VerifySignatureOnFile(string strFileName)
        {
            bool bOK = true;

            if (File.Exists(strFileName))
            {
                RSAEncryption rsa = new RSAEncryption();

                int iSizeOfData = 12 * rsa.uiKeySize/8;
                int iSizeOfSig = rsa.uiKeySize / 8;

                FileStream fs = File.Open(strFileName, FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                byte[] DataEncrypted = new byte[iSizeOfData];
                byte[] DataSignature = new byte[iSizeOfSig];

                br.Read(DataEncrypted, 0, iSizeOfData);
                br.Read(DataSignature, 0, iSizeOfSig);

                //byte[] Decrypted = RSADecrypt(DataEncrypted);
                byte[] SignatureCreated = SHAComputeHash(DataEncrypted);

                byte[] SignatureFromFile = RSADecrypt(DataSignature);

                //compare signature
                for (int i = 0; i < SignatureFromFile.Length; i++)
                {
                    if (SignatureCreated[i] != SignatureFromFile[i])
                    {
                        bOK = false;
                        break;
                    }
                }
                br.Close();
                fs.Close();
           }
           else
           {
               bOK = false;
           }

           return bOK;
        }

        public string DecryptBlock86(string strFullPath, int iBlock)
        {
            try
            {
                //check signature on file
                if (!VerifySignatureOnFile(strFullPath))
                    return "";

                FileStream fs = File.Open(strFullPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                byte[] DataEncrypted = new byte[128];
                br.Read(DataEncrypted, iBlock, 128);
                byte[] DataDecrypted = RSADecrypt(DataEncrypted);
                string strResult = Encoding.ASCII.GetString(DataDecrypted);
                
                br.Close();
                fs.Close();

                return strResult;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }


    public static class UnitReaderInstance
    {
        public const string strFileName = "xxx";

        // GetUnitIdNumber Hàm này dùng để lấy lại mã quan hệ ngân sách từ key sinh ra(hoặc file ) return về string có 7 ký tự.
        public static string GetUnitIdNumber(string strPath)
        {
            try
            {
                string strFullPath = strPath + "\\" + strFileName;
                RSAEncryptionThread rsa = new RSAEncryptionThread();
                string strOutput = rsa.DecryptBlock86(strFullPath, 0);
                string strID = strOutput.Substring(43,43);
                return strID;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        // GetUnitIdDate hàm này return chuỗi 10 ký tự theo định dạng dd/MM/yyyy
        public static string GetUnitIdDate(string strPath)
        {
            string strID = "";
            try
            {
                string strFullPath = strPath + "\\" + strFileName;
                RSAEncryptionThread rsa = new RSAEncryptionThread();

                string strOutput = rsa.DecryptBlock86(strFullPath, 2);
                strID = strOutput.Substring(14, 10);

                return strID;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        // GetUnitName hàm này return chuỗi 100 ki tu la ten don vi
        public static string GetUnitIdName(string strPath)
        {
            string strName = "";
            try
            {
                string strFullPath = strPath + "\\" + strFileName;
                RSAEncryptionThread rsa = new RSAEncryptionThread();

                string strOutput     = rsa.DecryptBlock86(strFullPath, 1);
                strOutput           += rsa.DecryptBlock86(strFullPath, 2);
                strName = strOutput.Substring(0, 100);
            }
            catch (System.Exception ex)
            {
                return "";
            }

            return strName;
        }
    }
}