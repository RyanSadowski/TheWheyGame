using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using LitJson;

public class Home : MonoBehaviour {

	GameObject go;
	Service service;
	public Text welcomeText;
	public Slider xpValue;
	public Button logoutBtn;
	public Dropdown liftDropdown;
	public List<string> options;
	public InputField workoutName;
	public InputField workoutDesc;
	public InputField liftSets;
	public InputField liftReps;
	public InputField liftWeight;
	private int numLifts;
	public Text LevelDesc;
	public Text LevelInt;
	public static JSONNode workout;
	public static JSONNode lift;
	public static List<Lift> lifts;

	// Use this for initialization
	void Start () {
		lifts = new List<Lift> ();
		workout = JSON.Parse("{}");
		go = GameObject.Find("_Service");
		service = (Service) go.GetComponent(typeof(Service));
		welcomeText.text = "Welcome " + PlayerPrefs.GetString("username") + "!";
		xpValue.value = 000;		
		logoutBtn.onClick.AddListener (Logout);
		service.GetHomeData ();
	}

	public void GiveXP(){
		service.GiveXP (20);
	}

	public void GainsGoblin(){
		service.GainsGoblin (-15);
	}
		
	void Update () {
		xpValue.value = service.getXP ();
	}

	void Logout(){
		service.Logout ();
	}

	public void PopulateLifts(JSONNode data){
		numLifts = data.Count;
		for (int i = 0; i < numLifts; i++) {
			options.Add (data [i] ["name"]);
		}
		liftDropdown.AddOptions(options);

	}

	public void PopulateHome(JSONNode data){
		PopulateLifts (data["lifts"]);
		PopulateUserStats (data["userData"][0]);
		PopulateLevel (data["level"][0]);
	}

	public void PopulateUserStats(JSONNode data){
		PlayerPrefs.SetInt("xp", data ["exp"].AsInt);
		Debug.Log(PlayerPrefs.GetInt("xp"));
		PlayerPrefs.SetInt("level", data ["level"].AsInt);
		LevelInt.text = "level " + data ["level"].Value;
	}

	public void PopulateLevel(JSONNode data){
			
		LevelDesc.text = data["name"].Value;
		xpValue.maxValue = data["xp"].AsInt;
	}

//	public void fuckUnity(){
//
//		var lift = new Lift();
//		lift.lift_id = 1;
//		lift.sets = 100;
//		lift.reps = 10;
//		lift.weight = 100;
//
//		var lift2 = new Lift();
//		lift2.lift_id = 1;
//		lift2.sets = 100;
//		lift2.reps = 10;
//		lift2.weight = 100;
//		lifts.Add (lift);
//		lifts.Add (lift2);
//
//		Debug.Log (lifts[1].weight);
//
//		var workout = new Workout();
//		workout.user_id = 1;
//		workout.type_id = 5;
//		workout.name = "I h8 u";
//		workout.description = "ggf";
//		workout.lifts = lifts;
//
//		string test = JsonMapper.ToJson (workout);
//		Debug.Log (test);
//
//
//
//	}
		

	public void addLift(){

		int liftId = liftDropdown.GetComponent<Dropdown> ().value;

		var lift = new Lift();
		lift.lift_id = liftId;
		lift.sets = int.Parse(liftSets.text);
		lift.reps = int.Parse(liftReps.text);
		lift.weight = int.Parse(liftWeight.text);
		
		lifts.Add (lift);
		liftSets.text = "";
		liftReps.text = "";
		liftWeight.text = "";


	}
	
	public void saveWorkout(){
		addLift ();
		
		var workout = new Workout();
		workout.user_id = int.Parse(PlayerPrefs.GetString("userId"));
		workout.type_id = 5;
		workout.name = workoutName.text.ToString ();
		workout.description = workoutDesc.text.ToString ();
		workout.lifts = lifts;
		string payload = JsonMapper.ToJson (workout);

		StartCoroutine(PostWorkout(payload));



	}

	public void clearWorkout(){
		liftSets.text = "";
		liftReps.text = "";
		liftWeight.text = "";
		workoutName.text = "";
		workoutDesc.text = "";

	}


	IEnumerator PostWorkout(string data) {
		byte[] datAss = System.Text.Encoding.UTF8.GetBytes(data);
		UnityWebRequest www = UnityWebRequest.Put ("https://the-whey.herokuapp.com/lifts/workout", datAss);
		www.SetRequestHeader("Content-Type", "application/json");
		www.SetRequestHeader("x-access-token", PlayerPrefs.GetString ("token"));
		yield return www.Send();

		if(!string.IsNullOrEmpty (www.error)) {
			Debug.Log(www.error);
			
		}
		else {
			Debug.Log (www.downloadHandler.text);
			clearWorkout ();
		}

	}
}
