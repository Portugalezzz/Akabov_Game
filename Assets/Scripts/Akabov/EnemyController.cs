﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int xPos;
    int yPos;
    int posMin;
    int posMax;
    int KillSound;
    public static int score = 0;
    AudioSource audioData;

    void Start()
    {
        AddNewAvakov();
        StartCoroutine(ChangePositionDelayed());
        
    }




    IEnumerator ChangePositionDelayed()
    {
        while (true)
        {
            Debug.Log("Delay started");
            yield return new WaitForSeconds(1f);
            Debug.Log("Delay finished");
            AddNewAvakov();
        }

        
    }

    int SetNewRandomPosition(int posMin, int posMax)
    {
        return Random.Range(posMin, posMax);
    }

    int SetNewKillSound()
    {
        return Random.Range(0,12);
    }

    public void DestroyEnemy()
    {
        Destroy(transform.parent.gameObject);
        Gameplay.enemyCounter--;
        score++;
        Debug.Log("Akabov kills " + score);
        if(KillSound < 4)
        {
            GameObject[] KillSoundsArray = GameObject.FindGameObjectsWithTag("KillSound");
            GameObject SoundComponent = KillSoundsArray[KillSound];
            audioData = SoundComponent.GetComponent<AudioSource>();
            audioData.Play();

            Debug.Log("Killsound is " + KillSound);
        }

        
    }
    public void StopController()
    {
        StopAllCoroutines();
    }
    private void AddNewAvakov()
    {
        // xPos = SetNewRandomPosition(Screen.width / -2, Screen.width / 2);
        xPos = SetNewRandomPosition(1280 / -2 + 75, 1280 / 2 - 75);
        Debug.Log(Screen.width);
        // yPos = SetNewRandomPosition(Screen.height / -2, Screen.height / 2);
        yPos = SetNewRandomPosition(720 / -2 + 75, 720 / 2 - 75);
        transform.localPosition = new Vector3(xPos, yPos, 0);
        KillSound = SetNewKillSound();
       // Debug.Log("Killsound is " + killSound);
    }
}
