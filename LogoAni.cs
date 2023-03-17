using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAni : MonoBehaviour
{

    Animator animator; //로티: 이펙트가 끝나면 사라지도록 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Exit"))
        {
            Destroy(gameObject);
        }
    }
}
