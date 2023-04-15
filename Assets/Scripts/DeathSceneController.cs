using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;

public class DeathSceneController : MonoBehaviour




{

    public int score;
    public TextMeshProUGUI total;
    
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Cleaner").GetComponent<ObjectCleaner>().score;
        total.text = $"Score : {score.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Restart()
    {
        
        DOTween.KillAll();
        SceneManager.LoadScene(1);
    }



    public void ToMainMenu()
    {
        DOTween.KillAll();
        SceneManager.LoadScene(0);
    }
}
