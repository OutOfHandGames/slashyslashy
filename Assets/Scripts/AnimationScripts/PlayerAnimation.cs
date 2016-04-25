using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
    public SpriteRenderer shieldSprite;
    Animator anim;
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;
    ShieldMechanics shieldMechanics;

    const int TORSO = 0;
    const int LEGS = 1;
    const int SHIELD = 2;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = transform.parent.GetComponent<WalkMechanics>();
        jumpMechanics = transform.parent.GetComponentInChildren<JumpMechanics>();
        shieldMechanics = transform.parent.GetComponent<ShieldMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(walkMechanics.getHInput()));
        anim.SetBool("inAir", jumpMechanics.getInAir());
        anim.SetBool("isShielding", shieldMechanics.getIsShielding());
        if (anim.GetCurrentAnimatorStateInfo(TORSO).IsName("Torso_Attack"))
        {
            anim.ResetTrigger("Attack");
        }
        if (anim.GetCurrentAnimatorStateInfo(SHIELD).IsName("Shield_Up"))
        {
            shieldSprite.sortingOrder = 3;
        }
        else
        {
            shieldSprite.sortingOrder = 0;
        }
        
	}
}
