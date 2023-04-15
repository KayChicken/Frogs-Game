using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] private GameObject enemy;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private float delayTime = 8;
    [SerializeField] private float decreaseTime = 0.5f;
    [SerializeField] private float minDelayTime = 1.5f;
    [SerializeField] private float minSpeedJump = 0.3f;
    [SerializeField] private float delaySpeedJump = 0.2f;
    [SerializeField] private float startSpeedEnemy = 1;
    

    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public IEnumerator Spawn()
    {
        while (true)
        {


            GameObject spawnEnemy = Instantiate(enemy, _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform);
            spawnEnemy.GetComponent<EnemyController>().speed = startSpeedEnemy;



            if (startSpeedEnemy >= minSpeedJump)
            {
                startSpeedEnemy -= delaySpeedJump;
            }
            


            if (delayTime >= minDelayTime)
            {
                delayTime -= decreaseTime;
                
            }

            yield return new WaitForSeconds(delayTime);
        }
        

    }
}
