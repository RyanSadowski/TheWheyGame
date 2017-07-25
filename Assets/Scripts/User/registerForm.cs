using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using SimpleJSON;


public class registerForm : MonoBehaviour {
	public Button button;
	public Text usernameField;
	public InputField passwordField;
	public Text firstNameField;
	public Text lastNameField;
	public Text emailField;
	public Text errorText;
	public GameObject errorPanel;
	private string username;
	private string password;
	private string firstName;
	private string lastName;
	private string email;
	//public string result;
	public string url = "https://the-whey.herokuapp.com/user/setup";

	// Use this for initialization
	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(Submit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Submit() {
		username = usernameField.text.ToString ();
		password = passwordField.text.ToString ();
		firstName = firstNameField.text.ToString ();
		lastName = lastNameField.text.ToString ();
		email = emailField.text.ToString ();
		WWWForm form = new WWWForm();
		form.AddField("username", username);
		form.AddField("password", password);
		form.AddField("firstName", firstName);
		form.AddField("lastName", lastName);
		form.AddField("email", email);
		StartCoroutine("CreateUser", form);
	}

	IEnumerator CreateUser(WWWForm form) {
		UnityWebRequest www = UnityWebRequest.Post ("https://the-whey.herokuapp.com/user/setup", form);
		yield return www.Send ();
		if (!string.IsNullOrEmpty (www.error)) {
			print ("Error : " + www.error);
		} else {
			Debug.Log ("yassss");
			Debug.Log (www.downloadHandler.text);
			var N = JSON.Parse (www.downloadHandler.text);
			var success = N ["success"].Value;
			Debug.Log (success);
			if (success == "True") {
				AutoFade.LoadLevel ("_preload", .1f, .1f, Color.black);
			}
		}

	}
}
