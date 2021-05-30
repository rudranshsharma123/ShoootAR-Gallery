using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GalleryScript : MonoBehaviour
{
    // Start is called before the first frame update




    // Start is called before the first frame update
    [SerializeField] ARRaycastManager m_RaycastManager; 
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>(); 
    [SerializeField] 
    GameObject[] prefabs;
    [SerializeField] 
    ARPlaneManager manager;
    GameObject spawnablePrefab; 
    Camera arCam; 
    GameObject spawnedObject;

    private void Start(){
        spawnedObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        manager.enabled = false;
        }

    public void one(){
        spawnablePrefab = prefabs[0];
    }
  public void two(){
        spawnablePrefab = prefabs[1];
    }public void three(){
        spawnablePrefab = prefabs[2];
    }public void four(){
        spawnablePrefab = prefabs[3];
    }  
    public void five(){
        spawnablePrefab = prefabs[4];
    }
    public void six(){
        spawnablePrefab = prefabs[5];
    }
    public void seven(){
        spawnablePrefab = prefabs[6];
    }
    public void eight(){
        spawnablePrefab = prefabs[7];
    }
    private void Update()
    {
        if (Input.touchCount == 0){
            return;
        }
        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

        if(m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits)){
            if(Input.GetTouch(0).phase == TouchPhase.Began){
                if (Physics.Raycast(ray, out hit)){
                    if (hit.collider.gameObject.tag == "Target"){
                        spawnedObject = hit.collider.gameObject;
                    }
                    else{
                        SpawnPrefab(m_Hits[0].pose.position);
                    }

                }

            }
            else if(Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject != null){
                spawnedObject.transform.position = m_Hits[0].pose.position;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended){
                spawnedObject = null;
            }

        }



    }

    private void SpawnPrefab(Vector3 position)
    {
        spawnedObject = Instantiate(spawnablePrefab, position, Quaternion.identity);
    }
}


