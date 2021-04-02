using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
   private int remainderCounter = 1;

    private bool hasPlaced;
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if(transform.position.z > 50 * remainderCounter)
        {
            remainderCounter++;
            Debug.Log("hit 50");
            hasPlaced = false;
        }

        if(remainderCounter % 2 == 0 & hasPlaced == false)
        {
            Instantiate(floor, new Vector3(0, 0, 100 + transform.position.z), floor.transform.rotation);
            hasPlaced = true;
        }     
    }
}
