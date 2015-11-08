using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.IndexersScenario
{
    public class Indexers
    {
        public int[] Xs { get; set; }
        public int[] Ys { get; set; }
        public int[] Zs { get; set; }

        public Dictionary<char, int> this[int i]
        {
            get
            {
                return new Dictionary<char, int> {
                    { 'X', Xs[i] },
                    { 'Y', Ys[i] },
                    { 'Z', Zs[i] }
                };
            }
            set
            {
                Xs[i] = value['X'];
                Ys[i] = value['Y'];
                Zs[i] = value['Z'];
            }
        }

        public Indexers()
        {
            Xs = new int[] { 3, 4, 5, 12, 17, 14, 15, 21 };
            Ys = new int[] { 1, 18, 22, 13, 19, 2, 9, 3 };
            Zs = new int[] { 5, 11, 23, 4, 8, 16, 10, 7 };
        }
    }
}
