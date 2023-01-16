using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Export : MonoBehaviour
{

    public GameObject level;
    public TextMeshProUGUI TextInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ExportFunction()
    {
        ListPin listPin = new ListPin();


        foreach (Transform child in level.transform)
        {
            if (child.gameObject.name == "ContaminationPin2(Clone)" || child.gameObject.name == "SpawnPin2(Clone)" || child.gameObject.name == "ThrowablePin2(Clone)")
            {
                PinPrefab pin2 = new PinPrefab();
                //pin2.material = child.gameObject.GetComponent<Material>();
                if (child.gameObject.name == "ContaminationPin2(Clone)"){
                    pin2.leType = "ContaminationPin2";
                }
                else if (child.gameObject.name == "SpawnPin2(Clone)")
                {
                    pin2.leType = "SpawnPin2";
                }
                else if (child.gameObject.name == "ThrowablePin2(Clone)")
                {
                    pin2.leType = "ThrowablePin2";
                }
                //pin2.material = child.gameObject.GetComponent<Material>();
                pin2.V3 = child.transform.localPosition;
                listPin.Pins.Add(pin2);

            }
        }
        string strOutput = JsonUtility.ToJson(listPin);
        Debug.Log(strOutput);
        Debug.Log(TextInput.text);

            Debug.Log("eeeeeeeeeeee");
            File.WriteAllText(Application.dataPath +"/"+ TextInput.text + ".json", strOutput);
        



        //File.WriteAllText(Application.dataPath + "/Pins.json", strOutput);


        //jsonPin.type = 1;
        //Debug.Log(jsonPin.type);
        //string strOutput = JsonUtility.ToJson(jsonPin);
        //Debug.Log(strOutput);
        //File.WriteAllText(Application.dataPath + "/text.json", strOutput);
    }

    [System.Serializable]
    public class PinPrefab
    {
        public Vector3 V3;
        public string leType;
        //public GameObject gameObject;
        //public Material material;
    }

    [System.Serializable]
    private class ListPin
    {
        public List<PinPrefab> Pins = new List<PinPrefab>();
    }

}


