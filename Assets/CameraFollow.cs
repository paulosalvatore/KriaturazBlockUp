using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject player;
	public float cameraY = 5f;
	public float cameraZ = -5f;
	public float cameraX = 0f;

	void Update() {
		Vector3 pos = player.transform.position;
		pos.y += cameraY;
		pos.z += cameraZ;
		pos.x += cameraX;
		transform.position = pos;

		if (Input.GetButtonDown("Camera1")){
	//	if (Input.GetKeyDown ("v")) {
			cameraY = 15;
			cameraZ = -15;
			cameraX = 0;
		}

		if (Input.GetButtonDown("Camera2")){
	//	if (Input.GetKeyDown ("b")) {
			cameraY = 5;
			cameraZ = -5;
			cameraX = 0;
		}


	}
}