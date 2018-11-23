using System;

namespace Domino
{
    public class Domino:IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Domino otherDomino = obj as Domino;
            if (otherDomino != null)
            {
                return this.GetValues()[0].CompareTo(otherDomino.GetValues()[0]);
            }
            else
            {
                throw new ArgumentException("Object is not a Domino");
            }
        }
    }
}

