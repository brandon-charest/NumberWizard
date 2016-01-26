using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name){
		Debug.Log("Level load requested for: "+name);
		Application.LoadLevel(name);
	}
	
	public void quitRequest(){
	Debug.Log("Quiting game.");
	Application.Quit();
	}
	
}
