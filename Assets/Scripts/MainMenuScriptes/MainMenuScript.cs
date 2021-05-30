using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ARSession session;
    public ARPlaneManager manager;
    void Awake(){
        manager.enabled=false;
    }
    void Start()
    {
        
    }

    public void BeginSession(){
        session.enabled = true;
        manager.enabled = true;
        // return;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
