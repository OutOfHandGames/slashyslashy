using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float maxHealth = 1f;

    float currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public void receiveHealth(float healthReceived)
    {
        
    }

    public virtual void takeDamage(float damageTaken, Hitbox hitbox)
    {

        currentHealth -= damageTaken;
        checkIsDead();
    }

    protected virtual void checkIsDead()
    {
        if (currentHealth <= 0)
        {
            Invoke("destroyGameObject", 2);
            gameObject.layer = LayerMask.NameToLayer("Dead");
        }
    }

    void destroyGameObject()
    {
        Destroy(this.gameObject);
    }
}
