using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyContllor : MonoBehaviour
{
    private GameObject mycamera;

    private GameObject goal;

    // Start is called before the first frame update
    void Start()
    {
        this.mycamera = GameObject.Find("Main Camera");

        this.goal = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        if( this.transform.position.z < mycamera.transform.position.z || this.transform.position.z >= goal.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
   
}
