using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
public class TrainingShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arCamera;
    public TMP_Text text;
        // public TMP_Text cnt;

    public GameObject tobeSpawaned;
    public GameObject smoke;
    // public ARPlaneManager aRPlane;
    private AutoSpawaner autoSpawaner;
    
    Transform place;
    private List<GameObject> objs = new List<GameObject>();
    private List<Transform> pointsToSpawn = new List<Transform>();

    
    public void Shooot()
    {
        int score;
        RaycastHit hit; 
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon3(Clone)" || hit.transform.name == "balloon2(Clone)")
            {
                objs.Add(hit.transform.gameObject);
                place = hit.transform;
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                int.TryParse(text.text, out score);
                text.text = (score+1).ToString();
                
            
                // Invoke("Add", 1.0f);
                
                // StartCoroutine(Spawn());
                // Instantiate(temp, pos, Quaternion.identity);

            }
        }
        
    }

    private void Add(){
        Instantiate(tobeSpawaned, place.position, Quaternion.identity );
        // autoSpawaner.addSpawns();
    }

private void awake(){
    autoSpawaner = GetComponent<AutoSpawaner>();

}
    IEnumerator Spawn(){
        // Instantiate(tobeSpawaned, place.position, Quaternion.identity );

        yield return new WaitForSecondsRealtime(5.0f);
        

    }
    // Update is called once per frame

private void Update(){
    // int n;
    // cnt.text = (objs[0].gameObject.name).ToString();
    // int.TryParse(text.text, out n);
    // 
    // int.TryParse(cnt.text, out n);
    // cnt.text = count.ToString();


}

}

