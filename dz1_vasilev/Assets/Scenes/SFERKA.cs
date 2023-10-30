using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFERKA : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject SFERISHE;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActiveObject()
    {
        if (SFERISHE.activeSelf != true)
        {
            SFERISHE.SetActive(true);
        }
        else
        {
            SFERISHE.SetActive(false);
        }
    }
}
