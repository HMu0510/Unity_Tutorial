using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    [SerializeField]
    private GameObject go_camera;
    //Vector3 rotation;

    private void Start()
    {
        //rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        if(Input.GetKey(KeyCode.W))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;//60 분의 1
            //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); //직접수정방법
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;
            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime); 매서드를 이용해서

            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = new Quaternion.Euler(rotation); Euler가 없다

            //짐벌락 현상(한축 90면 다른축 맛가는거 - Quaternion은 그게없다)

            //this.transform.localScale = this.transform.localScale + new Vector3(2,2,2) * Time.deltaTime;//크기조정
            //this.transform.forward * Time.deltaTime; //정규화 벡터(방향만들 알려주는 녀석(new Vector(0,0,1);
            //up,left,right 등등

            //this.transform.LookAt(go_camera.transform.position);
            //Debug.Log(transform.eulerAngles);
        }
       
    }
}
