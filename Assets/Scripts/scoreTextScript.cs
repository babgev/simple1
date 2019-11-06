using UnityEngine;
using System.Collections;

public class scoreTextScript : MonoBehaviour {
    int SPG;
    
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().sortingLayerName = "UI";
	}
	
	// Update is called once per frame
	void Update () {
        SPG = PlayerPrefs.GetInt("SPG");
        gameObject.GetComponent<TextMesh>().text =""+ SPG.ToString();
        
	}
}
