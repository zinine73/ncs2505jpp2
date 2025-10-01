using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 3. UnityEvent 이용
public class GameOverAction : UnityEngine.Events.UnityEvent { }
public class DestroyOutOfBounds : MonoBehaviour
{
    // 1. SpawnManager를 정의, 연결하는 방법
    //SpawnManager sm;
    // 2. delegate 이용
    // public delegate void GameOverHandler();
    // public static event GameOverHandler OnGameOver;
    // 3.
    public static GameOverAction OnGameOver = new GameOverAction();
    float topBound = 30.0f;
    float lowerBound = -10.0f;

    void Start()
    {
        // SpawnManager 연결
        // sm = GameObject.Find("SpawnManager").
        //     GetComponent<SpawnManager>();
        // sm = GameObject.FindGameObjectWithTag("SM").
        //     GetComponent<SpawnManager>();
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            // SpawnManager의 DisplayGameOver를 호출
            //sm.DisplayGameOver();
            //OnGameOver();
            OnGameOver.Invoke();
            Destroy(gameObject);
        }
    }
}
