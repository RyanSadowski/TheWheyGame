using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using SimpleJSON;

public class loginScript : MonoBehaviour
{

	public Button button;
	public Text usernameField;
	public InputField passwordField;
	private string username;
	private string password;
	//public string result;
	public string url = "http://localhost:3000/user/auth";

	// Use this for initialization
	void Start ()
	{
		Button btn = button.GetComponent<Button> ();
		btn.onClick.AddListener (Submit);
	}

	void Submit ()
	{

		username = usernameField.text.ToString ();
		password = passwordField.text.ToString ();
		Debug.Log (passwordField.text.ToString ());

		WWWForm form = new WWWForm ();
		form.AddField ("username", username);
		form.AddField ("password", password);

		StartCoroutine ("Login", form);
	}

	IEnumerator Login (WWWForm form)
	{
		UnityWebRequest www = UnityWebRequest.Post ("https://the-whey.herokuapp.com/user/auth", form);
		yield return www.Send ();
		if (!string.IsNullOrEmpty (www.error)) {
			print ("Error : " + www.error);
		} else {
			Debug.Log ("logedin");
			Debug.Log (www.downloadHandler.text);

			var N = JSON.Parse (www.downloadHandler.text);
			var success = N ["success"].Value;
			if (success == "True") {
			 
				var token = N ["token"].Value;
				var username = N ["username"].Value;

				PlayerPrefs.SetString ("token", token);
				PlayerPrefs.SetString ("username", username);

				if (PlayerPrefs.GetString ("username") != null && PlayerPrefs.GetString ("username") != "") {
					AutoFade.LoadLevel ("_preload", .1f, .1f, Color.black);
				}

			} else {
				Debug.Log (N ["message"].Value);
			
			}

		}
	}
}
