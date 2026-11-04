
namespace BinaerUhr
{
    internal class ZeitEventArgs : EventArgs
    {
        public DateTime Zeit { get; }

        public ZeitEventArgs(DateTime zeit)
        {
            Zeit = zeit;
        }

    }
}
