using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices;
using System.Text;

namespace ActiveDirectory
{
    public class Authentication
    {
        private string _filterAttribute;
        private DirectoryEntry entry;

        public string CreateUserAccount(string ldapPath, string userName, string userPassword)
        {
            string oGUID = string.Empty;
            try
            {
                string connectionPrefix = "LDAP://" + ldapPath;
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
                DirectoryEntry newUser = dirEntry.Children.Add
                ("CN=" + userName, "user");
                newUser.Properties["samAccountName"].Value = userName;
                newUser.CommitChanges();
                oGUID = newUser.Guid.ToString();

                newUser.Invoke("SetPassword", new object[] { userPassword });
                newUser.CommitChanges();
                dirEntry.Close();
                newUser.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //Do Something with E.Message.ToString();

            }
            return oGUID;
        }
        public void AddToGroup(string userDn, string groupDn)
        {
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + groupDn);
            dirEntry.Properties["member"].Add(userDn);
            dirEntry.CommitChanges();
            dirEntry.Close();
        }
        public void RemoveUserFromGroup(string userDn, string groupDn)
        {
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + groupDn);
            dirEntry.Properties["member"].Remove(userDn);
            dirEntry.CommitChanges();
            dirEntry.Close();
        }
        public bool Authenticate(string userName,
string password, string domain)
        {
            bool authentic = false;
            try
            {
                entry = new DirectoryEntry("LDAP://" + domain, userName, password);
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }
        public static void Rename(string server,
    string userName, string password, string objectDn, string newName)
        {
            DirectoryEntry child = new DirectoryEntry("LDAP://" + server + "/" +
                objectDn, userName, password);
            child.Rename("CN=" + newName);
        }
        void AddPictureToUser(string strDN, string strDCName, string strFileName)
        {
            System.IO.FileStream inFile = new System.IO.FileStream(strFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] binaryData = new byte[inFile.Length];
            int bytesRead = inFile.Read(binaryData, 0, (int)inFile.Length);
            inFile.Close();
            System.DirectoryServices.DirectoryEntry myUser = new System.DirectoryServices.DirectoryEntry(@"LDAP://" + strDCName + @"/" + strDN);
            myUser.Properties["jpegPhoto"].Clear();
            myUser.Properties["jpegPhoto"].Add(binaryData);
            myUser.CommitChanges();
        }
    }
}