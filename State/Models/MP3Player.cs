using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Models
{
    /// <summary>
    /// State abstract class kimi təyin olunur
    /// </summary>
    abstract class MusicPlayerState
    {
        public abstract void PlayMusic();
        public abstract void StopMusic();
    }

    /// <summary>
    /// Play ve Stop üçün context qurulur
    /// </summary>
    class MusicPlayer
    {
        MusicPlayerState state;
        MusicPlayerState play;
        MusicPlayerState stop;
        public MusicPlayer()
        {
            play = new Play(this);
            stop = new Stop(this);
            state = play;
        }

        public void SetPlay()
            => state = play;
        public void SetStop()
            => state = stop;

        public void Play()
            => state.PlayMusic();
        public void Stop()
            => state.StopMusic();
    }
    /// <summary>
    /// Play üçün Concrete State qurulur
    /// </summary>
    class Play : MusicPlayerState
    {
        MusicPlayer _context;
        public Play(MusicPlayer context)
            => _context = context;

        public override void PlayMusic()
            => Console.WriteLine("Zaten müzik çalmaktadır!");
        public override void StopMusic()
        {
            Console.WriteLine("Müzik durdurulmuştur.");
            _context.SetStop();
        }
    }
    /// <summary>
    /// Stop üçün Concrete State qurulur
    /// </summary>
    class Stop : MusicPlayerState
    {
        MusicPlayer _context;
        public Stop(MusicPlayer context)
            => _context = context;

        public override void PlayMusic()
        {
            Console.WriteLine("Müzik başlatılmıştır.");
            _context.SetPlay();
        }
        public override void StopMusic()
            => Console.WriteLine("Zaten müzik durmaktadır!");
    }
}
