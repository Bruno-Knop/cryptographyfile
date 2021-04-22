using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace cryptographyfile {
    class Cryptography {
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        private static string _encrFloder;
        public static string EncrFloder {
            get {
                return _encrFloder;
            }
            set {
                _encrFloder = value;
                //Define the path
                PubKeyFile = _encrFloder + "rsaPublicKey.txt";
            }
        }

        public static string DecrFloder { get; set; }
        public static string SrcFolder { get; set; }

        //Key Public
        private static string PubKeyFile = EncrFloder + "rsaPublicKey.txt";

        //Key name - Private/Public Key value pair.
        public static string KeyName;

        public static string CreateKey() {
            string result = "";

            //Store Key pair key container
            if (string.IsNullOrEmpty(KeyName)) {
                result = "public Key not defined";
                return result;
            }

            if (!Directory.Exists(EncrFloder)) {
                Directory.CreateDirectory(EncrFloder);
            }

            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly) {
                result = "Key: " + cspp.KeyContainerName + " - Public only";
            }
            else {
                result = "Key: " + cspp.KeyContainerName + " - Key pair complete";
            }

            return result;
        }

        public static bool ExportPublicKey() {
            bool result = true;

            if (rsa == null) {
                return false;
            }

            if (!Directory.Exists(EncrFloder)) {
                Directory.CreateDirectory(EncrFloder);
            }

            StreamWriter sw = new StreamWriter(PubKeyFile, false);
            try {
                sw.Write(rsa.ToXmlString(false));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally {
                sw.Close();
            }

            return result;
        }

        public static string ImportPublicKey() {
            string result = "";

            if (!File.Exists(PubKeyFile)) {
                result = "Key file public not exist";
                return result;
            }

            if (string.IsNullOrEmpty(KeyName)) {
                result = "Public key not defined";
                return result;
            }

            StreamReader sr = new StreamReader(PubKeyFile);

            try {
                cspp.KeyContainerName = KeyName;
                rsa = new RSACryptoServiceProvider(cspp);
                string keytxt = sr.ReadToEnd();
                rsa.FromXmlString(keytxt);
                rsa.PersistKeyInCsp = true;
                if (rsa.PublicOnly) {
                    result = "Key: " + cspp.KeyContainerName + " - Public Only";
                }
                else {
                    result = "Key: " + cspp.KeyContainerName + " - Key pair complete";
                }
            }
            catch (Exception ex) {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally {
                sr.Close();
            }

            return result;
        }

        public static string GetPrivateKey() {
            string result = "";

            if (string.IsNullOrEmpty(KeyName)) {
                result = "Public key not defined";
                return result;
            }

            if (!Directory.Exists(EncrFloder)) {
                Directory.CreateDirectory(EncrFloder);
            }

            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly) {
                result = "Key: " + cspp.KeyContainerName + " - Public Only";
            }
            else {
                result = "Key: " + cspp.KeyContainerName + " - Key pair complete";
            }

            return result;
        }

        //Encrypt & Decrypt Files
        public static string EncryptFile(string inFile) {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            byte[] LenK = new byte[4]; //Key length
            byte[] LenIV = new byte[4]; //boot vector length

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            int startFileName = inFile.LastIndexOf("\\") + 1;
            string outFile = EncrFloder + inFile.Substring(startFileName) + ".enc";

            try {
                using (FileStream outFs = new FileStream(outFile, FileMode.Create)) {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);

                    //Encrypting
                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write)) {
                        int count = 0;
                        int offset = 0;

                        //BlockSizeBytes
                        int sizeBytes = aes.BlockSize / 8;
                        byte[] date = new byte[sizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFs = new FileStream(inFile, FileMode.Open)) {
                            do {
                                count = inFs.Read(date, 0, sizeBytes);
                                offset += count;
                                outStreamEncrypted.Write(date, 0, count);
                                bytesRead += sizeBytes;
                            } while (count > 0);
                            inFs.Close();
                        }
                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();
                    }
                    outFs.Close();
                    //Removing file original
                    DialogResult option = new DialogResult();
                    option = MessageBox.Show("Delete file when finished encryption?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (option == DialogResult.OK) {
                        File.Delete(inFile);
                    } 
                }
            }
            catch (Exception ex) {
                return ex.Message;
            }

            return $"File encrypted.\n Origin: {inFile}\n Destiny: {outFile}";
        }

        public static string DecryptFile(string inFile) {
            Aes aes = Aes.Create();

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            string outFile = DecrFloder + inFile.Substring(0, inFile.LastIndexOf("."));
            //MessageBox.Show(outFile);

            try {
                //Use FileStream objects to read the encrypted one (inFs) and save the decrypted file (ouFs).
                using (FileStream inFs = new FileStream(EncrFloder + inFile, FileMode.Open)) {
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    //Convert value inti
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    //Text encrypted to length
                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    //Matriz encrypted
                    
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    if (!Directory.Exists(DecrFloder)) {
                        Directory.CreateDirectory(DecrFloder);
                    }

                    //RSA Decrypt Key
                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);
                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    //RSA Decrypt File
                    using (FileStream outFs = new FileStream(outFile, FileMode.Create)) {
                        int count = 0;
                        int offset = 0;

                        int sizeBytes = aes.BlockSize / 8;
                        byte[] date = new byte[sizeBytes];

                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outDecrypt = new CryptoStream(outFs, transform, CryptoStreamMode.Write)) {
                            do {
                                count = inFs.Read(date, 0, sizeBytes);
                                offset += count;
                                outDecrypt.Write(date, 0, count);
                            } while (count > 0);

                            outDecrypt.FlushFinalBlock();
                            outDecrypt.Close();
                        }
                        outFs.Close();
                    }
                    inFs.Close();
                }
            }
            catch (Exception ex) {
                return ex.Message;
            }

            return $"File Decrypted.\n Origin: {inFile}\n Destiny: {outFile}";
        }
    }
}
