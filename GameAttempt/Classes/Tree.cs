//Entire tree declaration from GitProject
// https://github.com/VeronicaCucamonga/DeweyDecimalClassification
// https://www.youtube.com/watch?v=EbEm5kohPfE&t=97s&ab_channel=MooICT
// https://github.com/Acearino5/Dewey_Decimal_System_Trainer/tree/main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAttempt.Classes
{
    public class Tree
    {
        //tree variables
        public string callNum;
        public string category;

        //tree
        public List<Tree> treeList = new List<Tree>();

    }
}
