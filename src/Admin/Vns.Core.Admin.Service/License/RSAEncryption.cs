//************************************************************************************
// RSAEncryption Class Version 1.00
//************************************************************************************

#define MODE_GENERATE_CODE

using System;
using System.Xml;
using System.Security;
using System.Security.Cryptography;

namespace RSADecrypt
{
    public class RSAEncryption : IDisposable
    {
        // Members:
        // RSA Key components (just the three I'm using, there is more...)
        private BigInteger D = null;
        private BigInteger Exponent = null;
        private BigInteger Modulus = null;

        private const string strXMLPublicKey = "<RSAKeyValue><Modulus>rYQhAesG4WsudvsvJILyYJ6IHuX/lHttw7JJs2ilXfkoWeFbRi2XIB3UPqszU/oNG9pJrAIw46YiVUSl4DQBvZWZuEy5QO+rZIJLNziavKcMSfguJd9ceCCytHvF9sId6l8sOB+e7vTf7BKu9Mg+s3dfvXOz4i5TFrobgQPzqvE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";


        // .NET RSA class, for loading and creating key pairs
        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        // flags, is the keys has been loaded yet?
        private bool isPrivateKeyLoaded = false;
        private bool isPublicKeyLoaded = false;

        private const int iKeySize = 1024;

        // Properties
        public bool IsPrivateKeyLoaded
        { get { return isPrivateKeyLoaded; } }

        public bool IsPublicKeyLoaded
        { get { return isPublicKeyLoaded; } }

        public int uiKeySize
        { get { return iKeySize; } }

        //constructor
        public RSAEncryption()
        {
            LoadPublicFromXml(strXMLPublicKey);
        }

        // Methods:
        public void LoadPublicFromXml(string xmlPublicKey)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlPublicKey);

                Modulus  = new BigInteger(Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Modulus").InnerText));
                Exponent = new BigInteger(Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Exponent").InnerText));

                isPublicKeyLoaded = true;
            }
            // Examle for the proper use of try - catch blocks: Informing the main app where and why the Exception occurred
            catch (XmlSyntaxException ex)  // Not an xml file
            {
                string excReason = "Exception occurred at LoadPublicFromXml(), Selected file is not a valid xml file.";
                System.Diagnostics.Debug.WriteLine(excReason + " Exception Message: " + ex.Message);
                throw new Exception(excReason, ex);
            }
            catch (CryptographicException ex)  // Not a Key file
            {
                string excReason = "Exception occurred at LoadPublicFromXml(), Selected xml file is not a public key file.";
                System.Diagnostics.Debug.WriteLine(excReason + " Exception Message: " + ex.Message);
                throw new Exception(excReason, ex);
            }
            catch (Exception ex)  // other exception, hope the ex.message will help
            {
                string excReason = "General Exception occurred at LoadPublicFromXml().";
                System.Diagnostics.Debug.WriteLine(excReason + " Exception Message: " + ex.Message);
                throw new Exception(excReason, ex);
            }
            // You might want to replace the Diagnostics.Debug with your Log statement
        }

//        // Same as the previous one, but this time loading the private Key
//#if MODE_GENERATE_CODE
//        public void LoadPrivateFromXml(string xmlPrivateKey)
//        {
//            try
//            {
//                XmlDocument doc = new XmlDocument();
//                doc.LoadXml(xmlPrivateKey);

//                Modulus = new BigInteger(Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Modulus").InnerText));
//                D       = new BigInteger(Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("D").InnerText));
//                //Exponent = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Exponent").InnerText);

//                isPrivateKeyLoaded = true;
//            }
//            catch (Exception ex)
//            {
//                System.Diagnostics.Debug.WriteLine("Exception occurred at LoadPrivateFromXml()\nMessage: " + ex.Message);
//                throw ex;
//            }
//        }

//        // Encrypt data using private key
//        public byte[] PrivateEncryption(byte[] data)
//        {
//            if (!IsPrivateKeyLoaded)  // is the private key has been loaded?
//                throw new CryptographicException
//                    ("Private Key must be loaded before using the Private Encryption method!");

//            // Converting the byte array data into a BigInteger instance
//            BigInteger bnData = new BigInteger(data);

//            // (bnData ^ D) % Modulus - This Encrypt the data using the private Exponent: D
//            BigInteger encData = bnData.modPow(D, Modulus);
//            return encData.getBytes();
//        }
//#endif

        // Decrypt data using public key (for data encrypted with private key)
        public byte[] PublicDecryption(byte[] encryptedData)
        {
            if (!IsPublicKeyLoaded)  // is the public key has been loaded?
                throw new CryptographicException
                    ("Public Key must be loaded before using the Public Deccryption method!");

            // Converting the encrypted data byte array data into a BigInteger instance
            BigInteger encData = new BigInteger(encryptedData);

            // (encData ^ Exponent) % Modulus - This Decrypt the data using the public Exponent
            BigInteger bnData = encData.modPow(Exponent, Modulus);
            return bnData.getBytes();
        }

        // Implementation of IDisposable interface,
        // allow you to use this class as: using(RSAEncryption rsa = new RSAEncryption()) { ... }
        public void Dispose()
        {
            rsa.Clear();
        }
    }
}
