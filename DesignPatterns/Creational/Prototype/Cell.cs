namespace DesignPatterns.Creational.Prototype
{
    abstract class Cell
    {
        public object Cytoplasm { get; set; }
        public object Membrane { get; set; }
        public object Ribosomes { get; set; }

        // Mitosis
        public abstract Cell Clone();
    }
}
