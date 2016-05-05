using UnityEngine;
using System.Collections;

public class ArrowTrigger : MonoBehaviour {
    ProjectileMechanics arrow;

    void Start()
    {
        arrow = transform.parent.GetComponent<ProjectileMechanics>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            arrow.launchProjectile(arrow.initialVector);
            this.gameObject.SetActive(false);
        }
    }
}
