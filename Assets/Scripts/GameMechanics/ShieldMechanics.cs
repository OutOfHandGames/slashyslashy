using UnityEngine;
using System.Collections;

public class ShieldMechanics : MonoBehaviour {
    bool isShielding;

    public void setShield(bool isShielding)
    {
        if (!checkCanShield())
        {
            this.isShielding = false;
            return;
        }
        this.isShielding = isShielding;
    }

    public bool checkCanShield()
    {
        return true;
    }
}
