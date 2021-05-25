using UnityEngine;
namespace Asteroids 
{ 
public class Damage : MonoBehaviour
    {
        private float _hp;
        private Rigidbody2D _bullet;
        private Transform _barrel;
        private float _force;
        public Damage(float hp, Rigidbody2D bullet, Transform barrel, float force)
        {
            _hp = hp;
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void FireOn() 
        {  
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
        }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            _hp--;
        }
    }

}
}
