using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {

	public void QuitButtonNotify()
	{
		Debug.Log("Quit Button Clicked");
		Application.Quit();
	}
}
