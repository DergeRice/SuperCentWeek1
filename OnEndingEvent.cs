using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEndingEvent : MonoBehaviour
{
    public GameObject EndingManPar;
    [SerializeField] GameObject Char;
    [SerializeField] GameObject WaterBall;
    [SerializeField] GameObject EndingParticle;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)//로티 : 플레이어가 골라인에 닿으면 엔딩씬을 구성하는 모든 오브젝트를 관리
    {
        if (other.tag == "ChaPos")
        {
            EndingParticle.SetActive(true);
            for (int i = 0; i < EndingManPar.transform.childCount; i++)
            {
                EndingManPar.transform.GetChild(i).GetComponent<Animator>().SetTrigger("GoalIn");
            }
            WaterBall.transform.position = new Vector3(Char.transform.position.x, Char.transform.position.y - 10, Char.transform.position.z);
            WaterBall.GetComponent<Rigidbody>().AddForce(Vector3.up * 100, ForceMode.Impulse);
            //WaterBall.transform.GetChild(0).GetComponent<Animator>().SetBool("up",true);
            //WaterBall.transform.position = Vector3.MoveTowards(WaterBall.transform.position,new Vector3(WaterBall.transform.position.x,WaterBall.transform.position.y+20,WaterBall.transform.position.z),Time.deltaTime);

        }
    }

    private void OnCollisionEnter(Collision other)
    {

    }
}
