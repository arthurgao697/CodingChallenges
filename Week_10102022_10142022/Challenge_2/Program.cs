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
        public NODES LinkedList_FindLoop(NODES INPUT_Head)
        {
            NODES INDEX_HeadMain = new NODES();
            INDEX_HeadMain = INPUT_Head;

            while (INDEX_HeadMain != null)
            {
                NODES INDEX_HeadLoop = new NODES();
                INDEX_HeadLoop = INPUT_Head;
                while (INDEX_HeadLoop != null)
                {
                    if (INDEX_HeadMain == INDEX_HeadLoop)
                    {
                        return INDEX_HeadMain;
                    }

                    INDEX_HeadLoop = INDEX_HeadLoop.NODE_NextNode;
                }

                INDEX_HeadMain = INDEX_HeadMain.NODE_NextNode;
            }

            NODES OUTPUT_Blank = new NODES ();
            return OUTPUT_Blank;
        }
    }
   
}