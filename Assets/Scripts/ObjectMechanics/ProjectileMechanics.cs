using UnityEngine;
using System.Collections;

public class ProjectileMechanics : MonoBehaviour {
    public Vector2 initialVector = Vector2.left * 5;

    Rigidbody2D rigid;
    SpriteFlip spriteFlip;

    protected virtual void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteFlip = GetComponent<SpriteFlip>();
        launchProjectile(initialVector);

    }

    protected virtual void Update()
    {
        
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(rigid.velocity.y, rigid.velocity.x) * Mathf.Rad2Deg);
    }

    public virtual void launchProjectile(Vector2 forceApplied)
    {
        rigid.AddForce(forceApplied, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Destroy(this.GetComponent<Rigidbody2D>());
        
        scaleBugFix(collider.collider.transform);
        foreach(Collider2D c in GetComponents<Collider2D>())
        {
            c.enabled = false;
        }
        this.enabled = false;
        rigid.isKinematic = true;
    }

    void scaleBugFix(Transform parent)
    {
        if (parent.localScale.x > 0)
        {
            transform.parent = parent;
            return;
        }
        Quaternion oldRotation = transform.rotation;
        transform.parent = parent;
        transform.localScale = parent.lossyScale;
        transform.rotation = Quaternion.Inverse(oldRotation);

        //transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + (parent.eulerAngles.z - transform.eulerAngles.z));

    }

}
