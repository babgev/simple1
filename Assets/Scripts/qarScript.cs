using UnityEngine;
using System.Collections;

public class qarScript : MonoBehaviour {
   #region
    string ujexutyun;//harvaci ujexutyun     enqanvor stringa
    GameObject meshtex;//meshtexinna
    Vector2 gotopos;//iran meshtexin miacnoxna
    public int movingForce;//Fore multiplayer
    public ParticleSystem partTuyl;//tuyl ujexutyan hamar particle
    bool xpac;//xpvela es qary te che
    GameObject scoreAddText;//scorei avelacacy cuyc tvox
   


   #endregion //Variables

    // Use this for initialization
	void Start () {
        scoreAddText = GameObject.Find("scoreAddText");
        meshtex = GameObject.FindGameObjectWithTag("meshtex");
        gotopos = meshtex.transform.position - gameObject.transform.position;
        GetComponent<Rigidbody2D>().AddForce(gotopos * movingForce, ForceMode2D.Force);//uja haxordum
        scoreAddText.GetComponent<Renderer>().sortingLayerName = "UI";
       // partTuyl = GetComponentsInChildren<ParticleSystem>()[0];
       
        xpac = false;
        
        
	}
  
	
	// Update is called once per frame
	void Update () {
        
        
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "mahacu")
        {
            Destroy(gameObject);
        }
            if (col.gameObject.name == "qashvox")
        {
           // StartCoroutine(PartPlayPause(partTuyl));
            if (xpac == false)
            {
                if (col.relativeVelocity.magnitude >= 10 && col.relativeVelocity.magnitude < 20)
                { ujexutyun = "lav"; PlayerPrefs.SetInt("SPG", PlayerPrefs.GetInt("SPG") + 2); xpac = true; StartCoroutine(AddNumber(2)); }//+2 SPG
                else if (col.relativeVelocity.magnitude >= 20 && col.relativeVelocity.magnitude < 30)
                { ujexutyun = "aveli lav"; PlayerPrefs.SetInt("SPG", PlayerPrefs.GetInt("SPG") + 3); xpac = true; StartCoroutine(AddNumber(3)); }//+3 SPG
                else if (col.relativeVelocity.magnitude >= 30)
                { ujexutyun = "tuyn"; PlayerPrefs.SetInt("SPG", PlayerPrefs.GetInt("SPG") + 5); xpac = true; StartCoroutine(AddNumber(5)); }//+5 SPG
                else if (col.relativeVelocity.magnitude < 10)
                { ujexutyun = "tuyl"; PlayerPrefs.SetInt("SPG", PlayerPrefs.GetInt("SPG") + 1); xpac = true;StartCoroutine( AddNumber(1)); }//+1 SPG

            }

        }
    }
    
   IEnumerator AddNumber(int numb)
   {
       scoreAddText.GetComponent<TextMesh>().text = "+" + numb;
       yield return new WaitForSeconds(1);
       scoreAddText.GetComponent<TextMesh>().text = "";

   }
 /*   IEnumerator PartPlayPause( ParticleSystem partName) 
    {
        partName.Play();
        yield return new WaitForSeconds(partName.duration);

        partName.Stop();
        
    }//Yndunac particle effect popoxakanin miacnum anjatuma*/
}

