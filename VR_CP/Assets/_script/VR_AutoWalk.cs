using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_AutoWalk : MonoBehaviour {

	public float speed = 10.0f;			//speed
	public bool moveForward;			//Move or Not
	private CharacterController cc;		//Character Controlled Script
	private GvrEditorEmulator gvrEditor;
	private Transform vrHead;

	void Start () {
		cc = GetComponent<CharacterController> ();
		gvrEditor = transform.GetChild (0).GetComponent<GvrEditorEmulator> ();
		vrHead = Camera.main.transform;
	}

	void Update() {
		if (Input.GetButtonDown ("Fire1")) {
			moveForward = !moveForward;
		}

		if (moveForward) {
			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}