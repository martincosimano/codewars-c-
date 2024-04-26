using System.Collections;

namespace InheritancePractice
{
    partial class Program
    {
        class Stack
        {
            public ArrayList stack = new ArrayList();

            public void Push(object obj)
            {
                if (obj == null)
                    throw new InvalidOperationException();
                else
                    stack.Add(obj);
            }

            public object Pop()
            {
                if (stack.Count == 0)
                    throw new InvalidOperationException();
                else
                {
                    int lastElementIndex = stack.Count - 1;
                    var lastElement = stack[lastElementIndex];
                    stack.RemoveAt(lastElementIndex);

                    return lastElement != null ? lastElement : throw new InvalidOperationException();
                }
            }

            public void Clear()
            {
                stack.Clear();
            }
        }
    }
}