using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float smoothSpeed = 10f;

	public Vector3 offset;

	/*void Update () {
		Vector3 desiredPos = target.position + offset;
		Vector3 smoothedPos = Vector3.Lerp (transform.position, desiredPos, smoothSpeed * Time.deltaTime);
		if (desiredPos.x >= 100f) {
			desiredPos.x = 100f;
		}
		if (desiredPos.x <= -100f) {
			desiredPos.x = -100f;
		}
		if (desiredPos.y >= 100f) {
			desiredPos.y = 100f;
		}
		if (desiredPos.y <= -100f) {
			desiredPos.y = -100f;
		}
		transform.position = desiredPos;
		Debug.Log ("target pos: " + target.position);
		Debug.Log ("camera pos: " + transform.position);
	}*/
}
