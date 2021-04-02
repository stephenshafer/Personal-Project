using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float strafeSpeed = 5;
    [SerializeField]
    private float moveSpeed = 10;
    private float xRange = 9;
    private float jumpHeight = 500;
    private bool hasJumped = false;
    Rigidbody m_Rigidbody;
    private bool jumpBonus = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {     
        transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        if (jumpBonus == true)
        {
            if (Input.GetKeyDown("w") == true & hasJumped == false)
            {
                m_Rigidbody.AddForce(transform.up * jumpHeight);
                hasJumped = true;
                jumpBonus = false;
            }
        }
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }        
      
    }

    public void OnCollisionEnter(Collision collision)
    {
        hasJumped = false;
    }

    public void addJumpBonus()
    {
        if(jumpBonus == false)
        {
            jumpBonus = true;
        }
    }
}
