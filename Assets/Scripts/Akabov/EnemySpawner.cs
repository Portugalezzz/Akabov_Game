using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float spawnDelay = 1;
    public GameObject NewEnemy;
    int startAkabovs = 3;
    int startAkabovsCouter = 0;


        void Start()
    {

        StartCoroutine(NewEnemyDelayed());
    }


    IEnumerator NewEnemyDelayed()
    {
        while (true)
        {
            if (startAkabovsCouter < startAkabovs)
            {
                Instantiate(NewEnemy);
                Gameplay.enemyCounter++;
                startAkabovsCouter++;
            }
            else
            {
                yield return new WaitForSeconds(spawnDelay);
                Instantiate(NewEnemy);
                Gameplay.enemyCounter++;

            }
        }
        

    }

   public void StopSpawner()
    {
        StopAllCoroutines();
    }
   
}
