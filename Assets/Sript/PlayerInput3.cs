using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myval = Input.GetAxis("Mouse Y");
        if(mxVal != 0)
            print("Mouse X movement selected" + mxVal);
        if(myval != 0)
            print("Mouse Y movement selected" + myval);

    }
}
