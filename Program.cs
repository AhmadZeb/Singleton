namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingletonClass singletonClass = SingletonClass.GetInstance();
            //singletonClass.PrintDetails("From Teacher");

            //SingletonClass std = SingletonClass.GetInstance();
            //std.PrintDetails("From Student");
            //Console.WriteLine("Hello, World!");

            //  Parallel.Invoke 
            Parallel.Invoke(
                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                () => PrintTeacherDetails(),
                //Let us Assume PrintStudentDetails method is Invoked by Thread-2
                () => PrintStudentDetails()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            SingletonClass fromTeacher = SingletonClass.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            SingletonClass fromStudent = SingletonClass.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
 }
