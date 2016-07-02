namespace DesignPatterns.Creational.Prototype
{
    class Eukaryote : Cell
    {
        public object DNA { get; set; }
        public object Nucleus { get; set; }
        public object Mitochondria { get; set; }

        public override Cell Clone()
        {
            return new Eukaryote
            {
                DNA = DNA,
                Nucleus = Nucleus,
                Mitochondria = Mitochondria,
                Cytoplasm = Cytoplasm,
                Membrane = Membrane,
                Ribosomes = Ribosomes
            };
        }

    }
}
