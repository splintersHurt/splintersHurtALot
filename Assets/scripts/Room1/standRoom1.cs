using UnityEngine;
using System.Collections;

public class standRoom1 : MonoBehaviour, Interactable  {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip stand1;
	public AudioClip stand2;
	bool is1Played;

	// Use this for initialization
	void Start () {
		isInteractable = false;
		is1Played = false;
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
		Debug.Log ("I am a night stand");
		playSound ();
	}
	public void showInteractionAvailable()
	{
		InteractableAnnouncer.setInteractText("night stand in room1");
	}
	void playSound()
	{
		if (is1Played) {
			soundGoesHere.playSoundOnQ (stand2);
		} else {
			soundGoesHere.playSoundOnQ (stand1);
			is1Played = true;
		}
	}
}


