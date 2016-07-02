using System;

namespace DesignPatterns.Creational.Prototype
{
    class Prototype : IRunnable
    {
        public void Run()
        { 
            Console.WriteLine("--Prototype pattern--\n");

            var eukaryote1 = new Eukaryote
            {
                DNA = 1,
                Nucleus = 2,
                Mitochondria = 3,
                Cytoplasm = 4,
                Membrane = 5,
                Ribosomes = 6 
            };
            var eukaryote2 = (Eukaryote)eukaryote1.Clone();

            Console.WriteLine("Are eukaryote 1 and cloned eukaryote 2 equal: " + AreSame(eukaryote1, eukaryote2));

            var prokaryote1 = new Prokaryote
            {
                DNA = 32,
                Pili = 504,
                Cytoplasm = 48,
                Membrane = 93,
                Ribosomes = 51 
            };
            var prokaryote2 = (Prokaryote)prokaryote1.Clone();

            Console.WriteLine("Are prokaryote 1 and cloned prokaryote 2 equal: " + AreSame(prokaryote1, prokaryote2));

            Console.WriteLine();
        }

        private static bool AreSame(Eukaryote eukaryote1, Eukaryote eukaryote2)
        {
            return 
                eukaryote1.DNA          == eukaryote2.DNA          &&
                eukaryote1.Nucleus      == eukaryote2.Nucleus      &&
                eukaryote1.Mitochondria == eukaryote2.Mitochondria &&
                eukaryote1.Cytoplasm    == eukaryote2.Cytoplasm    &&
                eukaryote1.Membrane     == eukaryote2.Membrane     &&
                eukaryote1.Ribosomes    == eukaryote2.Ribosomes;
        }

        private static bool AreSame(Prokaryote prokaryote1, Prokaryote prokaryote2)
        {
            return 
                prokaryote1.DNA        == prokaryote2.DNA       &&
                prokaryote1.Pili       == prokaryote2.Pili      &&
                prokaryote1.Cytoplasm  == prokaryote2.Cytoplasm &&
                prokaryote1.Membrane   == prokaryote2.Membrane  &&
                prokaryote1.Ribosomes  == prokaryote2.Ribosomes;
        }

    }
}
