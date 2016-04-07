using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    Transform playerSprite;
    SpriteFlip spriteDirection;

    void Start()
    {
        playerSprite = GameObject.FindGameObjectWithTag("Player").transform;
        spriteDirection = GetComponent<SpriteFlip>();
    }

    void Update()
    {
        float xDirection = playerSprite.position.x - transform.position.x;
        if (xDirection > 0)
        {
            spriteDirection.isRight = true;
        }
        else
        {
            spriteDirection.isRight = false;
        }
    }
}
