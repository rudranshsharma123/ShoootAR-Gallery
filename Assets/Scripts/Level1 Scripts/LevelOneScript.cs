using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class LevelOneScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject placementObject;
    private Camera arCamera;
    public ARPlaneManager arPlaneManager;
    public GameObject placePrefab;
    // private ARPlaneManager arPlane;
    public TMP_Text timer;
        public TMP_Text score;

    public GameManager gm;
    public ARSession session;
    private List<Transform> pointsToSpawn = new List<Transform>();
    private int numberOfPoints;
    private void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
        gm = gm.GetComponent<GameManager>();
        
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
        session.enabled = true;
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
            Destroy(newObj, 10.0f);
            count+=1;

        }

    }




    float beg = 0f;
    public void StartTheTimer(){
        startTimer = true;
        // return (Time.time).ToString();
        beg = Time.time;

    }

    float time = 10.0f;
   
    private bool startTimer = false;
    // Update is called once per frame
    private void Update()
    {
    //  
    if(startTimer)
    {
    // string beg = StartTheTimer();
//     float begi = 0f;
//     float.TryParse(beg, out begi);
int n;
    int.TryParse(score.text, out n); 
    if(n > count-1){
        // timer.text = "YAAAS";
        gm.YouWon();
    }
    else if( (Time.time - beg) > time){
        // timer.text = "you lost";
        gm.YouLost();
        
    }
    
        else{timer.text = (Time.time - beg).ToString();}
    

    }
    // if(time> Time.time){
    //     if(n >= count){
    //         SceneManager.LoadScene(1); 
    //     }
    //     timer.text = (time-Time.timeSinceLevelLoad).ToString();


    // }
    

    
    }
}
