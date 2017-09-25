using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MediumGhost : Enemy {

	public float attackDistance = 10f;
	public float moveSpeed = 5f;

	protected override void Start () {
		base.Start();
	}
	
	void Update () {
		FollowPlayer( attackDistance, moveSpeed );
	}

	protected override void FollowPlayer(float attackDistance, float moveSpeed) {
		base.FollowPlayer( attackDistance, moveSpeed );
	}
}
