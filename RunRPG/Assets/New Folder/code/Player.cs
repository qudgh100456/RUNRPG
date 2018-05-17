using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Status  //플레이어의 증가능력치를 구조체로 만들어 사용한다.
{
    public int m_nHP;
    public int m_nStr;
    public int m_nDef;
    public int m_nSpeed;


    public Status(int nHP = 0, int nStr = 0, int nDef = 0, int nSpeed = 10)
    {
        m_nHP = nHP;
        m_nStr = nStr;
        m_nDef = nDef;
        m_nSpeed = nSpeed;
    }
    public void AddStatus(int var)
    {
        m_nHP += var;
        m_nStr += var;
        m_nDef += var;
        m_nSpeed += var;
    }
    public class Player : MonoBehaviour
{
   
    }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


        }

    
}
