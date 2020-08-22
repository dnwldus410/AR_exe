using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float m_speed=3.0f;
    private Rigidbody m_myRb;
    // Start is called before the first frame update
    void Start()
    {
        m_myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnRight();
        }
    }
    public void OnLeft()
    {
        m_myRb.velocity = new Vector3(-1 * m_speed, 0.0f, 0.0f);
    }
    public void OnRight()
    {
        m_myRb.velocity = new Vector3(1 * m_speed, 0.0f, 0.0f);
    }
}
