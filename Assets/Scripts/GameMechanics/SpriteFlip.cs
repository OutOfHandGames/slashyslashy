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
        spriteRenderer.flipX = !isRight;
    }

    protected virtual void updateSpriteDirection()
    {
        if (walkMechanics == null)
        {
            return;
        }
        print(walkMechanics.getHInput());
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
