using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
	public Slider slider;

	public int health = 500;

	public GameObject deathEffect;

	public bool isInvulnerable = false;


	public void TakeDamage(int damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;
		slider.value = health;

		if (health <= 200)
		{
			GetComponent<Animator>().SetBool("IsEnraged", true);
		}

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
