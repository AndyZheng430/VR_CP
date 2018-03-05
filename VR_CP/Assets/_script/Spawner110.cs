using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner110 : MonoBehaviour {

	public GameObject[] obs;
	//z=485, x=35, z=335, x=135
	public int Xbeg = 30;
	public int Xend = 140; 
	public int Zbeg = 330;
	public int Zend = 490;
	public int size = 100;
	
	void Start(){
		StartCoroutine (spawning ());
	}
	IEnumerator spawning(){
		while (size >= 0) {
			Instantiate (obs [(int)(Random.Range (0, obs.Length))], new Vector3 ((int)(Random.Range (Xbeg, Xend)), 110, (int)(Random.Range (Zbeg, Zend))), Quaternion.identity);
			size = size - 1;
		}
		yield return new WaitForSeconds (1);
	}
}
