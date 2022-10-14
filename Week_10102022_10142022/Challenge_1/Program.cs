using System;

namespace Challenge_1
{
    class NODES
    {
        // FIELD
        public int? NODE_Data;
        public NODES NODE_NextNode;

        // METHOD
        public NODES ()
        {
            this.NODE_NextNode = null;
        }
    }

    class LinkedLists
    {
        public NODES LinkedList_CheckIntersection(NODES INPUT_Head1, NODES INPUT_Head2)
        {
            NODES INDEX_Head1 = new NODES();
            NODES INDEX_Head2 = new NODES();

            INDEX_Head1 = INPUT_Head1;
            INDEX_Head2 = INPUT_Head2;
            while (INDEX_Head1 != null)
            {
                while (INDEX_Head2 != null)
                {
                    if (INDEX_Head1 == INDEX_Head2)
                    {
                        return INDEX_Head1;
                    }

                    INDEX_Head2 = INDEX_Head2.NODE_NextNode;
                }

                INDEX_Head1 = INDEX_Head1.NODE_NextNode;
            }

            NODES OUTPUT_Blank = new NODES ();
            return OUTPUT_Blank;
        }
    }
   
}