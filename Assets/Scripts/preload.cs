using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preload : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine(Setup());
		
	}

	IEnumerator Setup(){
		yield return new WaitForSeconds(5);
		Debug.Log("token is " + PlayerPrefs.GetString("token"));
		Debug.Log("username is " + PlayerPrefs.GetString("username"));
		if (PlayerPrefs.GetString ("token") == "") {
			Debug.Log (" Loading Menu");
			AutoFade.LoadLevel ("Menu", .1f, .1f, Color.black);
		} else {
			Debug.Log (" Loading Home");
			AutoFade.LoadLevel("Home", .1f, .1f, Color.black);
		}



	}
}
