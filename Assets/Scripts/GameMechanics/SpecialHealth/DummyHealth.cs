using UnityEngine;
using System.Collections;

public class DummyHealth : Health {
    Animator anim;

    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    public override void takeDamage(float damageTaken, Hitbox hitbox)
    {
        print("I here and I'm queer");
        anim.ResetTrigger("Hit");
        anim.SetTrigger("Hit");
    }
}
