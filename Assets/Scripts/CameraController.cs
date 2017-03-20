using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float cameraHeight = 10.0f;
	public float cameraAway = 5.0f;

	void Update() {
		Vector3 pos = player.transform.position;
		pos.y += cameraHeight;
		pos.x -= cameraAway;
		transform.position = pos;
	}
}
