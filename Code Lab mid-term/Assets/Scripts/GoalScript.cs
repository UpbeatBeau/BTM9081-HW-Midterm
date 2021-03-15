using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) //if something enters the trigger
    {
        //Increase the Level, and also load that level
        //that we reference through the GameManager Singleton
        GameManager.instance.GetComponent<ASCIILevelLoader>().CurrentLevel++;
    }
}
