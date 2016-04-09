using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Collider2D))]
[RequireComponent (typeof(Rigidbody2D))]

public class Hitbox : MonoBehaviour {
    public Vector2 knockBackDirection = Vector2.zero;
    public float knockBackForce = 100;
    public bool isHurtBox = false;


    void OnTriggerEnter2D (Collider2D collider)
    {
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
}
