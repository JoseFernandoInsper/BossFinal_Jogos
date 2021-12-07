using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour
{
    public int attackDamage = 40;
		public AudioClip dano;

    public Vector3 attackOffset;
    public float attackRange = 1f;
    public LayerMask attackMask;
	public void AttackPlayer()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		if (colInfo != null)
		{
			colInfo.GetComponent<BossHealth>().TakeDamage(attackDamage);
			AudioSource.PlayClipAtPoint(dano, this.gameObject.transform.position, 1f);
			GetComponent<Animator>().SetBool("isOnTop", false);
		}
	}

	void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
	}
}
