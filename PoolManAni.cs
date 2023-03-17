using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManAni : MonoBehaviour
{

    Animator Animator;
    // Start is called before the first frame update
    void Start() //플레이어가 골라인에 닿으면 애니메이션을 활성화 합니다. 그리고 오프셋을 이용하여 움직입니다.
    {
        
        Animator = GetComponent<Animator>();
        Animator.SetFloat("offset",Random.Range(0,1f));
        Animator.SetFloat("Base",Random.Range(0,3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
