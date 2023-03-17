using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 로티: 물이 모든 오브젝트를 무시하고 렌더링 되기 때문에 box오브젝트로 렌더링을 막고 플레이어의 위치를 반영하여 자연스럽게 내려가는 기믹입니다.  눈물났습니다.
public class WaterFogMove : MonoBehaviour 
{
    [SerializeField] GameObject Player;

    Vector3 Des;
    // Start is called before the first frame update
    void Start()
    {
        Des = transform.position + Vector3.down*60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,Des.y+Player.transform.position.y/10,transform.position.z);
    }
}
