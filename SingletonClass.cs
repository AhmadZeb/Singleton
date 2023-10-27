using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        private static SingletonClass Instance = null;
        // Lock for single intastance 

        // use with lock key word for create one object

        //private static readonly object Instancelock  = new object();


        //Non-Lazy or Eager Loading
        //private static readonly SingletonClass singleInstance = new SingletonClass();

        //Lazy Loading
        private static readonly Lazy<SingletonClass> SingleInstance = new Lazy<SingletonClass>(() => new SingletonClass());
        public static SingletonClass GetInstance()
        {
            //lock (Instancelock)
            //{
            //    if (instance == null)
            //    {
            //        instance = new SingletonClass();
            //    }
            //}
            return SingleInstance.Value;
        }
        private SingletonClass()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
