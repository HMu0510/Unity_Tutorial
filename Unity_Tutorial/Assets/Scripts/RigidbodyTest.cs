using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    //[SerializeField]
    private Rigidbody myRigid;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //myRigid.velocity = new Vector3(0, 0, 1); // 앞으로나가는거
            //myRigid.velocity = Vector3.forward;
            //myRigid.angularVelocity = new Vector3(1, 0, 0);//오른쪽 회전
            //myRigid.angularVelocity = Vector3.right;
            //myRigid.mass = 2f;//질량
            //myRigid.drag = 2f;//저항
            //myRigid.maxAngularVelocity = 100;// 제한 해제
            //myRigid.angularVelocity = Vector3.right * 100;
            //myRigid.useGravity = false;

            //강제이동회전 관성무시
            //myRigid.MovePosition(transform.forward * Time.deltaTime);
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));

            //관성 영향받음
            ///myRigid.AddForce(Vector3.forward);

            //myRigid.AddTorque(Vector3.up);

            //폭발효과
            //myRigid.AddExplosionForce(10.0f, transform.right, 10.0f);
        }
    }
}
