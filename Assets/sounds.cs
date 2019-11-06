using UnityEngine;
using System.Collections;

public class sounds : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name== "foni sahman")
        {
            gameObject.GetComponent<AudioSource>().Play();
            
        }
        else
        {
            GameObject.Find("scoreText").GetComponent<AudioSource>().Play();
        }
    }
}
