using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graph
    {
        private Dictionary<int, List<int>> adjcList;

        public Graph()
        {
            adjcList = new Dictionary<int, List<int>>(); 
        }
    }
}
