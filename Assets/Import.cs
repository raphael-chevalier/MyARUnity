using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Import : MonoBehaviour
{
    public GameObject level;
    public GameObject groundPlane;
    public GameObject prefabThrowablePin;
    public GameObject prefabSpawnPin;
    public GameObject prefabContaminatioPin;
    public TextMeshProUGUI TextInput;




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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImportFonction()
    {
        Debug.Log("tessssssssssssssssssssssssssssss");
        //string chemin = Application.streamingAssetsPath + "/Pins.json";
        string chemin = "D:/Cesi/projetRARv/ARVR/adelete/ARProjetFPS2/Assets/"+TextInput.text+".json";
        string jsonString = File.ReadAllText(chemin);

        Debug.Log(jsonString);

        ListPin jsonData = JsonUtility.FromJson<ListPin>(jsonString);


        foreach (Transform child in level.transform)
        {
            if (child.gameObject.name == "ContaminationPin2(Clone)" || child.gameObject.name == "SpawnPin2(Clone)" || child.gameObject.name == "ThrowablePin2(Clone)")
            {
                Destroy(child.gameObject);
            }
        }

        foreach (var pin in jsonData.Pins)
        {
            Debug.Log(pin.V3);

            Debug.Log(pin.leType);
            if (pin.leType== "ContaminationPin2")
            {
                var newPin = Instantiate(prefabContaminatioPin, pin.V3, Quaternion.identity);
                newPin.transform.parent = groundPlane.transform;
                newPin.transform.localPosition = pin.V3;
                Debug.Log("Je créé un pin contamination");

            }
            else if (pin.leType == "SpawnPin2")
            {
                var newPin = Instantiate(prefabSpawnPin, pin.V3, Quaternion.identity);
                newPin.transform.parent = groundPlane.transform;
                newPin.transform.localPosition = pin.V3;

                Debug.Log("Je créé un pin spawn");

            }
            else if (pin.leType == "ThrowablePin2")
            {
                var newPin = Instantiate(prefabThrowablePin, pin.V3, Quaternion.identity);
                newPin.transform.parent = groundPlane.transform;
                newPin.transform.localPosition = pin.V3;

                Debug.Log("Je créé un pin throwable");

            }
            //var pin = Instantiate(prefabPin, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
            //pin.transform.parent = groundPlane.transform;

        }
    }
}
