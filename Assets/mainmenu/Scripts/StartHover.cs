using UnityEngine;
using System.Collections;

public class StartHover : MonoBehaviour {

	public Texture background;
	public Texture texture1;
	public Texture texture2;

	void OnGUI(){

		GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), background);

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texture1);
	}

	void OnMouseOver(){

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texture2);
	}
}
