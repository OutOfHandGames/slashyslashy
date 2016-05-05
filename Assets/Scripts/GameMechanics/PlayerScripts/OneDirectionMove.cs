using UnityEngine;
using System.Collections;

public class OneDirectionMove : WalkMechanics {
    public Vector2 inputDirection = new Vector2(1, 0);

    Health health;
    JumpMechanics jumpMechanics;
    bool wasHit;

    protected override void Start()
    {
        base.Start();
        health = GetComponent<Health>();
        jumpMechanics = GetComponentInChildren<JumpMechanics>();
    }

    public void setInputDirection(Vector2 inputDirection)
    {
        this.inputDirection = inputDirection;
    }

    protected override void Update()
    {
        if (health.receivedDamage)
        {
            moveOn = false;
        }

        if (!moveOn && !jumpMechanics.getInAir())
        {
            moveOn = true;
        }

        hInput = inputDirection.x;
        vInput = inputDirection.y;
        base.Update();

    }
}
