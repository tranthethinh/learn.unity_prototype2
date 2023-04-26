using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowBound = -10.0f;
    private float leftBound = 20.0f;
    private float rightBound = -20.0f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBound)
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        } 
        else if (transform.position.x > leftBound)
        {
            Destroy(gameObject);
            gameManager.Addlives(-1);
        }
        else if (transform.position.x < rightBound)
        {
            Destroy(gameObject);
            gameManager.Addlives(-1);
        }
    }
}
