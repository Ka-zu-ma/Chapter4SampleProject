using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    public Transform centerEyeAnchor;
    RaycastHit[] hits;

    // Update is called once per frame
    void Update(){
        Ray ray;
        GameObject hitObject;

        ray = new Ray(centerEyeAnchor.position, centerEyeAnchor.forward);
        hits = Physics.RaycastAll(ray);

        for (int i = 0; i < hits.Length; i++) {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;
            if (hitObject == ground) {
                Debug.Log("HIt(x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }
    }
}
