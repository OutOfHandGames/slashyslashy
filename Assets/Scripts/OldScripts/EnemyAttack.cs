using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public bool active;
	public int damage;

	public virtual void DestroySelf()
	{
		Destroy(gameObject);
	}
}
