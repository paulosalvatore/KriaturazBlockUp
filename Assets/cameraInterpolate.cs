using UnityEngine;

public class cameraInterpolate : MonoBehaviour {

	public Transform[] views;
	public float transitionSpeed; 
	Transform currentView;

	// Use this for initialization
	void Start () {


	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			currentView = views [0];
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			currentView = views [1];
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			currentView = views [2];
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			currentView = views [3];
		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			currentView = views [4];
		}

	}


	void LateUpdate () {

		//Lerp position
		transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

		Vector3 currentAngle = new Vector3 (
			Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
			Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
			Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

		transform.eulerAngles = currentAngle;

	}
}