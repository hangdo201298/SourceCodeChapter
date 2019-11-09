using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class TabItem
    {
        public TabItem(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
        public string Name { private set; get; }
        public int Number { private set; get; }
    }
}
