string tmpData = xpi.Current.SelectSingleNode("my:ImageFile", this.NamespaceManager).Value; 

byte[] imgData=Convert.FromBase64String(tmpData);

int fileNameLength = imgData[20]*2;
byte[] fileName  = new byte[fileNameLength];
for (int i = 0; i < fileNameLength; i++)
{
    fileName[i] = imgData[24 + i];
}

char[] asciiName = UnicodeEncoding.Unicode.GetChars(fileName);
string stringName = new string(asciiName);
stringName = stringName.Substring(0, filename.Length - 1);

byte[] binaryFile = new byte[imgData.Length-(24+fileNameLenght)];
for (int i = 0; i < binaryFile.Length; i++)
{
    binaryFile[i] = imgData[24 + namebufferlen + i];
}            

imgSvc.Credentials = System.Net.CredentialCache.DefaultCredentials;
imgSvc.Upload(imgLibrary, "", binaryFile, stringName, true);
