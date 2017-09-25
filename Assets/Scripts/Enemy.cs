using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

	Player player;

	protected virtual void Start () {
		player = GameObject.FindObjectOfType<Player>();
	}
	
	protected virtual void FollowPlayer( float attackDistance, float moveSpeed ) {
		if( player ) {
			transform.LookAt( player.transform );

			if( Vector3.Distance( transform.position, player.transform.position ) <= attackDistance ) {
				Attack();
			} 

			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
	}

	protected virtual void Attack() {
		Debug.Log("I'm attacking");
	}

	protected virtual void GetDamage() {
		Debug.Log("I'm getting damage");
	}

	protected virtual void Die() {
		Debug.Log("I'm dying");
	}
}
