using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    [SerializeField] GameObject gameOverPanel;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;
    private float spawnIntervalStart = 3.0f;
    private float spawnIntervalEnd = 5.0f;

    bool isGameOver;
    float timer;

    void OnEnable()
    {
        DestroyOutOfBoundsX.OnGameOver += DisplayGameOver;
    }

    void OnDisable()
    {
        DestroyOutOfBoundsX.OnGameOver -= DisplayGameOver;
    }

    void Start()
    {
        isGameOver = false;
        gameOverPanel.SetActive(false);
        timer = startDelay;
        //InvokeRepeating("SpawnRandomBall", startDelay, si);
    }

    void Update()
    {
        if (isGameOver) return;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Invoke("SpawnRandomBall", 0);
            timer = Random.Range(spawnIntervalStart, spawnIntervalEnd);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int idx = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[idx], spawnPos, ballPrefabs[idx].transform.rotation);
    }

    public void DisplayGameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }
}
