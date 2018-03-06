using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimScript : MonoBehaviour {

	public Vector3 aimDownSight;
	public Vector3 hipFire;

	public bool MouseAim;
	public bool LShift;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			transform.localPosition = aimDownSight;
			MouseAim = true;
		}
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			LShift = true;
		}

		if (MouseAim == true && LShift == true) {
			Camera.main.fieldOfView = 40;
		}

		if (Input.GetMouseButtonUp(1)) {
			Camera.main.fieldOfView = 60;
			transform.localPosition = hipFire;
			MouseAim = false;
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			LShift = false;
			Camera.main.fieldOfView = 60;
		}
	}
}
