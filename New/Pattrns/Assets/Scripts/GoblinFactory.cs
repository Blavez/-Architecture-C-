using UnityEngine;

namespace Asteroids
{
    internal sealed class GoblinFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Goblin"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
    }
}
