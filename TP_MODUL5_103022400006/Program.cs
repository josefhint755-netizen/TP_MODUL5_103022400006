using System;

namespace TP_MODUL5_103022400006
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();

            // Ganti dengan nama praktikan
            halo.SapaUser("Josefhint");

            // Ganti dengan NIM kamu
            DataGeneric<string> data = new DataGeneric<string>("231234567");
            data.PrintData();
        }
    }

    class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
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