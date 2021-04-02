using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleVariation : MonoBehaviour
{
    int movingVar;
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
         movingVar = Random.Range(0, 3);
         moveSpeed = Random.Range(-10, 10);

        Color materialColor = new Color(.01f * Random.Range(50, 100), .01f * Random.Range(0, 20), .01f * Random.Range(0, 20));
        gameObject.GetComponent<Renderer>().material.color = materialColor;

        float vectorRandom = 1.1f + (Random.Range(0, 40) * .01f);
        Vector3 scaleVector = new Vector3(vectorRandom, vectorRandom, vectorRandom);
        gameObject.GetComponent<Transform>().localScale = scaleVector;

        if(transform.position.x < -9 || transform.position.x > 9)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(movingVar != 1)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
}
