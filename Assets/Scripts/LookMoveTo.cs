using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        //元々は、Transform camera = Camera.main.transform;
        Camera camera = GetComponent<OVRCameraRig>().leftEyeCamera;
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        Debug.DrawRay(camera.transform.position, camera.transform.rotation * Vector3.forward * 100.0f);

        ray = new Ray(camera.transform.position, camera.transform.rotation * Vector3.forward);

        if (Physics.Raycast(ray, out hit)) {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground) {
                Debug.Log("HIt(x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }
    }
}
