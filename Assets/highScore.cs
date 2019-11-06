using UnityEngine;
using System.Collections;

public class highScore : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        int high = PlayerPrefs.GetInt("high");
        int thisScore = PlayerPrefs.GetInt("SPG");
        gameObject.GetComponent<TextMesh>().text = high.ToString();
        if (thisScore>high)
        {

            PlayerPrefs.SetInt("high", thisScore);
            gameObject.GetComponent<TextMesh>().text = PlayerPrefs.GetInt("high").ToString();
                }
       
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
