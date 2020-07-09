using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int xPos;
    int yPos;
    int posMin;
    int posMax;
    void Start()
    {
        //add code here (subtask 1)
        AddNewAvakov();

        StartCoroutine(ChangePositionDelayed());


    }



    void Update ()
    {

    }
    IEnumerator ChangePositionDelayed()
    {
        //add code here (subtask 2)
        while (true)
        {
            Debug.Log("Delay started");
            yield return new WaitForSeconds(1f);
            Debug.Log("Delay finished");
            AddNewAvakov();
        }

        //add code here (subtask 2)

    }

    int SetNewRandomPosition(int posMin, int posMax)
    {
        //add code here (subtask 1)

        
        return Random.Range(posMin, posMax);
    }

    public void DestroyEnemy()
    {
        //add code here (subtask 3)
        Destroy(transform.parent.gameObject);
        Gameplay.enemyCounter--;
    }
    public void StopController()
    {
        StopAllCoroutines();
    }
    private void AddNewAvakov()
    {
        xPos = SetNewRandomPosition(Screen.width / -2, Screen.width / 2);
        yPos = SetNewRandomPosition(Screen.height / -2, Screen.height / 2);
        transform.localPosition = new Vector3(xPos, yPos, 0);
    }
}
