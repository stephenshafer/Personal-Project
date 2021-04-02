using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("waitAndDestroy");
        //  PlayerController player = FindObjectOfType<PlayerController>();
        player = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.z + 10 < player.transform.position.z)
      {      
        Destroy(gameObject);
      }
    }

    IEnumerator waitAndDestroy()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
