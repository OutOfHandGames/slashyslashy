using UnityEngine;
using System.Collections;

public class JumpMechanics : MonoBehaviour {
    public float jumpForce = 15;
    public float fastFallScale = 1.5f;
    public float slowFallScale = .7f;
    public float offsetJumpLeft = -.5f;
    public float offsetJumpRight = .5f;

    protected bool fastFall;
    protected bool slowFall;
    bool inAir;
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
        RaycastHit hit;
        Ray2D ray = new Ray2D(transform.position, Vector2.down);
        inAir = !Physics2D.Raycast(ray.origin, ray.direction, .001f, 1) && !Physics2D.Raycast(ray.origin + Vector2.left * offsetJumpLeft, ray.direction, .0001f, 1) &&
        !Physics2D.Raycast(ray.origin + Vector2.left * offsetJumpRight, ray.direction, .0001f, 1);
        
    }

    void FixedUpdate()
    {
        updateFallSpeed();
        //inAir = Mathf.Abs(rigid.velocity.y) > .1f;
        
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
        if (inAir)
        {
            return;
        }
        rigid.AddForce(jumpDirection * jumpForce, ForceMode2D.Impulse);
    }

    void updateFallSpeed()
    {
        if (fastFall)
        {
            rigid.gravityScale = fastFallScale;
            
        }
        else if (slowFall)
        {
            print("I am here");
            rigid.gravityScale = slowFallScale;
        }
        else
        {
            rigid.gravityScale = 1;
        }
    }

    

    public bool getInAir()
    {
        return inAir || rigid.velocity.y > 0.001f;
    }
}
