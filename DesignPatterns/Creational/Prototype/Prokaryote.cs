namespace DesignPatterns.Creational.Prototype
{
    class Prokaryote : Cell
    {
        public object DNA { get; set; }
        public object Pili { get; set; }

        public override Cell Clone()
        {
            return new Prokaryote
            {
                DNA = DNA,
                Pili = Pili,
                Cytoplasm = Cytoplasm,
                Membrane = Membrane,
                Ribosomes = Ribosomes
            };
        }
    }
}
