using UnityEngine;
using System.Collections;

public class lineScript : MonoBehaviour {
    GameObject qashox, qashvox;
    
    
	// Use this for initialization
	void Start () {
        qashox = GameObject.Find("qashox");
        qashvox = GameObject.Find("qashvox");
        

      
        
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<LineRenderer>().SetPosition(0, qashvox.transform.position);
        gameObject.GetComponent<LineRenderer>().SetPosition(1, qashox.transform.position);
	}
}
