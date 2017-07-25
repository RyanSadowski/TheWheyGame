using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using UnityEngine.Networking;

public class Service : MonoBehaviour {

	public static Service instance = null;
	GameObject go;
	Home home;
	int playerXP;
	public JSONObject liftList;

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

	public void GetLiftList(){
		go = GameObject.Find("Canvas");
		home = (Home) go.GetComponent(typeof(Home));
		StartCoroutine ("GetLifts");
	}

	private string GetToken(){
		return PlayerPrefs.GetString ("token");
	}
		
	IEnumerator GetLifts ()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("token", GetToken());
		UnityWebRequest www = UnityWebRequest.Post ("https://the-whey.herokuapp.com/lifts/all", form);
		yield return www.Send ();
		var N = JSON.Parse (www.downloadHandler.text);
		if (!string.IsNullOrEmpty (www.error)) {
			print ("Error : " + www.error);
			Debug.Log ("error");
			Debug.Log (N ["message"].Value);
		} else {
			var success = N ["success"].Value;
			if (success == "True") {
				home.PopulateLifts (N);
			} 
		}
	}
}
