namespace DesignPatterns.Structural.Bridge
{
    // Refined abstraction
    class GermanText : IText
    {
        private readonly IFont _font;
        private readonly string _message;

        public GermanText(string message, IFont font)
        {
            _font = font;
            _message = message;
        }

        public void Output()
        {
            _font.Write(_message);
        }
    }
}
