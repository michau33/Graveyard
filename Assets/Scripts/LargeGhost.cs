using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LargeGhost : Enemy {

	public float attackDistance = 20f;
	public float moveSpeed = 2f;

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
