using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class monstermove : MonoBehaviour {

    private Transform monsterTransform;
    private Transform playerTransform;
    private NavMeshAgent nvAgent;

    private void Start()
    {
        monsterTransform = this.gameObject.GetComponent<Transform>();
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();

        nvAgent.destination = playerTransform.position; //추적 대상의 위치를 설정하면 바로 추적 시작
    }

    private void Update()
    {
        
    }
}



