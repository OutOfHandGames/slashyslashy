using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = transform.parent.GetComponent<WalkMechanics>();
        jumpMechanics = transform.parent.GetComponentInChildren<JumpMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(walkMechanics.getHInput()));
        anim.SetBool("inAir", jumpMechanics.getInAir());
	}
}
