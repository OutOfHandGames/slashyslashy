using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hp;
    public bool active;
    public int damage;

    public virtual void ReceiveDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            DestroySelf();
        }
    }

    public virtual void Attack()
    {

    }

    public virtual void DestroySelf()
    {
        Destroy(gameObject);
    }


}
