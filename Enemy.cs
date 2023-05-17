using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed;
	public transform target;
	public int playerDamage = 2;

	void Update()
	{
		transform.position = Vector3.MoveTowards(Transform.position, target.position, speed * Time.deltaTime);
		transform.LookAt(target.position);
	}

	private void OnTriggerEnter(Collider other)
	{
		Player player = other.GetComponent<Player>();
		player.TakeDamage(PlayerDamage)
	}
}
