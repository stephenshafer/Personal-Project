using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFloor : MonoBehaviour
{

    private PlayerController player;
   // public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
       // StartCoroutine("destroyFloor");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < player.transform.position.z - 120)
        {
            Destroy(gameObject);
        }

        /*
        if(transform.position.z - player.transform.position.z > 120)
        {
            Destroy(gameObject);
        }
        */
    }

    IEnumerator destroyFloor()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }
}
