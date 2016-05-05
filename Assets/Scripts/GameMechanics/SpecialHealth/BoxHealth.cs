using UnityEngine;
using System.Collections;

public class BoxHealth : Health {

    public override void takeDamage(float damageTaken, Hitbox hitbox)
    {
        foreach(Hitbox hb in GetComponentsInChildren<Hitbox>())
        {
            hb.gameObject.SetActive(false);
        }
        Destroy(this.gameObject);
    }
}
