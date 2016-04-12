using UnityEngine;
using System.Collections;

public class calenderRoom1 : MonoBehaviour, Interactable {
	bool isInteractable;
	public CanvasInteractText interactableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip calender1;
	public AudioClip calender2;
	public AudioClip calender3;
	bool is1Played;
	bool is2Played;
	public OhYeahImEvil derp;
	void addPointsToScore()
	{
		derp.eventTriggered (1);
	}
	// Use this for initialization
	void Start () {
		isInteractable = false;
		is1Played = false;
		is2Played = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if (isInteractable) 
		{	
			showInteractionAvailable ();
			isInteractable = false;
		}
	}
	public void IsRayCastHitting(bool k)
	{
		isInteractable = true;
	}
	public void interactionTriggered ()
	{
		Debug.Log ("I am a calender");
		playSound ();
		addPointsToScore ();
	}
	public void showInteractionAvailable()
	{
		interactableAnnouncer.setInteractText("calender in room1");
	}
	void playSound()
	{
		if (is2Played) 
		{
			soundGoesHere.playSoundOnQ (calender3);
		}
		else if (is1Played) {
			soundGoesHere.playSoundOnQ (calender2);
			is2Played = true;
		} 
		else {
			soundGoesHere.playSoundOnQ (calender1);
			is1Played = true;
		}
	}
}
