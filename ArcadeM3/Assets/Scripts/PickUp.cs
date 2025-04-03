using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
