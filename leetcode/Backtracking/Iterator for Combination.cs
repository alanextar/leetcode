using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Bitmask
{
    public class CombinationIterator
    {
        private List<string> _comb = new List<string>();
        private int _cur = 0;

        public CombinationIterator(string characters, int combinationLength)
        {
            _comb = GenaretAllComb(characters, combinationLength);
            _comb.Sort();
        }

        public string Next()
        {
            var next = _cur >= _comb.Count ? "" : _comb[_cur];
            _cur++;

            return next;
        }

        public bool HasNext()
        {
            return _cur < _comb.Count;
        }

        List<string> GenaretAllComb(string s, int len)
        {
            int mask = 1 << s.Length;
            List<string> hold = new List<string>();
            string comString = "";
            for (int no = 1; no < mask; no++)
            {
                int num = no;

                int i = 0;
                 
                while (num != 0)
                {
                    var bit = num & 1;
                    if (bit == 1) comString = comString + s[i];
                    i++;
                    num >>= 1;
                }

                if (comString.Length == len) hold.Add(comString);
                comString = "";
            }
            return hold;
        }
    }
}
