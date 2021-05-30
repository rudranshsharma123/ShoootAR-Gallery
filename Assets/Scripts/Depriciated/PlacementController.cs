using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


[RequireComponent(typeof(ARRaycastManager))]
public class PlacementController : MonoBehaviour
{

    [SerializeField]
    private GameObject placedPrefab;

    private ARPlaneManager aRPlane;
    
   
    public GameObject PlacedPrefab
    {
        get
        {
            return placedPrefab;
        }
        set
        {
            placedPrefab = value;
        }
    }
    private List<Transform> pointsToSpawn = new List<Transform>();
    private int numberOfPoints;
  private void PlaneChanged( ARPlanesChangedEventArgs args)
    {
       
        if (args.added != null)
        {
            int n = args.added.Count;
            for (int i = 0; i < n; i++)
            {
                if (numberOfPoints > 10){
                    break;
                }
                ARPlane arplane = args.added[i];
                pointsToSpawn.Add(arplane.transform);
                // Instantiate(placePrefab, arplane.transform.position, Quaternion.identity);
                numberOfPoints++;
            }



        }
        
    }

    public void addSpawns(){
        foreach(var i in pointsToSpawn){
            Instantiate(placedPrefab, i.position, Quaternion.identity);
        }
    }

    private ARRaycastManager arRaycastManager;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        aRPlane = GetComponent<ARPlaneManager>();
        // arPlaneManager = GetComponent<ARPlaneManager>();
        aRPlane.planesChanged += PlaneChanged;
    }
    public void ChnagePlane(){
        aRPlane.enabled = !aRPlane.enabled;
        foreach (ARPlane plane in aRPlane.trackables){
            plane.gameObject.SetActive(aRPlane.enabled);
        }

    }
    void Update()
    {
        // if (Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);

        //     Vector2 touchPosition = touch.position;

        //     if (touch.phase == TouchPhase.Began)
        //     {
              

        //         if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        //         {
        //             var hitPose = hits[0].pose;
        //             Instantiate(placedPrefab, hitPose.position, hitPose.rotation);

                 
                   
        //         }
        //     }
        // }
    }

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
