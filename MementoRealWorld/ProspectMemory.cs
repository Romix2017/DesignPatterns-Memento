using System;
using System.Collections.Generic;
using System.Text;

namespace MementoRealWorld
{
    public class ProspectMemory
    {
        private Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
