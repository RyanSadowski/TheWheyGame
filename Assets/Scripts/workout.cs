using System.Collections;
// using System.Serializable;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

[System.Serializable]
public class Workout {

	public int user_id;
	public int type_id;
	public string name;
	public string description;
	public List<Lift> lifts;



	// public Workout createWorkout(user_id, type_id, name, description, lifts){
	// 	Workout workout = new Workout();
	// 	workout.user_id = user_id;
	// 	workout.type_id = type_id;
	// 	workout.name = name;
	// 	workout.description = description;
	// 	workout.lifts = lifts;
	// 	return workout;

	// }

}
