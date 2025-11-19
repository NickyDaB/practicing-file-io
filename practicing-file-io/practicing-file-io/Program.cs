namespace practicing_file_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FileStream stream = File.Create("my_badass_file.txt");

            stream.Close();

            File.AppendAllText("my_badass_file.txt", "I am the programmer, and I say let there be text in this badass file!");
        }
    }
}
