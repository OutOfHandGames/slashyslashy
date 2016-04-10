using UnityEngine;
using System.Collections;

public class PlayerWalkMechanics : WalkMechanics {

    protected override void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");
        base.Update();
    }
}
