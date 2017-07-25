using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;

public class Home : MonoBehaviour {

	GameObject go;
	Service service;
	public Text welcomeText;
	public Slider xpValue;
	public Button logoutBtn;
	public Dropdown liftDropdown;
	public List<string> options;
	private int numLifts;

	// Use this for initialization
	void Start () {
		go = GameObject.Find("_Service");
		service = (Service) go.GetComponent(typeof(Service));
		welcomeText.text = "Welcome " + PlayerPrefs.GetString("username") + "!";
		xpValue.value = PlayerPrefs.GetInt ("xp");		
		logoutBtn.onClick.AddListener (Logout);
		service.GetLiftList ();
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

	public void PopulateLifts(JSONNode data){
		numLifts = data ["body"].Count;
		for (int i = 0; i < numLifts; i++) {
			options.Add (data ["body"] [i] ["name"]);
		}
		liftDropdown.AddOptions(options);
			
	}
}
