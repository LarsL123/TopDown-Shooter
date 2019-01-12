using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private float cameraHeight = 30, xOffset = 0, zOffset= 0;

	
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(playerTransform.position.x  + xOffset, cameraHeight, playerTransform.position.z + zOffset);
	}
}

