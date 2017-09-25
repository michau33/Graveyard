using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {

	public bool pickAble = false;

	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Entered trigger");
		if( col.tag == "Player" ) {
			Player player = col.GetComponentInParent<Player>();
			player.SendMessage("CanPickup", this.gameObject );
		}
	}

	void OnTriggerExit(Collider col)
	{
		if( col.tag == "Player" ) {
			Player player = col.GetComponentInParent<Player>();
			player.SendMessage( "CantPickup" );
		}
	}
}
