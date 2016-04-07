using UnityEngine;
using System.Collections;

public class deskRoom1 : MonoBehaviour , Interactable  {
	bool isInteractable;
	public CanvasInteractText InteractableAnnouncer;
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
		Debug.Log ("I am a desk");
	}
	public void showInteractionAvailable()
	{
		InteractableAnnouncer.setInteractText("desk in room1");
	}
}

