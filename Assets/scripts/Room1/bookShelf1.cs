using UnityEngine;
using System.Collections;

public class bookShelf1 : MonoBehaviour , Interactable  {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
	public SoundOnQ soundGoesHere;
	public AudioClip shelf1;
	public OhYeahImEvil derp;
	int derpTemp = 2;
	void addPointsToScore()
	{
		if (derpTemp > 0) {
			derp.eventTriggered (derpTemp);
			derpTemp--;
		}
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
		Debug.Log ("I am a bookshelf");
		playSound ();

	}
	public void showInteractionAvailable()
	{
		InteractableAnnouncer.setInteractText("bookshelf in room1");
	}
	void playSound()
	{
		soundGoesHere.playSoundOnQ (shelf1);
	}
}

