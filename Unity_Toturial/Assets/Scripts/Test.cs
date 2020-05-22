using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject go_camera;

    //Vector3 rotation;
    //private void Start()
    //{
    //    rotation = this.transform.eulerAngles;
    //}

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //Debug.Log(transform.eulerAngles);

            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = Quaternion.Euler(rotation);


            //moveSpeed * this.transform.forward * Time.deltaTime;

            //this.transform.transform.LookAt(go_camera.transform.position);
            
        }
    }
}
