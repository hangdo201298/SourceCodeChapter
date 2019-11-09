using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{

    public class NavigationDrawerMenuItem
    {
        public NavigationDrawerMenuItem()
        {
            TargetType = typeof(NavigationDrawerDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}