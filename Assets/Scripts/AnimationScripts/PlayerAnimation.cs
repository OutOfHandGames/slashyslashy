using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = transform.parent.GetComponent<WalkMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(walkMechanics.getHInput()));
	}
}
