using State.Models;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.Play();
            musicPlayer.Stop();
            Console.WriteLine("*******");
            musicPlayer.Stop();
            musicPlayer.Play();
            Console.WriteLine("*******");
            musicPlayer.Stop();
            Console.WriteLine("*******");
            musicPlayer.Play();
            musicPlayer.Stop();
        }
    }
}
