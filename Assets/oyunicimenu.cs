using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunicimenu : MonoBehaviour
{
    public static bool durum = false;
    public GameObject  pauseekrani;
    public GameObject  panel; 

    
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape)){
            if(durum){
                dur();
            } 
            else {
                devam();
            }
        }  

    }

    public void dur(){
        pauseekrani.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        durum = false;
    }
    
    public void devam(){
        pauseekrani.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        durum = true;
    }

     public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

}
