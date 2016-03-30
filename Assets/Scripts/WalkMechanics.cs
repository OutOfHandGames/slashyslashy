using UnityEngine;
using System.Collections;

public class WalkMechanics : MonoBehaviour {
    public float speed = 8;
    public float acceleration = 10;

    float hInput;
    float vInput;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }


    public void horizontalInput(float hInput)
    {
        this.hInput = hInput;
    }

    public void verticalInput(float vInput)
    {
        this.vInput = vInput;
    }

    void Update()
    {

    }

    void updateMovement()
    {
        float goalSpeed = speed * hInput;
        Vector2 goalVel = Vector2.right * goalSpeed + Vector2.up * rigid.velocity.y;
        rigid.velocity = Vector2.MoveTowards(rigid.velocity, goalVel, Time.deltaTime * acceleration);

    }
}
