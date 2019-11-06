using UnityEngine;
using System.Collections;

public class mouseAction : MonoBehaviour {
    public int levelNumer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown() 
    {
        Application.LoadLevel(levelNumer);
    }
}
