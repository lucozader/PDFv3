using UnityEngine;
using System.Collections;

public class StraightenShip : MonoBehaviour {
	public GameObject bullet1;///template
	bool once = false;
	bool once1 = false;
	bool once2 = false;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame

		void Update () {

			if(once == false){
				transform.Rotate(0, 90, 20);
				once = true;}
		if(transform.position.x > 3500&&once1 == false){
		
			GameObject test  = Instantiate (bullet1,transform.position,Quaternion.identity) as GameObject;///specific one
			once1 = true;
			GUIControllerFireEmblem.planetHealthLeft = GUIControllerFireEmblem.planetHealthLeft-40;//ADD LOGIC HERE TO DEDUCT HEALTH FROM PLAYER/BASE

		}
		if(transform.position.x > 4000&&once2 == false){
			DeadCount.numberDead  += 1;
			once2 = true;}
	}

	

}