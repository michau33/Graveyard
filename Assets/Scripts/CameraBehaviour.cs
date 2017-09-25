using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

	[Header("Camera settings")]
	public Transform target;
	public float smoothSpeed = .125f;
	public Vector3 offset;
	
	void LateUpdate() {
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp( transform.position, desiredPosition, smoothSpeed );
		transform.position = smoothedPosition;

		transform.LookAt( target );
	}
}
