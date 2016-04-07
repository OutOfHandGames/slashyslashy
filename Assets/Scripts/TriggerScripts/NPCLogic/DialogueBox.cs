using UnityEngine;
using System.Collections;

public class DialogueBox : MonoBehaviour {
    public string[] textList;
    Animator anim;

    SpriteRenderer spriteRender;
    TextMesh mesh;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRender = GetComponentInChildren<SpriteRenderer>();
        mesh = GetComponentInChildren<TextMesh>();
    }

    void Update()
    {
        Vector4 col = new Vector4(mesh.color.r, mesh.color.g, mesh.color.b, spriteRender.color.a);
        mesh.color = col;
    }

    void OnTriggerEnter2D (Collider2D collider)
    {

        if (collider.tag == "Player")
        {
            anim.SetTrigger("Enter");
        }
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            anim.SetTrigger("Exit");
        }
    }
}
