// See https://aka.ms/new-console-template for more information
using TPMOD6_103022300056;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Daffa Khairi Putra F");
        video.IncreasePlayCount(10);
        video.PrintVideoDetail();
    }
}