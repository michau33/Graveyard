using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour {

	public int OrbsNeeded = 2;

	public Material graveDeactivated;
	public Material graveActivated;

	void ToggleMaterial( bool isActivated ) {
		if( isActivated ) 
			SetMaterial( graveActivated );
		else 
			SetMaterial( graveDeactivated );
	}

	void OnTriggerEnter(Collider col)
	{
		if( col.tag == "Player" ) {
			Player player = col.GetComponentInParent<Player>();
			player.SendMessage("ToggleGraveActive", this.gameObject );
		}
	}

	void OnTriggerExit(Collider col)
	{
		if( col.tag == "Player" ) {
			Player player = col.GetComponentInParent<Player>();
			player.SendMessage("ToggleGraveActive", this.gameObject );
		}
	}

	void SetMaterial( Material _material) {
		foreach( MeshRenderer renderer in GetComponentsInChildren<MeshRenderer>() ) {
			renderer.material = _material;
		}
	}


}
