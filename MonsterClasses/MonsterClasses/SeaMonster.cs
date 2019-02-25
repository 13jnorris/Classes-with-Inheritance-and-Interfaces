using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster : Monster, iBattle
    {
        private bool _hasGills;
        private bool _hasTentecals;
        private string _seaName;
        


        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }


        public bool HasTentecals
        {
            get { return _hasTentecals; }
            set { _hasTentecals = value; }
        }

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        public override bool IsHappy()
        {
            return true;
        }
        public override int FightsWon()
        {
            return 5;
        }
        public override string Background()
        {
            return "For thousands of years I have slept. Your bad coding skills woke me up prepare to fight!";
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();

            int actionProbability = randomNumber.Next(0, 101);
            if (actionProbability <= 30)
            {
                return MonsterAction.Attack;
            }
            else if (actionProbability >= 31)
            {
                return MonsterAction.Defend;
            }
            else
            {
              return MonsterAction.Retreat;
            }

        }
    }
}
