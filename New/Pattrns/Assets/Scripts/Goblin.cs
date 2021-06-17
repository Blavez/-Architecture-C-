namespace Asteroids
{
    public sealed class Goblin : Enemy
    {
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
    }
}
