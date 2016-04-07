using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasInteractText : MonoBehaviour {
 	Text interactText;
	string tempText;
	public bool isThereInteractText;
	// Use this for initialization
	void Start () 
	{
		interactText = GetComponent<Text> ();
		interactText.text = "derp";
		isThereInteractText = false;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		if (isThereInteractText) {
			interactText.text = tempText;
		} else {
			interactText.text = null;
		}
		isThereInteractText = false;
	}
	public void setInteractText(string k)
	{
		tempText = k;
		isThereInteractText = true;
	}
}
