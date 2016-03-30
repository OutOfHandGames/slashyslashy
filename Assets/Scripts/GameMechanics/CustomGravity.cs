using UnityEngine;
using System.Collections;

public class CustomGravity : MonoBehaviour {
    public float gravityScale = 9.8f;
    public float maxFallSpeed = 5;
    
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        updateVelocity();
    }

    void updateVelocity()
    {
        rigid.velocity = Vector2.MoveTowards(rigid.velocity, Vector2.down * maxFallSpeed, Time.fixedDeltaTime * gravityScale);
    }
}
