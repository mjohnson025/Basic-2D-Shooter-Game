using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float targetLifeTime;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, targetLifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        gameManager.IncreaseScore();
        Destroy(gameObject);
    }
}
