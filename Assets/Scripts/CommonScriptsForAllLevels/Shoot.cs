using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arCamera;
    public TMP_Text text;
    public GameObject smoke;
    // public ARPlaneManager aRPlane;

    
    public void Shooot()
    {
        int score;
        RaycastHit hit; 
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon3(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.tag == "Target" || hit.transform.name == "wine bottle 04(Clone)"|| hit.transform.name == "Bottle(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                int.TryParse(text.text, out score);
                text.text = (score+1).ToString();
            }
        }
        
    }

    // Update is called once per frame
}

