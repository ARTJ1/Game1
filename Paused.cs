using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour {

	public bool pause;
	public GameObject panel;
	public GameObject ScoreText;
	public GameObject pauseButton;
	public GameObject bird;
	// Use this for initialization

	void Start (){
		Time.timeScale = 1;
	}
	public void paused()
	{
		pause = !pause;
		if (pause) {
			Time.timeScale = 0;
			panel.SetActive (!panel.activeSelf);
			ScoreText.SetActive (!ScoreText.activeSelf);
			pauseButton.SetActive (!pauseButton.activeSelf);
			bird.SetActive (!bird.activeSelf);
		}

	}
	public void back(){
		pause = false;
		Time.timeScale = 1;
		panel.SetActive (!panel.activeSelf);
		ScoreText.SetActive (!ScoreText.activeSelf);
		pauseButton.SetActive (!pauseButton.activeSelf);
		bird.SetActive (!bird.activeSelf);
	}
	public void Exite(){
		Application.Quit ();
	}


}
