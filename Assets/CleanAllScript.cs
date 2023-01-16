using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanAllScript : MonoBehaviour
{
    public GameObject level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DelAll()
    {
        Debug.Log(level);
        foreach (Transform child in level.transform)
        {
            if (child.gameObject.name == "ContaminationPin2(Clone)" || child.gameObject.name == "SpawnPin2(Clone)"|| child.gameObject.name == "ThrowablePin2(Clone)")
            {

                Destroy(child.gameObject);
            }
        }
    }
}
