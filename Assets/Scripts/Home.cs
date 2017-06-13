using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour {

	GameObject go;
	Service service;
	public Text welcomeText;
	public Slider xpValue;
	public Button logoutBtn;

	// Use this for initialization
	void Start () {
		go = GameObject.Find("_Service");
		service = (Service) go.GetComponent(typeof(Service));
		welcomeText.text = "Welcome " + PlayerPrefs.GetString("username") + "!";
		xpValue.value = PlayerPrefs.GetInt ("xp");		
		logoutBtn.onClick.AddListener (Logout);
	}
	public void GiveXP(){
		service.GiveXP (20);
	}
	public void GainsGoblin(){
		service.GainsGoblin (-15);
	}
	// Update is called once per frame
	void Update () {
		xpValue.value = service.getXP ();
	}
	void Logout(){
		service.Logout ();
	}

}
