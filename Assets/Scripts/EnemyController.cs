using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyController : MonoBehaviour
{

    public float speed;
    
    void Start()
    {
        StartCoroutine(Jump());
    }

    
    




    public IEnumerator Jump()
    {
        while (true)
        {
           
            

            yield return transform.DOJump(new Vector3(transform.position.x, transform.position.y, transform.position.z - 4), 1, 1, speed).Play().WaitForCompletion();
        }
        
    }


    


}
