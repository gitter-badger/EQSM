using System;
using System.Text.RegularExpressions;

namespace Yourfirefly.EQSM
{
    /// <summary>
    /// Contains parameters and functions for reading data from an EverQuest character INI file.
    /// </summary>
    public class Character
    {
        public string Directory { get; set; }
        public string File { get; set; }
        public string Name { get; set; }
        public string Server { get; set; }

        public Friends Friends;
        public Ignored Ignored;
        public Abilities Abilities;
        public CombatSkills CombatSkills;
        public CombatAbilities CombatAbilities;
        public Socials Socials;
        public string InspectText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="directory">The EverQuest directory.</param>
        /// <param name="file">The name of the character's settings INI file.</param>
        public Character(string directory, string file)
        {
            Directory = directory;
            File = file;

            Match fileMatch = Regex.Match(File, @"^(?<name>[A-Z].*)_(?<server>\w+)\.ini$");
            Name = fileMatch.Groups["name"].Value;
            Server = fileMatch.Groups["server"].Value;

            IniFile iniFile = new IniFile(Directory + "\\" + File);
            Friends = new Friends(iniFile);
            Ignored = new Ignored(iniFile);
            Abilities = new Abilities(iniFile);
            CombatSkills = new CombatSkills(iniFile);
            CombatAbilities = new CombatAbilities(iniFile);
            Socials = new Socials(iniFile);
            InspectText = iniFile.IniReadValue("InspectText", "Text");
        }
    }

    /// <summary>
    /// Contains a string array of the character's friends list.
    /// </summary>
    public class Friends
    {
        private readonly string[] _friends = new string[100];

        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <param name="i">The friends list index.</param>
        /// <returns></returns>
        public string this[int i]
        {
            get { return _friends[i]; }
            set { _friends[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Friends"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public Friends(IniFile iniFile)
        {
            for (int i = 0; i < 100; i++)
            {
                string friendValue = iniFile.IniReadValue("Friends", "Friend" + i);

                if (friendValue != "*NULL*" && friendValue != "")
                {
                    _friends[i] = friendValue;
                }
            }
        }
    }

    /// <summary>
    /// Contains a string array of the character's ignored list.
    /// </summary>
    public class Ignored
    {
        private readonly string[] _ignored = new string[100];

        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <param name="i">The ignored list index.</param>
        /// <returns></returns>
        public string this[int i]
        {
            get { return _ignored[i]; }
            set { _ignored[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ignored"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public Ignored(IniFile iniFile)
        {
            for (int i = 0; i < 100; i++)
            {
                string ignoredValue = iniFile.IniReadValue("Ignored", "Ignored" + i);

                if (ignoredValue != "*NULL*" && ignoredValue != "")
                {
                    _ignored[i] = ignoredValue;
                }
            }
        }
    }

    /// <summary>
    /// Contains an int array of the character's abilities.
    /// </summary>
    public class Abilities
    {
        private readonly int[] _abilities = new int[6];

        /// <summary>
        /// Gets or sets the <see cref="System.Int32"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Int32"/>.
        /// </value>
        /// <param name="i">The ability index.</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return _abilities[i]; }
            set { _abilities[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Abilities"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public Abilities(IniFile iniFile)
        {
            for (int i = 0; i < 6; i++)
            {
                string abilityValue = iniFile.IniReadValue("Abilities", "Ability" + (i + 1));
                _abilities[i] = Convert.ToInt32(abilityValue);
            }
        }
    }

    /// <summary>
    /// Contains a uint array of the character's combat skills.
    /// </summary>
    public class CombatSkills
    {
        private readonly uint[] _combatSkills = new uint[4];

        /// <summary>
        /// Gets or sets the <see cref="System.UInt32"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.UInt32"/>.
        /// </value>
        /// <param name="i">The combat skill index.</param>
        /// <returns></returns>
        public uint this[int i]
        {
            get { return _combatSkills[i]; }
            set { _combatSkills[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombatSkills"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public CombatSkills(IniFile iniFile)
        {
            for (int i = 0; i < 4; i++)
            {
                string combatSkillValue = iniFile.IniReadValue("CombatSkills", "CombatSkill" + (i + 1));
                uint.TryParse(combatSkillValue, out _combatSkills[i]);
            }
        }
    }

    /// <summary>
    /// Contains an int array of the character's combat abilities.
    /// </summary>
    public class CombatAbilities
    {
        private readonly int[] _combatAbilities = new int[8];

        /// <summary>
        /// Gets or sets the <see cref="System.Int32"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Int32"/>.
        /// </value>
        /// <param name="i">The combat ability index.</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return _combatAbilities[i]; }
            set { _combatAbilities[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombatAbilities"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public CombatAbilities(IniFile iniFile)
        {
            for (int i = 0; i < 8; i++)
            {
                string combatAbilityValue = iniFile.IniReadValue("CombatAbilities", "CombatAbility" + (i + 1));
                _combatAbilities[i] = Convert.ToInt32(combatAbilityValue);
            }
        }
    }

    /// <summary>
    /// Contains a <see cref="SocialPage"/> array of the character's social pages.
    /// </summary>
    public class Socials
    {
        private readonly SocialPage[] _socialPages = new SocialPage[10];

        /// <summary>
        /// Initializes a new instance of the <see cref="Socials"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        public Socials(IniFile iniFile)
        {
            for (int i = 0; i < 10; i++)
            {
                _socialPages[i] = new SocialPage(iniFile, i + 1);
            }
        }
    }

    /// <summary>
    /// Contains a <see cref="SocialButton"/> array of the character's social buttons for a specified page.
    /// </summary>
    public class SocialPage
    {
        private readonly SocialButton[] _buttons = new SocialButton[10];

        public SocialButton this[int i]
        {
            get { return _buttons[i]; }
            set { _buttons[i] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialPage"/> class.
        /// </summary>
        /// <param name="iniFile">The IniFile instance to load settings from.</param>
        /// <param name="page">The social page index.</param>
        public SocialPage(IniFile iniFile, int page)
        {
            for (int b = 0; b < 10; b++)
            {
                int buttonColor;
                int.TryParse(iniFile.IniReadValue("Socials", "Page" + (page + 1) + "Button" + (b + 1) + "Color"), out buttonColor);
                
                SocialButton button = new SocialButton
                {
                    Page = page,
                    Name = iniFile.IniReadValue("Socials", "Page" + (page + 1) + "Button" + (b + 1) + "Name"),
                    Color = buttonColor
                };

                for (int l = 0; l < 5; l++)
                {
                    button.Lines[l] = iniFile.IniReadValue("Socials", "Page" + (page + 1) + "Button" + (b + 1) + "Line" + (l + 1));
                }
            }
        }
    }

    /// <summary>
    /// Contains info about a social button.
    /// </summary>
    public class SocialButton
    {
        /// <summary>
        /// Gets or sets the <see cref="SocialPage"/> which the button is a part of.
        /// </summary>
        /// <value>
        /// The page index.
        /// </value>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the name of the social button.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the text color of the social button.
        /// </summary>
        /// <value>
        /// The EverQuest color value.
        /// </value>
        public int Color { get; set; }

        /// <summary>
        /// Contains an array of the text lines of the social button.
        /// </summary>
        public SocialButtonLines Lines = new SocialButtonLines();
    }

    /// <summary>
    /// Contains the text lines of the social button.
    /// </summary>
    public class SocialButtonLines
    {
        private readonly string[] _lines = new string[5];

        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <param name="i">The line index.</param>
        /// <returns></returns>
        public string this[int i]
        {
            get { return _lines[i]; }
            set { _lines[i] = value; }
        }
    }
}
