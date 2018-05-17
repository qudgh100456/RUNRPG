using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamic : MonoBehaviour
{
    public GameObject PlayerMarker;
    public float m_fMoveSpeed;
    public int m_fRotSpeed;
    public int maxfMoveSpeed;
    public float m_fPower;
    private Rigidbody m_Rigidbody;



    // Use this for initialization
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        InputProcess();
        if (m_fMoveSpeed < maxfMoveSpeed && m_fMoveSpeed > 10) //입력없는 상태일때 스피드 감소
        {
            m_fMoveSpeed -= 0.6f;
        }

        PlayerMarker.transform.position = new Vector3(this.transform.position.x, PlayerMarker.transform.position.y, this.transform.position.z);
        PlayerMarker.transform.forward = this.transform.forward;

    }

    void InputProcess()
    {
        float fMoveDist = m_fMoveSpeed * Time.deltaTime;
        float fRotAngle = m_fRotSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * fMoveDist);
            if (m_fMoveSpeed <= maxfMoveSpeed) //w키 누른상태  점차적 스피드 증가
            {
                m_fMoveSpeed += 0.7f;
            }
            m_Rigidbody.isKinematic = false;
        }
       /* if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(Vector3.forward * fMoveDist);
            m_fMoveSpeed += 0.7f;
            m_Rigidbody.isKinematic = true;
        }*/
        if (Input.GetKey(KeyCode.S))
        {

            if (m_fMoveSpeed <= maxfMoveSpeed && m_fMoveSpeed > 10)
                m_fMoveSpeed -= 0.1f;

            m_Rigidbody.isKinematic = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * m_fRotSpeed);
            m_Rigidbody.isKinematic = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -m_fRotSpeed);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject objTarget = collision.gameObject;
        Rigidbody rigidbodyTarget = objTarget.GetComponent<Rigidbody>();
        rigidbodyTarget.AddForce(transform.forward * m_fPower * m_fMoveSpeed);

    }
}
