using UnityEngine;
using System.Collections;

public interface Interactable
{
	void IsRayCastHitting(bool k);
	void interactionTriggered ();
	void showInteractionAvailable();
}

