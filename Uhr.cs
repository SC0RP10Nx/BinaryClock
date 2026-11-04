using System.Timers;
using Timer = System.Timers.Timer;

namespace BinaerUhr
{
    internal delegate void ZeitAenderungHandler(object sender, ZeitEventArgs e);


    internal class Uhr
    {
        public Uhr()
        {
            _timer = new Timer(1000);
            _timer.AutoReset = true;
            _timer.Elapsed += TimerElapsed;
        }

        private readonly Timer _timer;

        public void Start()
        {
            OnZeitGeaendert(DateTime.Now);
            _timer.Start();
        }

        public void Stop()
        {

            _timer.Stop();
        }
        public event ZeitAenderungHandler? ZeitGeaendert;
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            OnZeitGeaendert(DateTime.Now);
        }

        protected virtual void OnZeitGeaendert(DateTime zeit)
        {
            ZeitGeaendert?.Invoke(this, new ZeitEventArgs(zeit));
        }
    }
}
