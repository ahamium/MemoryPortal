using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Rendering;

public class PortalDoor : MonoBehaviour
{
    // Start is called before the first frame update

    public Material[] PGMat;
    void Start()
    {
        //setting to equal to all materials when it starts
        foreach (Material mat in PGMat)
        {
            mat.SetInt("stest", (int)CompareFunction.Equal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collide)
    {
        //when maincamera is called
        if (collide.gameObject.CompareTag("MainCamera")) {

            //portaldoor > maincamera
            //outside : set equal
            if (transform.position.z > collide.transform.position.z)
            {
                foreach (Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.Equal);
                }
            }
            else {
                //inside : set notequal
                foreach (Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.NotEqual);
                }
            }
        }
    }



}
