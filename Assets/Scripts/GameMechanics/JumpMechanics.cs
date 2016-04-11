using UnityEngine;
using System.Collections;

public class JumpMechanics : MonoBehaviour {
    public float jumpForce = 15;

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
        inAir = !Physics2D.Raycast(ray.origin, ray.direction, .001f, 1);
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

    public bool getInAir()
    {
        return inAir;
    }
}
