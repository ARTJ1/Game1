using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Settings : MonoBehaviour {

	public GameObject start;
	public GameObject Exit;
	public GameObject PanelSettings;
	public Toggle birdRed;



	public Slider Slider;		


	void Awake ()
	{
		if (PlayerPrefs.HasKey ("valume")) {
			Global.sound = 1;
			Slider.value = 1;
		} 
				
	}
	void Start(){
		Slider.value = PlayerPrefs.GetFloat ("valume");
	}

	public void setSound(float value)
	{

		Global.sound = value;
		PlayerPrefs.SetFloat ("valume", value);
		PlayerPrefs.Save(); 
		AudioListener.volume = Global.sound ;

	}

	public void settings()
	{
		
		start.SetActive (!start.activeSelf);
		Exit.SetActive (!Exit.activeSelf);
		PanelSettings.SetActive (!PanelSettings.activeSelf);

	}

}
