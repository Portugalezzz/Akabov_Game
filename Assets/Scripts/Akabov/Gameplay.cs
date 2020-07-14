using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Gameplay : MonoBehaviour
{

    int maxAkabov = 9;
    public static int enemyCounter = 0;
    public int highscore = 0;
    public EnemySpawner Stopper;

    // Start is called before the first frame update
    void Start()
    {
        enemyCounter = 1;
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
            SceneManager.LoadScene("MenuWin");
            Score.showScore();

        }
        else if (enemyCounter > maxAkabov)
        {
            Stopper.StopSpawner();
            EnemyController[] components = GameObject.FindObjectsOfType<EnemyController>();
            Debug.Log(components);

            foreach (var EnemyController in components)
            {
                EnemyController.StopController();

            }

            SceneManager.LoadScene("MenuLooses");


        }

        void SaveScore()
        {

        }

    }           
         
}
        

         



