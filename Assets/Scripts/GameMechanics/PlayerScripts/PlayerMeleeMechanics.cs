using UnityEngine;
using System.Collections;

public class PlayerMeleeMechanics : MeleeMechanics {

    protected override void Update()
    {

        base.Update();
        if (Input.GetButtonDown("Fire1"))
        {
            attack();
        }
    }
}
