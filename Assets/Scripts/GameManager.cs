using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform canva;
    public GameObject pauseMenu;
    public GameObject deathScene;
    public AudioSource audiosrc;
    public AudioClip deathAudio;
    public bool gameIsPaused = false;
    


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
                Pause();
            }

            else
            {
                Resume();
            }


            
        }
    }


    private void OnEnable()
    {
        PlayerController.onDead += Death;
    }


    private void OnDisable()
    {
        PlayerController.onDead -= Death;
    }


    
    public void Death()
    {

        GameObject.Find("Spawner").SetActive(false);
        audiosrc.clip = deathAudio;
        audiosrc.volume = 0.5f;
        audiosrc.Play();
        
        Instantiate(deathScene, canva);
        
    }

    public void Pause()
    {
        gameIsPaused = true;
        audiosrc.Pause();
        Time.timeScale = 0.0f;
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        gameIsPaused = false;
        audiosrc.Play();
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }


    public void Exit()
    {

        DOTween.KillAll();
        SceneManager.LoadScene(0);
        
    }    
}
