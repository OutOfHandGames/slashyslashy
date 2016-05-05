using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float maxHealth = 1f;
    public bool receivedDamage; //Is true for only the frame that it received the damage.

    float currentHealth;
    bool receivedDamageCheck;
    

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    protected virtual void Update()
    {
        //Allows a boolean to know for one frame if the user was hit.
        if (receivedDamage && !receivedDamageCheck)
        {
            receivedDamageCheck = true;
        }
        else if (receivedDamage && receivedDamageCheck)
        {
            receivedDamage = false;
            receivedDamageCheck = false;
        }
    }

    public void receiveHealth(float healthReceived)
    {
        
    }

    public virtual void takeDamage(float damageTaken, Hitbox hitbox)
    {
        receivedDamage = true;
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
