using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ranking : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] GameObject AIpar;
    [SerializeField] GameObject Player;
    public GameObject[] AI_Rank;



    GameObject Temp;
    void Start() //로티: Object를 미리 받아 object들의 미리 준비해놓습니다
    {
        AI_Rank = new GameObject[6];
        for (int i = 0; i < AIpar.transform.childCount; i++)
        {
            AI_Rank[i] = AIpar.transform.GetChild(i).gameObject;
        }
        AI_Rank[AIpar.transform.childCount] = Player;

    }

    // Update is called once per frame
    void Update()//로티: 받아놓은 object들의 transform.position.y값을 이용하여 버블정렬하여 Ranking을 구현
    {
        for (int i = 0; i < AI_Rank.Length - 1; i++)
        {
            if (AI_Rank[i].transform.position.y > AI_Rank[i + 1].transform.position.y)
            {
                Temp = AI_Rank[i + 1];
                AI_Rank[i + 1] = AI_Rank[i];
                AI_Rank[i] = Temp;
                Temp = null;
            }
        }
    }


}
