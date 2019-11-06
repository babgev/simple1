using UnityEngine;
using System.Collections;

public class spawnQar : MonoBehaviour {
    public GameObject qar;
    Vector2 randPos;
    public float maxDistance=20,minDistance=10,invokeTime;
    float firstx,firsty, secondx,secondy, randomFrom2, randomFrom22;
    


	// Use this for initialization
	void Start () {
        randPos = new Vector2(10, -13);
       
        Spawn();
        PlayerPrefs.SetInt("SPG", 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region
        firstx = Random.Range(minDistance, maxDistance);
        secondx = Random.Range(-minDistance, -maxDistance);
        firsty = Random.Range(minDistance, maxDistance);
        secondy = Random.Range(-minDistance, -maxDistance);
        randomFrom2 = Random.Range(0, 10);
        randomFrom22 = Random.Range(0, 10);
        if (randomFrom2 > 5) { randPos.x = firstx; }
        else { randPos.x = secondx; }
        if (randomFrom22 > 5) { randPos.y = firsty; }
        else { randPos.y = secondy; }
        #endregion//Random numbers to instantiate
    }
    
    void Spawn()
    {
        
        
        GameObject clone = Instantiate(qar, randPos, Quaternion.identity) as GameObject;
        Debug.Log(clone.transform.position);
        
        Invoke("Spawn", invokeTime);
    }
}
