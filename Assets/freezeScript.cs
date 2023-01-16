using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class freezeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //VuforiaBehaviour.Instance.enabled = !GetComponent<Toggle>().isOn;

    }

    public void FreezeFunction()
    {
        if (GetComponent<Toggle>().isOn == true)
        {
            VuforiaBehaviour.Instance.enabled = false;
        }
        if (GetComponent<Toggle>().isOn == false)
        {
            VuforiaBehaviour.Instance.enabled = true;
        }
    }
}
