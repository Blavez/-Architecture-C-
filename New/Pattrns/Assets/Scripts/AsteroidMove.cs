using UnityEngine;
namespace Asteroids
{
    public sealed class AsteroidMove : Enemy
    {
        public Vector2 direction;
        private float speed = 0.05f;

        private void FixedUpdate()
        {
            transform.Translate(direction.normalized * speed);
        }
    }
}
