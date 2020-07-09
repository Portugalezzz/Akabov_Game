using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject NewEnemy;
    
        void Start()
    {

        StartCoroutine(NewEnemyDelayed());
    }


    IEnumerator NewEnemyDelayed()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1f);

            Instantiate(NewEnemy);
            Gameplay.enemyCounter++;
        }

        

    }

   public void StopSpawner()
    {
        StopAllCoroutines();
    }
   
}
