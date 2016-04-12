using UnityEngine;
using System.Collections;

public class lastMedalRoom1 : MonoBehaviour {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip medal1;
	public OhYeahImEvil derp;
	int derpTemp = 3;
	void addPointsToScore()
	{
		derp.eventTriggered (derpTemp);
		derpTemp--;
	}
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
		Debug.Log ("I am a medal");
		playSound ();
		addPointsToScore ();
	}
	public void showInteractionAvailable()
	{
		InteractableAnnouncer.setInteractText("medal in room1");
	}
	void playSound()
	{
		soundGoesHere.playSoundOnQ (medal1);
	}
}
