using System;
using System.Collections;
using System.Collections.Generic;
using System.Data; 
namespace Fibonacci {
    public class StackQueue<T>:
        IEnumerable<T> {
            private List<T> innerList = new List<T> ();
            private int _top = 0;

            public void Enque (T item) {
                Console.WriteLine ("Queing " + item.ToString ());
                innerList.Insert (innerList.Count, item);
                _top++;
            }
            public void Push (T item) {
                Console.WriteLine ("Pushing " + item.ToString ());
                innerList.Insert (0, item);
                _top++;

            }

            public T Pop () {
                var element = innerList[0];
                Console.WriteLine ("Popping " + element.ToString ());
                innerList.RemoveAt (0);
                _top--;
                return element;

            }
              IEnumerator IEnumerable.GetEnumerator () {
                return GetEnumerator ();

            }

            public IEnumerator<T> GetEnumerator () {
                for (int i = 0; i < _top; i++) {
                    yield return innerList[i];
                }
            }
        }

    public class StackQueueManager {
        private   StackQueue<int> _stack = null;
       public StackQueueManager () {
            _stack = new StackQueue<int> ();
        }

        public   void LogStack () {
            _stack.Enque (1);
            _stack.Push (2);
            _stack.Push (3);
            _stack.Enque (4);

            foreach (var item in _stack ){
                Console.WriteLine (item);
            }
        }
    }
}