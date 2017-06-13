using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Service : MonoBehaviour {

	public static Service instance = null;

	int playerXP;


	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

	}
	public void Logout(){
		Debug.Log ("logging out");
		PlayerPrefs.DeleteAll ();
		AutoFade.LoadLevel("_preload", .1f, .1f, Color.black);
	}

	public void GiveXP(int xp){
		playerXP = PlayerPrefs.GetInt ("xp");
		PlayerPrefs.SetInt ("xp", playerXP + xp);
	}
	public int getXP(){
		return PlayerPrefs.GetInt ("xp");
	}
	public void GainsGoblin(int xp){
		this.GiveXP (xp);
	}
}
