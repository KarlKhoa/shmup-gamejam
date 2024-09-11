using UnityEngine;

namespace Shmup
{
    public abstract class Ship : MonoBehaviour
    {
        [SerializeField] int maxHealth;
        private int health;

        protected virtual void Awake() => health = maxHealth;

        public void SetMaxHealth(int amount) => maxHealth = amount;

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                Die();
            }
        }

        public void AddHealth(int amount)
        {
            health += amount;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public float GetHealthNormalized() => health / (float)maxHealth;

        protected abstract void Die();
    }
}

