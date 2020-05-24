using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class Test : MonoBehaviour
{
   // private AudioSource theAudio;
   //
   // [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject go_BulletPrefab;
    private float createTime = 1f;
    private float currentCreateTime = 0;
   //
   //
   //
   // void Start()
   // {
   // }

    void Update()
    {
      currentCreateTime += Time.deltaTime;



        Collider[] col = Physics.OverlapSphere(transform.position, 5f);

        if(col.Length >0)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Transform tf_Target = col[i].transform;
                if (tf_Target.tag == "Player")
                {
                    Quaternion rotation = Quaternion.LookRotation(tf_Target.position - this.transform.position);
                    transform.rotation = rotation;

                    if (currentCreateTime >= createTime)
                    {
                        //    currentCreateTime = 0f;
                        //    RaycastHit hitInfo;
                        //    if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 10f , layerMask))
                        //    {
                        //        if (hitInfo.transform.tag == "Player")
                        //        {
                        Instantiate(go_BulletPrefab, transform.position, rotation);
                        currentCreateTime = 0;


                        //GameObject _temp = Instantiate(go_BulletPrefab, transform.position, rotation);
                        //Physics.IgnoreCollision(_temp.GetComponent<Collider>(), tf_Target.GetComponent<Collider>());
                        //currentCreateTime = 0;
                        //        }
                        //    }
                    }
                }
            }
        }
    }


}
