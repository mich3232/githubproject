using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_4_Task_3
{
    class Node
    {


        public string data;

        public Node left;
        public Node right;

        public Node(string data)
        {
            this.data = data;

            left = null;
            right = null;


        }
    }
}
