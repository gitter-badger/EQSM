using System.Runtime.InteropServices;
using System.Text;

namespace Yourfirefly.EQSM
{
    /// <summary>
    /// Reads from or writes to a INI file.
    /// </summary>
    public class IniFile
    {
        /// <summary>
        /// The path to the INI file.
        /// </summary>
        public string Path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// Initializes a new instance of the <see cref="IniFile"/> class.
        /// </summary>
        /// <param name="iniPath">The path to the INI file.</param>
        public IniFile(string iniPath)
        {
            Path = iniPath;
        }

        /// <summary>
        /// Write a value to INI file.
        /// </summary>
        /// <param name="section">The INI section.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        /// <summary>
        /// Read a value from INI file.
        /// </summary>
        /// <param name="section">The section.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public string IniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, Path);
            return temp.ToString();

        }
    }
}