using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTurn : MonoBehaviour {

	public GameObject cam;

	// Update is called once per frame
	void Update () {
		Quaternion charRot = cam.transform.rotation;
		charRot.x = 0;
		charRot.y = cam.transform.rotation.y;
		charRot.z = 0;
		this.transform.rotation = charRot * Quaternion.Euler(0,90,0);
	}
}
