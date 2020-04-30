using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2
{
    //Z1
    class Die
    {
        /*
        private int numberOfSides;
        private Random randomGenerator;
        private int rolledNumber;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
        */

        //Z2
        /*
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
    */

    //Z3
       private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides, RandomGenerator randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
        
    }
}

