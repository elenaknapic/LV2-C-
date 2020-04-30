using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2
{
    //Z1, Z2, Z3
    /*
    class DiceRoller
    {

        private List<Die> dice;
        private List<int> resultForEachRoll;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void PrintResult(IList<int> results)
        {
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }

    */

        //Z4
        class DiceRoller
        {
            private List<Die> dice;
            private List<int> resultForEachRoll;
            private ILogger logger;
            public DiceRoller()
            {
                this.dice = new List<Die>();
                this.resultForEachRoll = new List<int>();
            }
            public void InsertDie(Die die)
            {
                dice.Add(die);
            }
            public void RollAllDice()
            {
                
                this.resultForEachRoll.Clear();
                foreach (Die die in dice)
                {
                    this.resultForEachRoll.Add(die.Roll());
                }
            }
            
            public IList<int> GetRollingResults()
            {
                return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
               this.resultForEachRoll
               );
            }
            public int DiceCount
            {
                get { return dice.Count; }
            }
            public void PrintResult(IList<int> results)
            {
                foreach (int result in results)
                {
                    Console.WriteLine(result);
                }
            }
            public void SetLogger(ILogger logger)
            {
                this.logger = logger;
            }
        public void LogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }

    }




}
    
