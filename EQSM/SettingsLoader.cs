using System.Collections.Generic;
using System.IO;

namespace Yourfirefly.EQSM
{
    public class SettingsLoader
    {
        private string _eqLocation;
        private readonly List<Character> _characters;
        private FormMain _mainForm;
        private readonly string[] _eqLocations =
        {
            /*
            @"Users\Public\Public Games\EverQuest",
            @"Users\Public\Sony Online Entertainment\EverQuest",
            @"%PROGRAMFILES(x86)%\Sony\EverQuest",
            @"%PROGRAMFILES%\Sony\EverQuest",
            @"Users\Ryan\Downloads\EverQuest"
            */
            @"Users\Ryan\Desktop"
        };
        
        public SettingsLoader() { _characters = new List<Character>(); }
        
        public FormMain Parent
        {
            get { return _mainForm; }
            set { _mainForm = value; }
        }

        public string[] EQLocations
        {
            get { return _eqLocations; }
        }

        public string EQLocation
        {
            get
            {
                return _eqLocation;
            }
            set
            {
                _eqLocation = value;
                _mainForm.TextEQLocation = value;
                LoadCharacters();
            }
        }

        private void LoadCharacters()
        {
            DirectoryInfo dir = new DirectoryInfo(_eqLocation);
            FileInfo[] files = dir.GetFiles("*_*.ini");
            foreach (FileInfo file in files)
            {
                if (file.Name.Substring(0, 2) != "UI")
                {
                    Character character = new Character(file.DirectoryName, file.Name);
                    _characters.Add(character);
                }
            }
        }
    }
}
