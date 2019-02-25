using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum MonsterAction { Attack, Defend, Retreat }

        private int _id;
        private string _name;
        private int _age;
        private bool _isActive;
        private string _size;
        private int _weight;        
        private string _fightingStyle;
        private bool _isHVT;

        public bool isHVT
        {
            get { return _isHVT; }
            set { _isHVT = value; }
        }



        public string FightingStyle
        {
            get { return _fightingStyle; }
            set { _fightingStyle = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }


        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public Monster()
        { 

        }
        public Monster(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public virtual string Greeting()
        {
            return $"Hello, my name is {_name}.";
        }
        public abstract bool IsHappy();

        public abstract int FightsWon();

        public virtual string Background()

        {
            return $"";
        }

    }
}
