using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginButton : MonoBehaviour {

	public Button button;

	// Use this for initialization
	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(goLogin);
	}
	void goLogin(){
		//Application.LoadLevel("Register"); deprecated
		SceneManager.LoadScene ("Login");
	}
}
