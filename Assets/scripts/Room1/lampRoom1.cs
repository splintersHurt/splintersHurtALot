using UnityEngine;
using System.Collections;

public class lampRoom1 : MonoBehaviour , Interactable  {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip lamp1Sound;
	// Use this for initialization
	public OhYeahImEvil derp;
	int derpTemp = 1;
	void addPointsToScore()
	{
		if (derpTemp > 0) {
			derp.eventTriggered (derpTemp);
			derpTemp--;
		}
	}
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
		addPointsToScore ();
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

