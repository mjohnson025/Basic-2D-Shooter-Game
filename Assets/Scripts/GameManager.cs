using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject target;
    public float spawnStart;
    public float spawnFrequency;
    public int scoreMultiplier;
    int score = 0;
    public int winningScore;
    public Text scoreText;
    bool win = false;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnStart, spawnFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        if (win) {
            CancelInvoke("Spawn");
        }

        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void Spawn()
    {
         float randomX = Random.Range(-7f, 7f);
         float randomY = Random.Range(-4f, 4f);

         Vector3 randomPosition = new Vector3(randomX, randomY, 0);

         Instantiate(target, randomPosition, Quaternion.identity);
    }

    public void IncreaseScore()
    {
        
        score += scoreMultiplier;
        scoreText.text = score.ToString();
        if(score >= winningScore)
        {
            win = true;
            winText.SetActive(true);
        }

    }
}
