using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Collider2D))]
[RequireComponent (typeof(Rigidbody2D))]

public class Hitbox : MonoBehaviour {
    public Vector2 knockBackDirection = Vector2.zero;
    public float knockBackForce = 100;
    public float damage = 0;
    public bool isHurtBox = false;
    
    string id;

    Transform parentObject;
    SpriteFlip spriteFlip;


    void Start()
    {
        id = this.tag;

        parentObject = transform.parent;
        while(parentObject.parent != null)
        {
            parentObject = parentObject.parent;
        }
        spriteFlip = parentObject.GetComponent<SpriteFlip>();

    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.tag == id)
        {
            return;
        }
        Hitbox aHitbox = collider.GetComponent<Hitbox>();
        if (aHitbox != null)
        {
            if (aHitbox.isHurtBox)
            {
                hurtboxEntered(aHitbox);
            }
            else
            {
                hitboxEntered(aHitbox);
            }
        }
    }

    protected virtual void hitboxEntered(Hitbox hBox)
    {
        if (isHurtBox)
        {
            return;
        }
    }

    protected virtual void hurtboxEntered(Hitbox hBox)
    {
        if (isHurtBox)
        {
            return;
        }

        Health enemyHealth = hBox.getParentObject().GetComponent<Health>();
        Rigidbody2D eRigid = hBox.getParentObject().GetComponent<Rigidbody2D>();
        if (enemyHealth != null)
        {
            enemyHealth.takeDamage(damage, this);
        }

        if (eRigid != null)
        {
            eRigid.AddForce(knockBackDirection * knockBackForce, ForceMode2D.Impulse);
        }


    }

    protected virtual void hitboxExited(Hitbox hBox)
    {
        if (isHurtBox)
        {
            return;
        }
    }

    protected virtual void hurtboxExited(Hitbox hBox)
    {
        if (isHurtBox)
        {
            return;
        }
        
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        if (collider.tag == id)
        {
            return;
        }
        Hitbox aHitbox = collider.GetComponent<Hitbox>();
        if (aHitbox != null)
        {
            if (aHitbox.isHurtBox)
            {
                hurtboxExited(aHitbox);
            }
            else
            {
                hitboxExited(aHitbox);
            }
        }
    }

    public Transform getParentObject()
    {
        return parentObject;
    }
}
