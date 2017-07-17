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
	public Text errorText;
	public GameObject errorPanel;
	public InputField passwordField;
	private string username;
	private string password;
	//public string result;
	public string url = "https://the-whey.herokuapp.com/user/auth";

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

		WWWForm form = new WWWForm ();
		form.AddField ("username", username);
		form.AddField ("password", password);

		StartCoroutine ("Login", form);
	}

	IEnumerator Login (WWWForm form)
	{
		UnityWebRequest www = UnityWebRequest.Post ("https://the-whey.herokuapp.com/user/auth", form);
		yield return www.Send ();
		var N = JSON.Parse (www.downloadHandler.text);
		if (!string.IsNullOrEmpty (www.error)) {
			//This is caught for bad logins. 
			print ("Error : " + www.error);
			Debug.Log ("error");
			errorPanel.gameObject.SetActive (true);
			errorText.text = N ["message"].Value;
			//TODO Place message on screen 
			// probably enable a banner and change text based on the message
			Debug.Log (N ["message"].Value);

		} else {
			Debug.Log ("logedin");
			Debug.Log (www.downloadHandler.text);

			var success = N ["success"].Value;
			if (success == "True") {
			 
				var token = N ["token"].Value;
				var username = N ["username"].Value;

				PlayerPrefs.SetString ("token", token);
				PlayerPrefs.SetString ("username", username);

				if (PlayerPrefs.GetString ("username") != null && PlayerPrefs.GetString ("username") != "") {
					AutoFade.LoadLevel ("_preload", .1f, .1f, Color.black);
				}

			} 

		}
	}
}
