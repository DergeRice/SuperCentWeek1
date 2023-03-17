using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class AIManager : MonoBehaviour
// {
//     [Header("Object")]
//     [SerializeField] public Transform[] Gatelist; // 미치 : 게이트 리스트. 인스펙터 창에서 직접 추가해도 되고 추가하지 않았다면 Gate오브젝트 안에 있는 모든 오브젝트의 Transform을 가져옴 
//     [SerializeField] public Transform[] GoalPoint; // 미치 : 최종 목적지. 아래에 남은 게이트가 없다면 최종 목적지를 타겟으로 잡음
//     [SerializeField] GameObject Player;
//     [SerializeField] public Animator Anim;

//     [SerializeField] Rigidbody[] _rigidbodys;
//     [SerializeField] Collider[] _colliders;


//     [Header("State")]
//     [SerializeField] float speed = 5.0f; // 이동 속도
//     [SerializeField] float A,B,C,D;

//     public bool IsRace = false; // 미치 : true일 경우 Update가 실행되며 AI작동

     
//     Transform target;


//     void Start()
//     {
//         speed =Random.Range(18f,23f);
//         _rigidbodys = GetComponentsInChildren<Rigidbody>();
//         _colliders = GetComponentsInChildren<Collider>();

//         Set_Ragdoll(false);

//         if (GoalPoint.Length == 0) GoalPoint = GameObject.Find("GoalPoints").GetComponentsInChildren<Transform>();

//         GameObject obj = GameObject.Find("Gates");
//         Gatelist = new Transform[obj.transform.childCount];

//         for (int i = 0; i < obj.transform.childCount; i++) { Gatelist[i] = obj.transform.GetChild(i).transform; }

//         target = Gatelist[Random.Range(1, Gatelist.Length)];

//         InvokeRepeating(nameof(TooLateCheck),4f,1f);        
//     }

//     void Update()
//     {
//         if (!IsRace) return;

//         if (transform.position.y - target.position.y < 1f) FindNextTarget(); // 미치 : 거리가 가깝다면 다음 타겟

//         // if (Player.transform.position.y - transform.position.y > 20f)//로티: AI가 플레이어보다 30만큼 앞설 경우
//         // {
//         //     if (Player.GetComponent<PlayerController>().isDie == false)
//         //     {
//         //         speed = Mathf.Lerp(speed,Random.Range(A,B),Time.deltaTime); //미치 X배로 빨리감소
//         //     }
//         // }

//         //else speed += Random.Range(2f,4f) * Time.deltaTime; //상한선


//         if(Player.transform.position.y - transform.position.y < 0f)// 로티: AI가 플레이어보다 30만큼 뒤쳐 질 경우//AI가 역전할수 없을 정도라면
//         {
//             if (Player.GetComponent<PlayerController>().isDie == false)
//             {
//                 speed = transform.position.y - Player.transform.position.y * D;
//             }
//         }

//         transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime); // 타겟을 향해 이동

//         AI_Rotate();
//         ResetRotation();
//     }

//     void AI_Rotate()
//     {
//         float RotateFactor = target.transform.position.x - transform.position.x;
//         if (RotateFactor < 0)
//         {
//             transform.rotation = Quaternion.Lerp(transform.rotation,
//                             Quaternion.Euler(0, (-10.0f), 0), 5 * Time.deltaTime);
//         }
//         if (RotateFactor > 0)
//         {
//             transform.rotation = Quaternion.Lerp(transform.rotation,
//                             Quaternion.Euler(0, (10.0f), 0), 5 * Time.deltaTime);
//         }

//     }

//     void Set_Ragdoll(bool setbool)
//     {
//         Anim.enabled = !setbool;
//         for (int i = 0; i < _colliders.Length; i++)
//         {
//             _colliders[i].isTrigger = !setbool;
//         }
//         for (int i = 0; i < _rigidbodys.Length; i++)
//         {
//             _rigidbodys[i].isKinematic = !setbool;
//         }
//     }
//     private void ResetRotation()
//     {
//         float RotateFactor = target.transform.position.x - transform.position.x;
//         if (Mathf.Approximately(Mathf.Abs(RotateFactor), 0))
//         {
//             transform.rotation = Quaternion.Lerp(transform.rotation,
//                 Quaternion.Euler(0, 0, 0), 10 * Time.deltaTime);
//         }
//     }


//     // 미치 : 배열 중 랜덤으로 transform을 가져오고 현재 타겟보다 아래에 있다면 타겟으로 잡음. 남은 타켓이 없을 시 골포인트를 타겟으로 잡음
//     void FindNextTarget()
//     {
//         for (int i = 0; i < 30; i++)
//         {
//             int tmp = Random.Range(1, Gatelist.Length);

//             if (tmp != 0 && Gatelist[tmp].position.y < target.position.y)
//             {
//                 target = Gatelist[tmp];
//                 return;
//             }
//         }

//         target = GoalPoint[Random.Range(1, GoalPoint.Length)];
//         return;
//     }

//     void TooLateCheck(){
//         if(Player.transform.position.y - transform.position.y < -30f)//로티: AI가 플레이어보다 60만큼 뒤쳐 질 경우
//         {
//             // if (Player.GetComponent<PlayerController>().isDie == false)
//             // {
//             //     transform.position = new Vector3(transform.position.x, Player.transform.position.y + 25f, transform.position.z);
//             // }
            
//         }
//         speed = Mathf.Lerp(speed,Random.Range(A,B),Time.deltaTime); 
//     }
// }
