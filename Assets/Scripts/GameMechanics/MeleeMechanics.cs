using UnityEngine;
using System.Collections;

public class MeleeMechanics : MonoBehaviour {
    public float coolDownTime = 1f;

    Animator anim;
    float coolDownTimer = 0;

    protected virtual void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    protected virtual void Update()
    {
        coolDownTimer = Mathf.MoveTowards(coolDownTimer, 0, Time.deltaTime);
    }

    public void attack()
    {
        if (coolDownTimer <= 0)
        {
            anim.SetTrigger("Attack");
        }
    }
}
