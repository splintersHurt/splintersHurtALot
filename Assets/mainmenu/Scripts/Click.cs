using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public void button_click (string level){
		Application.LoadLevel(level);
	}
}
