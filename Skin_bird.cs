using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Skin_bird : MonoBehaviour {

	//Toggle skin bird
	public Toggle birdRed;
	public Toggle birdBlue;
	public Toggle birdPurple;
	public Toggle birdYellow;
	// skin bird gameObject
	public GameObject Redbird;
	public GameObject Bluebird;
	public GameObject Purplebird;
	public GameObject Yellowbird;


	void Awake ()
	{
		birdRed.isOn = PlayerPrefs.GetInt ("birdRed") == 0 ? true : false;

		
		birdBlue.isOn = PlayerPrefs.GetInt ("birdBlue") == 1 ? true : false; 

			PlayerPrefs.Save ();
		
			

	}


	public void ActiveToggle(){
		if (birdRed.isOn) 
		{
			Redbird.SetActive (!Redbird.activeSelf);
			Bluebird.SetActive (!Bluebird);
			Purplebird.SetActive (!Purplebird);
			Yellowbird.SetActive (!Yellowbird);
			PlayerPrefs.SetInt ("birdred", birdRed ? 0 : 1);

		} 
		else if (birdBlue.isOn) 
		{
			Bluebird.SetActive (!Bluebird.activeSelf);
			Redbird.SetActive (!Redbird);
			Purplebird.SetActive (!Purplebird);
			Yellowbird.SetActive (!Yellowbird);
			PlayerPrefs.GetInt ("birdblue", birdBlue ? 1: 0);

		} 
		else if (birdPurple.isOn)
		{
			Purplebird.SetActive (!Purplebird.activeSelf);
			Redbird.SetActive (!Redbird);
			Bluebird.SetActive (!Bluebird);
			Yellowbird.SetActive (!Yellowbird);
		} 
		else if (birdYellow.isOn)
		{
			Yellowbird.SetActive (!Yellowbird.activeSelf);
			Redbird.SetActive (!Redbird);
			Bluebird.SetActive (!Bluebird);
			Purplebird.SetActive (!Purplebird);
		}
	}

}
