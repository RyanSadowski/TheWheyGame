using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Service : MonoBehaviour {

	public static Service instance = null;



	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);


	}
	void Start(){
		
	}

	public void Logout(){
		PlayerPrefs.DeleteAll ();
		AutoFade.LoadLevel("_preload", .1f, .1f, Color.black);
	}
}
