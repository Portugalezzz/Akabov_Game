using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public static int enemyCounter = 1;
    public EnemySpawner Stopper;
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
       // StartCoroutine(RestartAfterSleep());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemyCounter);
        if (enemyCounter == 0)
        {
            Stopper.StopSpawner();
           // enemyCounter = 1;
           // SceneManager.LoadScene("Task_2");
            //StopMove.StopController();
        }
        else if (enemyCounter > 9)
        {
            Stopper.StopSpawner();
            EnemyController[] components = GameObject.FindObjectsOfType<EnemyController>();
            Debug.Log(components);

            foreach (var EnemyController in components)
            {
                EnemyController.StopController();

            }
            //enemyCounter = 1;
           // SceneManager.LoadScene("Task_2");
            // StopMove.StopController();

        }
    }

  /*  public void onResume()
    {
        enemyCounter = 1;
        SceneManager.LoadScene("Task_2");
    }
    */
    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            
        }
        else
        {
            enemyCounter = 1;
            SceneManager.LoadScene("Task_2");
        }
    }
}
