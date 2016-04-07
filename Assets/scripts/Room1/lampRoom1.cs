using UnityEngine;
using System.Collections;

public class lampRoom1 : MonoBehaviour , Interactable  {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip lamp1Sound;
	// Use this for initialization
	void Start () {
		isInteractable = false;
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
		Debug.Log ("I am a booklamp");
		playSound ();
	}
	public void showInteractionAvailable()
	{
		InteractableAnnouncer.setInteractText("booklamp in room1");
	}
	void playSound()
	{
		soundGoesHere.playSoundOnQ (lamp1Sound);
	}
}

