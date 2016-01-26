using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;	
	//public int maxGuessAllowed=10;
	
	public Text text;
	
	void Start () {
		startGame();
	}
	
	void startGame(){
		max=1000;
		min=1;		
		nextGuess();

	}
		
	public void guessHigher(){
		min=guess;		
		nextGuess();	
	}	
	
	public void guessLower(){
		max=guess;		
		nextGuess();
	}	
	
	void nextGuess(){	
		guess=Random.Range(min, max+1);
		text.text=guess.ToString();		
		//maxGuessAllowed=maxGuessAllowed-1;
				
		//if(maxGuessAllowed<=0){
		//	Application.LoadLevel("Win");
		//}	
	}
}
