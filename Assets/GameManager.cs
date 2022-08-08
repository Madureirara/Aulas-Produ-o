using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int pontos;
    private int vida;
    void Awake(){
        Debug.Log("paçoca");
        if (instance==null)
        {
            instance=this;
        }
         else
        {
            Destroy(gameObject);
        }
         DontDestroyOnLoad (gameObject);
    }
    public GameManager getInstance(){
        return instance;
    }
    public void PerdeVida(){
        vida--;
        if(vida<=0)
        {
            Debug.Log("GameOver");
        }
    }
    public void AddScore(){
        pontos++;
        HudController.instance.UpdateScore(pontos);
    }
    public void Update(){
        if (Input.GetKeyDown(KeyCode.N)){
            SceneManager.LoadScene("Level2");
        }
    }
}
