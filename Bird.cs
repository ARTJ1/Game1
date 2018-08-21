using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


 public class Bird : MonoBehaviour {
    Rigidbody2D body;
    public float speed = 2f;
	public static Bird Instance { get; private set;}
	public int score = 0;
	public int PlusSkore = 1;
    public Text Text;
	public int Record;
	public Text Myrecord;
	public Animator AnimScore;
	public int flag;
    // Use this for initialization
	public void Awake()
	{
		Instance = this;

	}
    void Start () {
        body = GetComponent<Rigidbody2D>();
        

    }
    
    
    
	
	// Update is called once per frame
	void Update () {
        


					

				
        Vector3 position = transform.position;
        if (position.y < 0)
        {
            Application.LoadLevel(2);
        }

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            body.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
        float h = Input.GetAxis("Horizontal");
        if (h != 0)
        {
            body.AddForce(Vector2.right * speed * h);
        }
		if (score > Record) 
		{
			PlayerPrefs.SetInt ("SaveScore", score);
			PlayerPrefs.Save (); 				
		}
		if (flag<score){
			flag = score;
			AnimScore.SetBool ("AnimScore", true); 
		}else AnimScore.SetBool ("AnimScore", false);

		Record = PlayerPrefs.GetInt ("SaveScore");
		Myrecord.text = "Score: " + Record.ToString();


			
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "tube")
        {
            Application.LoadLevel(2);
        }       
            }
	void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.tag == "point") {
			score += PlusSkore;

		}

		Text.text = " " + score.ToString();
    }


	public void RestartRecord()
	{
		PlayerPrefs.DeleteKey ("SaveScore");
	}
		


}     
        


    
    
    


