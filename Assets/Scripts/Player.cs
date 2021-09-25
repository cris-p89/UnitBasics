using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpValue = 2;
    public float moveValue = 2;
    private Rigidbody m_Rigidbody;
    private bool keyUp = false;
    //private bool keyLeft = false;
    //private bool keyRight = false;
    private float horizontalSpeedValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            keyUp = true;
        }

        horizontalSpeedValue = Input.GetAxis("Horizontal");
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            keyLeft = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            keyRight = true;
        }*/
    }

    private void FixedUpdate()
    {
        if(keyUp == true)
        {
            m_Rigidbody.AddForce(Vector3.up* jumpValue, ForceMode.VelocityChange);
            keyUp = false;
        }

        /*if (keyLeft == true)
        {
            m_Rigidbody.AddForce(Vector3.left * moveValue, ForceMode.VelocityChange);
            keyLeft = false;
        }

        if(keyRight == true)
        {
            m_Rigidbody.AddForce(Vector3.right * moveValue, ForceMode.VelocityChange);
            keyRight = false;
        }*/
        Vector3 myVelocity = m_Rigidbody.velocity;
        myVelocity.x = horizontalSpeedValue;
        m_Rigidbody.velocity = myVelocity;
    }
}
