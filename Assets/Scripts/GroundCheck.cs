﻿using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

    public PlayerController playerCtrl;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Obstacle")
        {
           playerCtrl.GetComponent<PlayerController>().grounded = true;
        }
    }
}
