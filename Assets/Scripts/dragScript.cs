using UnityEngine;
using System.Collections;



public class dragScript : MonoBehaviour {

#region vars
    Vector2 mousePos;//sharjvaci coordinatner
    bool sexmvaca;//sexmaca te che
    GameObject qashvox;
    
     
      
      
   

#endregion//popoxakannernen stex
    void Start () {
        qashvox = GameObject.Find("qashvox");
       
         sexmvaca = false;
	}
    void Update()
    {
     
  
        mouseDrag();//lriv imasty esa 
        mouseEnd();//vor henc muky toxem zroyana
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            sexmvaca = true;
        }

    }
    #region mousefunctions
    /* void mouseStart() 
    {
        if(Input.GetMouseButtonDown(0))
    {
        // touchPos = Camera.main.ScreenToWorldPoint(Input.touches[0].position); // when using touch
     mouseStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
     }

    }*/
   
    
               
       
    
    void mouseDrag() 
    {
        if (sexmvaca==true)
        {
           mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           gameObject.transform.position = Vector2.Lerp(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), mousePos,1 );
        }
    }
    void mouseEnd() 
    {
        if (Input.GetMouseButtonUp(0)) {  sexmvaca = false; }
    }

    #endregion//mousei funcianer(sexmel,pahel,toxel)
}
