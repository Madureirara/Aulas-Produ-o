using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    // Start is called before the first frame update
    public static HudController instance;
    
    public Text textScore;
    void Awake(){
        instance=this;
    }
    public void UpdateScore(int score){
        textScore.text= "Pontos: "+score;
    }
}
