using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagerTS1 : MonoBehaviour {

	public static int MinCount;
	public static int SecCount;
	public static float MilliCount;
	public static string MilliDis;
	public bool touch = false;

	public GameObject player;
	public GameObject minute;
	public GameObject seconds;
	public GameObject millisec;

	void Update () {
		if (player.transform.position.x <= 213 && player.transform.position.x >= 202 && player.transform.position.z >= 180 && player.transform.position.z <= 290) {
			touch = true;
		}
		if (touch == false) {
			MilliCount += Time.deltaTime * 10;
			MilliDis = MilliCount.ToString ("F0");
			millisec.GetComponent<Text> ().text = "" + MilliDis;

			if (MilliCount >= 10) {
				SecCount += 1;
				MilliCount = 0;
			}

			if (SecCount <= 9) {
				seconds.GetComponent<Text> ().text = "0" + SecCount + ".";
			} else {
				seconds.GetComponent<Text> ().text = "" + SecCount + ".";
			}
			if (SecCount >= 60) {
				SecCount = 0;
				MinCount += 1;
			}

			if (MinCount <= 9) {
				minute.GetComponent<Text> ().text = "0" + MinCount + ":";
			} else {
				minute.GetComponent<Text> ().text = "" + MinCount + ":";
			}
		}
	}
}
