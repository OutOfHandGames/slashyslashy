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
        Destroy(this.gameObject);
        Quaternion oldRotation = transform.rotation;
        transform.rotation = collider.collider.transform.rotation;
        transform.parent = collider.collider.transform;
        transform.localRotation = oldRotation;
        foreach(Collider2D c in GetComponents<Collider2D>())
        {
            c.enabled = false;
        }
        scaleBugFix(Vector3.one);
        this.enabled = false;
        rigid.isKinematic = true;
    }

    void scaleBugFix(Vector3 originalScale)
    {
       // transform.localScale = new Vector3 (originalScale.x * transform.parent.localScale.x, originalScale.y * transform.parent.localScale.y, originalScale.z * transform.parent.localScale.z);
    }
    
}
