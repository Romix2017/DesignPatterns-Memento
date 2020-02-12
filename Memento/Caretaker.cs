using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Caretaker
    {
        private Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
