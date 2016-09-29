using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Authentication;
using System.Security;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Uni.Educational.Interop;
using Uni.Educational.IoC.Services;

namespace Uni.Educational.Security
{
    public class AuthenticationProvider : ISecurityProvider
    {

        public IoC.ApplicationContext ApplicationContext { get; set; }

        private const string USER_CREDENTIAL_KEY = @"SOFTWARE\UNI.EDU.SECURITY\UserCredentials";

        public void SaveCredentials(string username, SecureString password)
        {
            var userCredentialHive = string.Format(USER_CREDENTIAL_KEY);
            var key = Registry.CurrentUser.OpenSubKey(userCredentialHive);

            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey(userCredentialHive);
            }

            key.SetValue("Username", username, RegistryValueKind.String);
            key.SetValue("Password", password, RegistryValueKind.Binary);

        }

        public bool Authenticate(string username, SecureString password)
        {
            var userCredentialHive = string.Format(USER_CREDENTIAL_KEY);
            var key = Registry.CurrentUser.OpenSubKey(userCredentialHive);

            var regUsername = (string)key.GetValue("Username");
            var regPassword = (SecureString)key.GetValue("Password");

            return String.Compare(username, regUsername, StringComparison.InvariantCulture) == 0
                && SecureStringEqual(password, regPassword);
        }

        // This is using memcmp to avoid having to mark the assembly is Unsafe
        // and it doesn't convert the SecureString(s) to BSTRs and then to plain strings
        bool SecureStringEqual(SecureString s1, SecureString s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            IntPtr bstr1 = IntPtr.Zero;
            IntPtr bstr2 = IntPtr.Zero;

            RuntimeHelpers.PrepareConstrainedRegions();

            try
            {
                bstr1 = Marshal.SecureStringToBSTR(s1);
                bstr2 = Marshal.SecureStringToBSTR(s2);

                return Win32.memcmp(bstr1, bstr2, new UIntPtr((uint)s1.Length)) == 0;
            }
            finally
            {
                if (bstr1 != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(bstr1);
                }

                if (bstr2 != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(bstr2);
                }
            }
        }


        public bool RetreiveCredentials(ref string username, ref SecureString password)
        {
            var userCredentialHive = string.Format(USER_CREDENTIAL_KEY);
            var key = Registry.CurrentUser.OpenSubKey(userCredentialHive);

            var regUsername = (string)key.GetValue("Username");
            var regPassword = (SecureString)key.GetValue("Password");

            username = regUsername;
            password = regPassword;

            return true;
        }

        public void Initialize()
        {
        }

        public void Shutdown()
        {

        }
    }
}
