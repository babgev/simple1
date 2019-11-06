#pragma strict
var fon:GameObject;
var colors:Color[];
var randNumber:int;
function Start () {
    
    randNumber=Random.Range(0,10);
    fon=GameObject.Find("fon");
    fon.GetComponent(SpriteRenderer).color=colors[randNumber];
   fon.GetComponent(SpriteRenderer).color.a=1;
    gameObject.GetComponent(SpriteRenderer).color.r=fon.GetComponent(SpriteRenderer).color.r;
    gameObject.GetComponent(SpriteRenderer).color.g=fon.GetComponent(SpriteRenderer).color.g;
    gameObject.GetComponent(SpriteRenderer).color.b=fon.GetComponent(SpriteRenderer).color.b;
    gameObject.GetComponent(SpriteRenderer).color.a=0.8;
    PlayerPrefs.SetInt("randNumber",randNumber);
   

}

function Update () {
  
}