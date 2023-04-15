using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup fadingGroup;
    [SerializeField] private GameObject loadingScene;
    void Start()
    {
        DOTween.KillAll();
        Time.timeScale = 1.0f;
        fadingGroup.DOFade(1, 1).Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void StartGame()
    {
        DOTween.KillAll();
        loadingScene.SetActive(true);
        SceneManager.LoadScene(1);
        
    }


    public void Exit()
    {
        Application.Quit();
    }

}
