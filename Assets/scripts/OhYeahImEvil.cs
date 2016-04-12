using UnityEngine;
using System.Collections;

public class OhYeahImEvil : MonoBehaviour {
	float scoreKeeper; // 30
	float roundKeeper; //if bigger than 6, go to next persona
	float timeKeeper;
	bool isEvilNext;
	public EgoControl k;
	// Use this for initialization
	void Start () 
	{
		scoreKeeper = 0;
		isEvilNext = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timeKeeper = Time.deltaTime;
		while (scoreKeeper < 30) {
			if (roundKeeper >= 6||timeKeeper>180.0f) {
				changeAndReset();
			}
		}
			
	}
	public void eventTriggered (int i)
	{
		scoreKeeper+=i;
		roundKeeper+=i;
	}
	void changeAndReset ()
	{
		roundKeeper = 0;
		timeKeeper = 0;
		changePersona();
	}
	void changePersona ()
	{
		if (isEvilNext) {
			k.badWakeUp ();
		}
		else
		{
			k.mainWakeUp ();
		}
		isEvilNext = !isEvilNext;
	}
	void ending ()
	{
	}
}
