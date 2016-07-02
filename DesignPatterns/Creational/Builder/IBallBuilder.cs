namespace DesignPatterns.Creational.Builder
{
    interface IBallBuilder
    {
        Ball GetResult();

        IBallBuilder SetRadius(int radius);

        IBallBuilder SetWeight(int weight);
    }
}
