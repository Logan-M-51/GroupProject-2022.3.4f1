using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;

public class RayShooter : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();

    }

    private void OnGUI()
    {
        int size = 12;
        // This code is for Game View
           float posX = cam.pixelWidth / 2 - size / 4;
           float posY = cam.pixelHeight / 2 - size / 2;

        // This code is for VR view
     //   float posX = XRSettings.eyeTextureWidth / 2 - size / 4;
     //   float posY = XRSettings.eyeTextureHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "+");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
         //   Vector3 point = new Vector3(XRSettings.eyeTextureWidth / 2, XRSettings.eyeTextureHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                CodeView code = hitObject.GetComponent<CodeView>();
                if (code != null)
                {
                    code.ChangeView();

                } else
                {
                    StartCoroutine(SphereIndicator(hit.point));
                    Handheld.Vibrate();
                }
                
            }
        }
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }
}
