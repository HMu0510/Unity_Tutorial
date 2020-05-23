using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("col.bounds" + col.bounds);
            //Debug.Log("col.bounds.extents" + col.bounds.extents);
            //Debug.Log("col.bounds.extents.x" + col.bounds.extents.x);
            //Debug.Log("col.size" + col.size);
            //Debug.Log("col.center" + col.center);
        }
        //col.Raycast//레이저를 쏴서 쳌용 반환이 불임
        //if(Input.GetMouseButtonDown(0))//마우스 좌버튼 클릭 조건문
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo;
        //    if(col.Raycast(ray, out hitInfo, 1000))
        //    {
        //        this.transform.position = hitInfo.point;
        //    }
        //}

    }
    //영역으로 들어올때
    //private void OnTriggerEnter(Collider other)
    
      
    
    //영역에서 나갈때
    private void OnTriggerExit(Collider other)
    {
        other.transform.position += new Vector3(0, 1, 0);
    }
    //영역에 머무를때
    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.1f);
    }
    //실제 물리적인 충돌이일어났을떄
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
