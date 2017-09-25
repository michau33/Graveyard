using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGhost : Enemy {

	public float attackDistance = 5f;
	public float moveSpeed = 10f;

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
