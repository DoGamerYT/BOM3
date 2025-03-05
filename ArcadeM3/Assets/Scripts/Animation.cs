using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Animator.SetTrigger("start walking");

            //m_Animator.ResetTrigger("start walking");

            m_Animator.ResetTrigger("stop walking");

        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            m_Animator.SetTrigger("stop walking");

            //m_Animator.ResetTrigger("stop walking");

            m_Animator.ResetTrigger("start walking");
        }
      
    }

}
