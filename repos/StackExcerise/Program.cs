using System;
namespace StackExercise
{

    public class stackdemo
    {

        Stack<object> st = new Stack<object> ();
        public void push(object obj)
        {
            st.Push (obj);
        }
        public object Popped()
        {   
           return st.Pop ();
        }
        
    }
    class program
    {
        static void Main(string[] args)
        {
            stackdemo st1 = new stackdemo ();
            st1.push(1);
            st1.push(2);
            st1.push(3);

            Console.WriteLine(st1.Popped());
            Console.WriteLine(st1.Popped());
            Console.WriteLine(st1.Popped());
        }
    }
}