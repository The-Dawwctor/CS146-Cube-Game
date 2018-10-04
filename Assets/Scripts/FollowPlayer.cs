﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset = new Vector3(0, 1, -5);

	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
