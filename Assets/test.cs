using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public bool isChecked=false;
    public GameObject prefabPin;
    public GameObject groundPlane;
    private Plane plane;
    private Vector3 v3Offset;
    public Camera camera;
    private RaycastHit hitData;
    private RaycastHit hit;


    //public Toggle checkbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isChecked==true)
        {
            //Instantiate(prefabPin, groundPlane.transform);

            //Debug.Log("on clique");
            //Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            //float dist;
            //plane.Raycast(ray, out dist);
            //v3Offset = transform.position - ray.GetPoint(dist);
            //Debug.Log(v3Offset);
            //Instantiate(prefabPin, groundPlane.transform);
            ////Instantiate(prefabPin, Input.mousePosition);

            //Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            //float dist;
            //plane.Raycast(ray, out dist);
            //Vector3 v3Pos = ray.GetPoint(dist);
            //Vector3 lastPos = v3Pos + v3Offset;
            //transform.position = plane.ClosestPointOnPlane(lastPos);

            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.GetComponent<PlacementObject>())
            {
                Debug.Log(hit.transform.gameObject.name); 
                Debug.Log("jjjjjjjjjjjjj");
                Debug.Log(hit.transform);
                //Instantiate(prefabPin, hit.transform);
                //hit.point.x,hit.point.y,hit.point.z
                //hit.point;


                var pin = Instantiate(prefabPin, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                pin.transform.parent = groundPlane.transform;
                //Vector3 movement = new Vector3(x, 0, z);
                //pin.transform.
                //Instantiate(prefabPin, groundPlane.transform);
                // Do something with the object that was hit by the raycast.
            }

            else if ((Physics.Raycast(ray, out hit) && hit.transform.gameObject.name=="ContaminationPin")|| (Physics.Raycast(ray, out hit) && hit.transform.gameObject.name == "ThrowablePin") || (Physics.Raycast(ray, out hit) && hit.transform.gameObject.name == "SpawnPin"))
            {
                Destroy(hit.transform.gameObject);
            }

        }
        }

    public void debugLLL()
    {
        if (GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("test");
            isChecked = true;
        }
        if (GetComponent<Toggle>().isOn == false)
        {
            Debug.Log("test");
            isChecked = false;
        }
    }
}
