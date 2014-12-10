using System.Collections.Generic;
using System.IO;

namespace Yourfirefly.EQSM
{
    public class SettingsLoader
    {
        public List<Character> Characters;
        public List<KeyValuePair<int, string>> EQAbilities;
        private string _eqLocation;
        private FormMain _mainForm;
        private readonly string[] _eqLocations =
        {
            @"Users\Public\Public Games\EverQuest",
            @"Users\Public\Sony Online Entertainment\EverQuest",
            @"%PROGRAMFILES(x86)%\Sony\EverQuest",
            @"%PROGRAMFILES%\Sony\EverQuest",
            @"Users\Ryan\Downloads\EverQuest"
            //@"Users\Ryan\Desktop"
        };

        public SettingsLoader()
        {
            Characters = new List<Character>();
            EQAbilities= new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "1H Blunt"),
                new KeyValuePair<int, string>(1, "1H Slashing"),
                new KeyValuePair<int, string>(2, "2H Blunt"),
                new KeyValuePair<int, string>(3, "2H Slashing"),
                new KeyValuePair<int, string>(4, "Abjuration"),
                new KeyValuePair<int, string>(5, "Alteration"),
                new KeyValuePair<int, string>(6, "Apply Poison"),
                new KeyValuePair<int, string>(7, "Archery"),
                new KeyValuePair<int, string>(8, "Backstab"),
                new KeyValuePair<int, string>(9, "Bind Wound"),
                new KeyValuePair<int, string>(10, "Bash"),
                new KeyValuePair<int, string>(11, "Block"),
                new KeyValuePair<int, string>(12, "Brass Instruments"),
                new KeyValuePair<int, string>(13, "Channeling"),
                new KeyValuePair<int, string>(14, "Conjuration"),
                new KeyValuePair<int, string>(15, "Defense"),
                new KeyValuePair<int, string>(16, "Disarm"),
                new KeyValuePair<int, string>(17, "Disarm Traps"),
                new KeyValuePair<int, string>(18, "Divination"),
                new KeyValuePair<int, string>(19, "Dodge"),
                new KeyValuePair<int, string>(20, "Double Attack"),
                new KeyValuePair<int, string>(21, "Dragon Punch"),
                new KeyValuePair<int, string>(22, "Duel Wield"),
                new KeyValuePair<int, string>(23, "Eagle Strike"),
                new KeyValuePair<int, string>(24, "Evocation"),
                new KeyValuePair<int, string>(25, "Feign Death"),
                new KeyValuePair<int, string>(26, "Flying Kick"),
                new KeyValuePair<int, string>(27, "Forage"),
                new KeyValuePair<int, string>(28, "Hand To Hand"),
                new KeyValuePair<int, string>(29, "Hide"),
                new KeyValuePair<int, string>(30, "Kick"),
                new KeyValuePair<int, string>(31, "Meditate"),
                new KeyValuePair<int, string>(32, "Mend"),
                new KeyValuePair<int, string>(33, "Offense"),
                new KeyValuePair<int, string>(34, "Parry"),
                new KeyValuePair<int, string>(35, "Pick Lock"),
                new KeyValuePair<int, string>(36, "Piercing"),
                new KeyValuePair<int, string>(37, "Riposte"),
                new KeyValuePair<int, string>(38, "Round Kick"),
                new KeyValuePair<int, string>(39, "Safe Fall"),
                new KeyValuePair<int, string>(40, "Sense Heading"),
                new KeyValuePair<int, string>(41, "Sing"),
                new KeyValuePair<int, string>(42, "Sneak"),
                new KeyValuePair<int, string>(43, "Specialize Abjure"),
                new KeyValuePair<int, string>(44, "Specialize Alteration"),
                new KeyValuePair<int, string>(45, "Specialize Conjuration"),
                new KeyValuePair<int, string>(46, "Specialize Divination"),
                new KeyValuePair<int, string>(47, "Specialize Evocation"),
                new KeyValuePair<int, string>(48, "Pick Pockets"),
                new KeyValuePair<int, string>(49, "Stringed Instruments"),
                new KeyValuePair<int, string>(50, "Swimming"),
                new KeyValuePair<int, string>(51, "Throwing"),
                new KeyValuePair<int, string>(52, "Tiger Claw"),
                new KeyValuePair<int, string>(53, "Tracking"),
                new KeyValuePair<int, string>(54, "Wind Instruments"),
                new KeyValuePair<int, string>(55, "Fishing"),
                new KeyValuePair<int, string>(56, "Make Poison"),
                new KeyValuePair<int, string>(57, "Tinkering"),
                new KeyValuePair<int, string>(58, "Research"),
                new KeyValuePair<int, string>(59, "Alchemy"),
                new KeyValuePair<int, string>(60, "Baking"),
                new KeyValuePair<int, string>(61, "Tailoring"),
                new KeyValuePair<int, string>(62, "Sense Traps"),
                new KeyValuePair<int, string>(63, "Blacksmithing"),
                new KeyValuePair<int, string>(64, "Fletching"),
                new KeyValuePair<int, string>(65, "Brewing"),
                new KeyValuePair<int, string>(66, "Alcohol Tolerance"),
                new KeyValuePair<int, string>(67, "Begging"),
                new KeyValuePair<int, string>(68, "Jewelry Making"),
                new KeyValuePair<int, string>(69, "Pottery"),
                new KeyValuePair<int, string>(70, "Percussion Instruments"),
                new KeyValuePair<int, string>(71, "Intimidation"),
                new KeyValuePair<int, string>(72, "Berserking"),
                new KeyValuePair<int, string>(73, "Taunt"),
                new KeyValuePair<int, string>(74, "Frenzy")
            };
        }
        
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
                    Characters.Add(new Character(file.DirectoryName, file.Name));
                }
            }
        }
    }
}
