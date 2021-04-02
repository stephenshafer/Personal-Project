using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private float spawnRate = 1.5f;
    [SerializeField]
    private GameObject obstacle;
    private float spawnDistance = 50;
    private int cubeNumber;
   
    // Start is called before the first frame update
    void Start()
    {
        spawnDistance /= 2;
        spawnObstacle();
        spawnDistance *= 2;
        spawnObstacle();
        InvokeRepeating("spawnObstacle", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        cubeNumber = Random.Range(3, 7);
        instantiateCube(cubeNumber);    

        /*
        for(int i = 0; i < cubeNumber; i++)
        {
            float randomX = Random.Range(-9, 9);
            Instantiate(obstacle, new Vector3(randomX, 1, transform.position.z + spawnDistance), obstacle.transform.rotation);
        }
        */

       
            /*
            if (randomX > 0)
            {
                if(randomX < 5)
                {
                    otherRandom = Random.Range(-3, 3);
                }
                else
                {
                    otherRandom = Random.Range(-5, 2);
                }
            }
            else
            {
                if(randomX > -5)
                {
                    otherRandom = Random.Range(-3, 3);
                }
                else
                {
                    otherRandom = Random.Range(-2, 5);
                }
            }
            if(otherRandom == 0)
            {
                if(randomX > 0)
                {
                    otherRandom = Random.Range(-4, -2);
                }
                else
                {
                    otherRandom = Random.Range(2, );
                }
            }
            */
                             
    }

    void instantiateCube(int howMany)
    {
        float randomOffset = Random.Range(-3, 3);
        float obstacleStartingX = 20 / (howMany + 1) - 10;
        float obstacleDistance = 20 / howMany;
        for(int i = 0; i < howMany; i++)
        {
            Instantiate(obstacle, new Vector3(obstacleStartingX + randomOffset + i * obstacleDistance, 1, transform.position.z + spawnDistance), obstacle.transform.rotation);

            /*
            Debug.Log("howMany");
            Debug.Log(howMany);
            Debug.Log("Starting");
            Debug.Log(obstacleStartingX);
            Debug.Log("distance");
            Debug.Log(obstacleDistance);
            */
        }
    }
      
}
