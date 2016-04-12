using UnityEngine;
using System.Collections;

public class SpriteFlip : MonoBehaviour {
    public bool isRight = true;
    public bool flipLock = false;

    WalkMechanics walkMechanics;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        walkMechanics = GetComponent<WalkMechanics>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        setSpriteDirection();
    }

    protected virtual void Update()
    {
        updateSpriteDirection();
        setSpriteDirection();
    }

    void setSpriteDirection()
    {
        if (flipLock)
        {
            return;
        }
        if (isRight)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    protected virtual void updateSpriteDirection()
    {
        if (walkMechanics == null)
        {
            return;
        }
        if (walkMechanics.getHInput() < -.01f)
        {
            isRight = false;
        }
        else if (walkMechanics.getHInput() > .01f)
        {
            isRight = true;
        }
        
    }

    public bool getSpriteIsRight()
    {
        return isRight;
    }


}
