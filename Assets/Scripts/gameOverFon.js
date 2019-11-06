#pragma strict
var randNumber:int;
var colors:Color[];
var SPGtext:GameObject;
var colorAlpha:float=1;
function Start () {
    randNumber= PlayerPrefs.GetInt("randNumber");
    
    gameObject.GetComponent(SpriteRenderer).color=colors[randNumber];
    gameObject.GetComponent(SpriteRenderer).color.a=colorAlpha;
    if(gameObject.name=="GameOverFon"){
        SPGtext=GameObject.Find("SPG");   
        SPGtext.GetComponent(TextMesh).text=PlayerPrefs.GetInt("SPG").ToString();
    }
}

function Update () {
    
}