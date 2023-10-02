using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBIK : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CUBISHE;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActiveObject()
    {
        if(CUBISHE.activeSelf != true)
        {
            CUBISHE.SetActive(true);
        }
        else
        {
            CUBISHE.SetActive(false);
        }
    }
}
