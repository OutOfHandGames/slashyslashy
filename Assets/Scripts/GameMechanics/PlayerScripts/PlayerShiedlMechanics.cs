using UnityEngine;
using System.Collections;

public class PlayerShiedlMechanics : ShieldMechanics {


    protected override void Update()
    {
        setShield(Input.GetButton("Fire3"));
    }
}
