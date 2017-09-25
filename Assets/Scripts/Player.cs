using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	[Header("UI")]
	public GameObject pickupText;
	public GameObject graveActivateText;

	private List<GameObject> orbList; 
	private GameObject tempOrb;
	private GameObject tempGrave;
	private bool canPickup = false;
	private bool canActivateGrave = false;

	void Awake() {
		orbList = new List<GameObject>();
	}
	
	void Update () {
		TogglePickupText();
		ToggleGraveText();

		if( Input.GetKeyDown(KeyCode.E) && tempOrb ) {
			PickUpOrb( tempOrb );
		}	

		if( Input.GetKeyDown( KeyCode.F ) && tempGrave ) {
			ActivateGrave( tempGrave );
		}
		
		FloatingOrb();
	}

	void PickUpOrb( GameObject pickup ) {
		if( pickup.tag == "Orb" && !orbList.Contains( pickup ) ) {
			orbList.Add( pickup );
			CantPickup();
		}
	}

	void ActivateGrave( GameObject grave ) {
		Grave temp = grave.GetComponent<Grave>();
		if( orbList.Count >= temp.OrbsNeeded ) {
			orbList.RemoveRange( orbList.Count - temp.OrbsNeeded, temp.OrbsNeeded );
			grave.SendMessage("ToggleMaterial", true );
		} else {
			Debug.Log("Not enough energy to activate grave");
		}
	}

	void FloatingOrb() {
		if( orbList.Count > 0 ) {
			foreach( GameObject orb in orbList ) {
				Vector3 offset = new Vector3( 0f, 1f, -1f );
				orb.transform.parent = transform;
				orb.transform.position = transform.position + offset;
				orb.transform.RotateAround( transform.position, Vector3.up, 100f * Time.deltaTime );
			}	
		}	
	}

	void CanPickup( GameObject orb ) {
		canPickup = true;
		tempOrb = orb;
		Debug.Log("Now you can pick me up.");
	}

	void CantPickup() {
		canPickup = false;
		tempOrb = null;
		Debug.Log("Now you can't pick me up.");
	}

	void ToggleGraveActive( GameObject grave ) {
		canActivateGrave = !canActivateGrave;

		if( canActivateGrave ) {
			tempGrave = grave;
		} else {
			tempGrave = null;
		}
	}

	void TogglePickupText() {
		if( canPickup )
			pickupText.SetActive( true );
		else 
			pickupText.SetActive( false );
	}

	void ToggleGraveText() {
		if( canActivateGrave )
			graveActivateText.SetActive( true );
		else 
			graveActivateText.SetActive( false );
	}
}
