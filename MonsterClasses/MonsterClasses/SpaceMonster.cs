using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, iBattle
    {
        public override bool IsHappy()
        {
            /*if (_hasSpaceShip)
            {
                return true;
            }
            else
            {
                return false;
            }*/

            return _hasSpaceShip ? true : false;
        }

        private bool _hasSpaceShip;
        private string _homeGalaxy;

        public string HomeGalaxy
        {
            get { return _homeGalaxy; }
            set { _homeGalaxy = value; }
        }


        public bool HasSpaceShip
        {
            get { return _hasSpaceShip; }
            set { _hasSpaceShip = value; }
        }
        public override string Greeting()
        {

            return $"Hello, I am a Space Monster and my name is {Name}";
        }
        public override string Background()
        {
            return "I come from the Andromeda Galaxy my people are searching for a new home in this galaxy and we are willing to fight for a place to call our own.";
        }
        public override int FightsWon()
        {
            return 10;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();

            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 66)
            {
                return MonsterAction.Attack;
            }
            else if (actionProbability <= 33)
            {
                return MonsterAction.Retreat;
            }
            else
            {
                return MonsterAction.Defend;
            }

        }
    }
}

