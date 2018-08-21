using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ReSkinAnimation : MonoBehaviour
    {
    public Toggle birdRed;
    public Toggle birdBlue;
    public Toggle birdPurple;
    public Toggle birdYellow;
    public string spriteSheetName;
	public Animator thebird;

	void Start (){
		
		if (PlayerPrefs.GetInt ("red") == 1) {
			birdRed.isOn = true;
			birdYellow.isOn = false;
			birdPurple.isOn = false;
			birdBlue.isOn = false;
		} else {
			birdRed.isOn = false;
		}
		if (PlayerPrefs.GetInt ("blue") == 1) {
			birdBlue.isOn = true;
			birdRed.isOn = false;
			birdYellow.isOn = false;
			birdPurple.isOn = false;
		} else {
			birdBlue.isOn = false;
		}
		if (PlayerPrefs.GetInt ("Purple") == 1) {
			birdPurple.isOn = true;
			birdBlue.isOn = false;
			birdRed.isOn = false;
			birdYellow.isOn = false;
		} else {
			birdPurple.isOn = false;
		}
		if (PlayerPrefs.GetInt ("yellow") == 1) {
			birdYellow.isOn = true;
		} else {
			birdYellow.isOn = false;
		}
	}

	  
        void LateUpdate()
        {
        ActiveToggle();
            var Sprites = Resources.LoadAll<Sprite>("Characters/" + spriteSheetName);

            foreach (var renderer in GetComponentsInChildren<SpriteRenderer>())
            {
                string spriteName = renderer.sprite.name;
                var newSprite = Array.Find(Sprites, item => item.name == spriteName);

                if (newSprite)
                    renderer.sprite = newSprite;
          
            
        }

        }

    public void ActiveToggle()
    {
        if (birdRed.isOn)
        {
            spriteSheetName = "thebird";
			PlayerPrefs.SetInt ("red", 1);
			PlayerPrefs.SetInt ("yellow", 0);
			PlayerPrefs.SetInt ("Purple",0);
			PlayerPrefs.SetInt ("blue", 0);
        }

        else if (birdBlue.isOn)

        {
            spriteSheetName = "thebird2";
			PlayerPrefs.SetInt ("blue", 1);
			PlayerPrefs.SetInt ("red", 0);
			PlayerPrefs.SetInt ("yellow", 0);
			PlayerPrefs.SetInt ("Purple",0);
        }
        else if (birdPurple.isOn)
        {
            spriteSheetName = "thebird3";
			PlayerPrefs.SetInt ("Purple",1);
			PlayerPrefs.SetInt ("blue", 0);
			PlayerPrefs.SetInt ("red", 0);
			PlayerPrefs.SetInt ("yellow", 0);
        }
        else if (birdYellow.isOn)
        {
            spriteSheetName = "thebird4";
			PlayerPrefs.SetInt ("yellow", 1);
			PlayerPrefs.SetInt ("Purple",0);
			PlayerPrefs.SetInt ("blue", 0);
			PlayerPrefs.SetInt ("red", 0);
        }
        

 
	}
	void Update()
	{		
		if (Input.GetMouseButtonDown (0))
			thebird.SetBool ("Anim", true);
		else
			thebird.SetBool ("Anim", false);				
	}

}

    


