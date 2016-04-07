using UnityEngine;
using System.Collections;

public class chairRoom1 : MonoBehaviour, Interactable {
	bool isInteractable;
	public CanvasInteractText interactableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip chair1;
	public AudioClip chair2;
	public AudioClip chair3;
	bool is1Played;
	bool is2Played;
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
		Debug.Log ("I am a chair");
		playSound ();
	}
	public void showInteractionAvailable()
	{
		interactableAnnouncer.setInteractText("chair in room1");
	}
	void playSound()
	{
		if (is2Played) 
		{
			soundGoesHere.playSoundOnQ (chair3);
		}
		else if (is1Played) {
			soundGoesHere.playSoundOnQ (chair2);
			is2Played = true;
		} 
		else {
			soundGoesHere.playSoundOnQ (chair1);
			is1Played = true;
		}
	}
}
