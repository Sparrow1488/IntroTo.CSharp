using System;

namespace Repeat
{
    class Program
    {
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }
        static void Main(string[] args)
        {
            lock (syncObject)
            {
                Write();
            }
        }
    }

    interface IWritable{
        void Write();
    }

    class A : IWritable {
        public virtual void Foo(){
            Console.WriteLine("Class A");
        }

        public virtual void Write()
        {
            throw new NotImplementedException();
        }
    }

    class B : A{
        public override void Write()
        {
            base.Write();
        }
        public override void Foo(){
            Console.WriteLine("Class B");
        }
    }
}
