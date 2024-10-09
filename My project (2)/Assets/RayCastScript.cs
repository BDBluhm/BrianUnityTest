using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    public Camera cam;
    public float rayDistance = 100f;
    public Color hitColor = Color.red;
    private GameObject lastHitObject;


    // Start is called before the first frame update
    void Start()
    {    // Update is called once per frame


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                if (lastHitObject != null)
                {
                    lastHitObject.GetComponent<Renderer>().material.color = Color.white;
                }

                hit.collider.gameObject.GetComponent<Renderer>().material.color = hitColor;
                lastHitObject = hit.collider.gameObject;
            }
        }
    }
}
