using System.Windows.Forms;

namespace EQSM
{
    class Character
    {
        public string File { get; set; }
        public string Name { get; set; }
        public CharacterFriends Friends = new CharacterFriends();
        public CharacterIgnored Ignored = new CharacterIgnored();
        public CharacterAbilities Abilities = new CharacterAbilities();
        public CharacterCombatSkills CombatSkills = new CharacterCombatSkills();
        public CharacterCombatAbilities CombatAbilities = new CharacterCombatAbilities();
        public SocialPage[] Socials = new SocialPage[10];
        public string InspectText { get; set; }

        public Character(string file)
        {
            File = file;
        }
    }

    class CharacterFriends
    {
        private string[] _friends = new string[100];

        public string this[int i]
        {
            get { return _friends[i]; }
            set { _friends[i] = value; }
        }
    }

    class CharacterIgnored
    {
        private string[] _ignored = new string[100];

        public string this[int i]
        {
            get { return _ignored[i]; }
            set { _ignored[i] = value; }
        }
    }

    class CharacterAbilities
    {
        private int[] _abilities = new int[6];

        public int this[int i]
        {
            get { return _abilities[i]; }
            set { _abilities[i] = value; }
        }
    }

    class CharacterCombatSkills
    {
        private int[] _combatSkills = new int[4];

        public int this[int i]
        {
            get { return _combatSkills[i]; }
            set { _combatSkills[i] = value; }
        }
    }

    class CharacterCombatAbilities
    {
        private int[] _combatAbilities = new int[6];

        public int this[int i]
        {
            get { return _combatAbilities[i]; }
            set { _combatAbilities[i] = value; }
        }
    }

    class SocialPage
    {
        private SocialButton[] _buttons = new SocialButton[10];

        public SocialButton this[int i]
        {
            get { return _buttons[i]; }
            set { _buttons[i] = value; }
        }
    }

    class SocialButton
    {
        public int Page { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public SocialButtonLines Lines = new SocialButtonLines();
    }

    class SocialButtonLines
    {
        private string[] _lines = new string[5];

        public string this[int i]
        {
            get { return _lines[i]; }
            set { _lines[i] = value; }
        }
    }
}
