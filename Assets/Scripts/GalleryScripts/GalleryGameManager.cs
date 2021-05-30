using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class GalleryGameManager : MonoBehaviour
{
    




    // public GameObject gameOverPanel;
    // public GameObject youWonPanel;


    // Start is called before the first frame update

    // public GameObject startPanel;
    // public GameObject gamePanel;
    
    // public AutoSpawaner spawaner;
    public GameObject uiPanel;
    public ARSession session;
    public GameObject goBackButton;

    public ARPlaneManager manager;
    private void Awake(){
        // gameOverPanel.SetActive(false);
        // youWonPanel.SetActive(false);
        uiPanel.SetActive(true);
        goBackButton.SetActive(false);

        // session.enabled = false;
    }
    // public void StartGame()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    //     uiPanel.SetActive(false);
    //     // spawaner.ChnagePlane();
        
    // }

public void BeginGame(){
    uiPanel.SetActive(false);
    goBackButton.SetActive(true);
    session.enabled = true;
    manager.enabled = true;
}
    
public void GoBack(){
//     uiPanel.SetActive(true);
//     goBackButton.SetActive(false);
//   foreach (ARPlane plane in manager.trackables){
//             plane.gameObject.SetActive(false);
//         }
//     manager.enabled = false;
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
   public void GoBackToHome(){
        SceneManager.LoadScene(0);
    }


    
    // public void YouLost(){
    //     gameOverPanel.SetActive(true);
    // }

    // public void RestartGame(){
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }

    
    // public void AddScore(){
    //     return;
    // }

    // public void GoToTraining(){
    //     SceneManager.LoadScene(1);
    // }
 
    // public void QuitGame(){
    //     Application.Quit();
    // }
    

    void Start()
    {
    // spawaner = GetComponent<AutoSpawaner>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
