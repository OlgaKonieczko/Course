using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Kurs_Inheretance
{
    public class Stack
    {
        private ArrayList _stackList = new ArrayList();
        private object _help;


        public void Push(object obj)
        {
            if (obj != null)
            {
                _stackList.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("object null, give argument");
            }
        }

        public object Pop()
        {
            if (_stackList.Count > 0)
            {
                _help = _stackList[_stackList.Count - 1];
                _stackList.RemoveAt(_stackList.Count - 1);
                return _help;
            }

            else
            {
                throw new InvalidOperationException("Empty List");
            }

        }

        void Clear()
        {
            foreach (int i in _stackList)

            {
                _stackList.RemoveAt(i);
            }

        }
    }
}
