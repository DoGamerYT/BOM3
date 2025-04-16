using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetTrigger("start walking");
            ani.ResetTrigger("stop walking");
            ani.ResetTrigger("Walk Backwards");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetTrigger("stop walking");
            ani.ResetTrigger("Walk Backwards");
            ani.ResetTrigger("start walking");
        }
        else
        {
            ani.SetTrigger("stop walking");
            ani.ResetTrigger("start walking");
            ani.ResetTrigger("stop walking");
        }
    }

}
