using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    
    class EventClass
    {
        public event EventHandler Event;
        protected virtual void OnEvent()
        {
            Event.Invoke(this, EventArgs.Empty);
        }
        public void ToDo()
        {
            Console.WriteLine("Что-то сделал.");
            OnEvent();
        }
    }

    class Program
    {
        static void Main()
        {
            EventClass eventClass = new EventClass();
            eventClass.Event += SomeFunc;
            eventClass.ToDo();
            eventClass.Event += SomeFunc;
        }

        static void SomeFunc(object obj, EventArgs eventArgs)
        {
            Console.WriteLine("Я что-то делаю в ответ.");
        }
        
    }
}
