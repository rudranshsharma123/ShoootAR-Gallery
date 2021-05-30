using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
public class TrainingScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject placementObject;
    private Camera arCamera;
    public ARPlaneManager arPlaneManager;
    public GameObject placePrefab;
    // private ARPlaneManager arPlane;
    public ARSession session;
    private List<Transform> pointsToSpawn = new List<Transform>();
    private int numberOfPoints;
    public TMP_Text score;
    private void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
        // session = GetComponent<ARSession>();
        // session.enabled = false;
        // ChnagePlane();
    }
     public void ChnagePlane(){
        arPlaneManager.enabled = !arPlaneManager.enabled;
        foreach (ARPlane plane in arPlaneManager.trackables){
            plane.gameObject.SetActive(plane.enabled);
        }
        }

    public void BeginSession(){
        arPlaneManager.enabled = true;
        // return;
    }
    private void PlaneChanged( ARPlanesChangedEventArgs args)
    {
       
        if (args.added != null)
        {
            int n = args.added.Count;
            for (int i = 0; i < n; i++)
            {
                if (i > 10){
                    break;
                }
                ARPlane arplane = args.added[i];
                pointsToSpawn.Add(arplane.transform);
                // Instantiate(placePrefab, arplane.transform.position, Quaternion.identity);
                numberOfPoints++;
            }



        }
        
    }
    int count = 0;
    public void addSpawns(){
        foreach(var i in pointsToSpawn){
            GameObject newObj =  Instantiate(placePrefab, i.position, Quaternion.identity);
            // Destroy(newObj, 10.0f);
            count+=1;
        }

    }
    bool start = false;
    public void RemovePlanes(){
        start = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int n;
        int.TryParse(score.text, out n);
        if ((n>count-1 )&& (start)){
            addSpawns();
            
        }
    //    addSpawns();
        
    }
}
