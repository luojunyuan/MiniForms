namespace Windows.Win32
{

    /// <summary>
    ///  Simple internal wrapper that enables showing the message identifier string in the debugger.
    /// </summary>
    internal readonly struct MessageId
    {
        private readonly uint _id;

        private MessageId(uint id) => _id = id;

        public static explicit operator int(MessageId id) => (int)id._id;
        public static explicit operator MessageId(int id) => new((uint)id);
        public static implicit operator uint(MessageId id) => id._id;
        public static implicit operator MessageId(uint id) => new(id);
    }
}
