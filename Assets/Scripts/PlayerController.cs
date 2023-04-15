using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Image healthBar;
    private int _health = 3;
    public int _currentLine = 1;
    [SerializeField] List<Transform> _roads;
    MeshRenderer meshPlayer;
    public AudioSource audioSrc;
    public AudioClip damageSound;
    public static Action onDead;


    


    private void Start()
    {
        meshPlayer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        
        if (_currentLine != 0 && Input.GetKeyDown(KeyCode.A))
        {
            _currentLine -= 1;
            transform.DOMove(new Vector3(_roads[_currentLine].position.x, transform.position.y, transform.position.z), 0.5f).Play();
        }
        


        else if (_currentLine != 2 && Input.GetKeyDown(KeyCode.D)) {
            _currentLine += 1;
            transform.DOMove(new Vector3(_roads[_currentLine].position.x, transform.position.y, transform.position.z), 0.5f).Play();
        }


       

       



    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            audioSrc.PlayOneShot(damageSound);
            _health -= 1;
            meshPlayer.material.DOColor(Color.red, 0.5f).SetEase(Ease.Linear).SetLoops(2, LoopType.Yoyo).Play();
            healthBar.fillAmount = (float)_health / 3;
            

            if (_health <= 0)
            {
                Death();

            }

        }
    }




    private void Death()
    {
        gameObject.SetActive(false);
        onDead.Invoke();
    }
}
