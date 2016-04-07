using UnityEngine;
using System.Collections;

public class bedRoom1 : MonoBehaviour, Interactable {
	bool isInteractable;
	public CanvasInteractText interactableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip bed1;
	public AudioClip bed2;
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
		Debug.Log ("I am a bed");
		playSound ();
	}
	public void showInteractionAvailable()
	{
		interactableAnnouncer.setInteractText("Bed in room1");
	}
	void playSound()
	{
		if (is1Played) {
			soundGoesHere.playSoundOnQ (bed2);
		} else {
			soundGoesHere.playSoundOnQ (bed1);
			is1Played = true;
		}
	}
}
