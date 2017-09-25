using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float rotationSpeed = 150f;
	public float moveSpeed = 20f;

	void Start () {
		
	}
	
	void Update () {
		float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
		float vertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Rotate( 0f, horizontal, 0f );
		transform.Translate( 0f, 0f , vertical );
	}
}
