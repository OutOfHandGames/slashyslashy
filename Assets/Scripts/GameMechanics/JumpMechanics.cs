using UnityEngine;
using System.Collections;

public class JumpMechanics : MonoBehaviour {
    public float jumpForce = 15;

    protected bool fastFall;
    protected bool slowFall;
    CustomGravity grav;
    Vector2 jumpDirection = Vector2.up;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = transform.parent.GetComponent<Rigidbody2D>();
        grav = transform.parent.GetComponent<CustomGravity>();
    }

    protected virtual void Update()
    {
        
    }

    void FixedUpdate()
    {
        updateFallSpeed();
    }

    public void setFastFall(bool fastFallOn)
    {
        this.fastFall = fastFallOn;
    }

    public void setSlowFall(bool slowFallOn)
    {
        this.slowFall = slowFallOn;
    }

    public void jump()
    {
        RaycastHit2D hit;
        if (!Physics2D.Raycast(transform.position, Vector2.down, .01f, 1))
        {
            return;
        }
        rigid.AddForce(jumpDirection * jumpForce, ForceMode2D.Impulse);
    }

    void updateFallSpeed()
    {
        if (fastFall)
        {
            grav.gravityScale = 1.5f;
            
        }
        else if (slowFall)
        {
            grav.gravityScale = .7f;
        }
        else
        {
            grav.gravityScale = 1;
        }
    }
}
