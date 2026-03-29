using System;

namespace TP_MODUL5_103022400006
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> data = new DataGeneric<string>("103022400006");
            data.PrintData();
        }
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}