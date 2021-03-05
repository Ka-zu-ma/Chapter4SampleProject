using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    public Transform centerEyeAnchor;
    // Start is called before the first frame update
    //void Start(){
    //}

    // Update is called once per frame
    void Update(){
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        ray = new Ray(centerEyeAnchor.position, centerEyeAnchor.forward);

        if (Physics.Raycast(ray, out hit)) {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground) {
                Debug.Log("HIt(x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }
    }
}
