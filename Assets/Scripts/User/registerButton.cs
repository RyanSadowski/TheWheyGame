using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class registerButton : MonoBehaviour {
	public Button button;

	// Use this for initialization
	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(goRegister);
	}
	void goRegister(){
		//Application.LoadLevel("Register"); deprecated
		SceneManager.LoadScene ("Register");
	}
}
