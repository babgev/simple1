using UnityEngine;
using System.Collections;

public class meshtexScript : MonoBehaviour {
    int exacChap = 1;//nor qashoxi mot 1 lini skzbnakan chapi multiplayery
	// Use this for initialization
	void Start () {
        exacChap = PlayerPrefs.GetInt("exacChap");//karoxa poxvaca exac chapy etqan sarqvi stex
        if (PlayerPrefs.GetInt("meshtSizeMultip") != exacChap) //ete tvac popoxakany poxvela....
        {
            exacChap = PlayerPrefs.GetInt("meshtSizeMultip");//hetoyva hamar poxi exac chapy....
            PlayerPrefs.SetInt("exacChap", exacChap);//vorpes pref pahi
            gameObject.transform.localScale = gameObject.transform.localScale * exacChap;//u mecacni sarqi etqan
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
