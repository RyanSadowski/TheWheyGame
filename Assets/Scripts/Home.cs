using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour {


	public Text welcomeText;
	public Slider xpValue;
	public Button doWorkoutBtn;
	public Button createWorkoutBtn;
	public Button settingsBtn;
	public Button journalBtn;
	public Button aboutBtn;
	public Button questsBtn;
	public Button logoutBtn;
	public Button closeSettings;
	public GameObject settingsPanel;

	// Use this for initialization
	void Start () {
		welcomeText.text = "Welcome " + PlayerPrefs.GetString("username") + "!";
		xpValue.value = 34;//PlayerPrefs.GetInt ("xp");		

		doWorkoutBtn.onClick.AddListener(DoWorkout);
		createWorkoutBtn.onClick.AddListener(CreateWorkout);
		settingsBtn.onClick.AddListener(SettingsClicked);
		journalBtn.onClick.AddListener(JournalClicked);
		aboutBtn.onClick.AddListener (AboutClicked);
		questsBtn.onClick.AddListener (QuestsClicked);
		logoutBtn.onClick.AddListener (Logout);
		closeSettings.onClick.AddListener (CloseSettings);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void DoWorkout(){
		Debug.Log ("Do Workout");
		
	}
	void CreateWorkout(){
		Debug.Log ("CreateWorkout");

	}
	void SettingsClicked(){
		Debug.Log ("SettingsClicked");
		settingsPanel.gameObject.SetActive (true);

	}
	void CloseSettings(){
		settingsPanel.gameObject.SetActive (false);
	}
	void JournalClicked(){
		Debug.Log ("JournalClicked");

	}
	void AboutClicked(){
		Debug.Log ("AboutClicked");

	}
	void QuestsClicked(){
		Debug.Log ("QuestsClicked");

	}
	void Logout(){
		GameObject go = GameObject.Find("_Service");
		Service service = (Service) go.GetComponent(typeof(Service));
		service.Logout ();
	}

}
