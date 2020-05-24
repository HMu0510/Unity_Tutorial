using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    //[SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject go_BulletPrefab;


    private float createTime = 1f;
    private float currentCreateTime;

    // Update is called once per frame
    void Update()
    {

        Collider[] col = Physics.OverlapSphere(transform.position, 5f);

        if(col.Length >0)
        {
            for(int i = 0; i < col.Length; i++)
            {
                Transform if_Target = col[i].transform;

                if(if_Target.tag == "Player")
                {
                    Quaternion rotation = Quaternion.LookRotation(if_Target.position - this.transform.position);
                    transform.rotation = rotation;
                    //transform.rotation = Quaternion.LookRotation(if_Target.position - this.transform.position);
                    currentCreateTime += Time.deltaTime;
                    if (currentCreateTime >= createTime)
                    {
                        GameObject _temp = Instantiate(go_BulletPrefab, transform.position,rotation);
                        Physics.IgnoreCollision(_temp.GetComponent<Collider>(), if_Target.GetComponent<Collider>());
                        currentCreateTime = 0;
                    }
                }
            }
        }
        //currentCreateTime += Time.deltaTime;
        //if (currentCreateTime >= createTime)
        //{
        //    currentCreateTime = 0;
          //
          //  RaycastHit hitInfo;
          //
          //  if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 10f))
          //  //if(Physics.Raycast(this.transform.position,this.transform.forward,out hitInfo,10f,layerMask))
          //  {
          //      if (hitInfo.transform.tag == "Player")
          //      {
          //          Instantiate(go_BulletPrefab, transform.position, Quaternion.LookRotation(hitInfo.transform.position - transform.position));
          //      }
          //      //Debug.Log(hitInfo.transform.name);
          //  }
        //}
    }
}
