using UnityEngine;
using System.Collections;

public class OneDirectionMove : WalkMechanics {
    public Vector2 inputDirection = new Vector2(1, 0);

    public void setInputDirection(Vector2 inputDirection)
    {
        this.inputDirection = inputDirection;
    }

    protected override void Update()
    {
        hInput = inputDirection.x;
        vInput = inputDirection.y;
        base.Update();

    }
}
