using UnityEngine;
using System.Collections;

public class PlayerJumpMechanics : JumpMechanics {

    protected override void Update()
    {
        fastFall = Input.GetAxisRaw("Vertical") < -.01f;
        slowFall = Input.GetButton("Jump");
        Debug.DrawLine(transform.position, transform.position + Vector3.down * .01f, Color.red);
        if (Input.GetButtonDown("Jump"))
        {
            jump();
        }
    }
}
