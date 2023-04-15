using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
public class ObjectCleaner : MonoBehaviour
{

    public TextMeshProUGUI scoreTable;
    public int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            score += 1;
            other.gameObject.transform.DOKill();
            Destroy(other.gameObject);
            scoreTable.text = score.ToString();

        }
    }


}
