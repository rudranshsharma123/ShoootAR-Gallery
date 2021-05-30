using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuGameManager : MonoBehaviour
{
    // public GameObject gameOverPanel;
    // public GameObject youWonPanel;


    // Start is called before the first frame update

    // public GameObject startPanel;
    // public GameObject gamePanel;
    
    // public AutoSpawaner spawaner;
    // public GameObject uiPanel;
    public GameObject mainMenuPanel;
    public GameObject levelInfoPanel;
    public GameObject aboutDevPanel;

    private void Awake(){
        aboutDevPanel.SetActive(false);
        levelInfoPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
        
        // gameOverPanel.SetActive(false);
        // youWonPanel.SetActive(false);
        // uiPanel.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        // uiPanel.SetActive(false);
        // spawaner.ChnagePlane();
        
    }
    public void AboutDev(){
        mainMenuPanel.SetActive(false);
        aboutDevPanel.SetActive(true);

    }
    public void Gallery(){
        SceneManager.LoadScene("Gallery");
    }
     public void LevelInfo(){
        mainMenuPanel.SetActive(false);
        levelInfoPanel.SetActive(true);
        
    }
    public void GoBack(){
    aboutDevPanel.SetActive(false);
    levelInfoPanel.SetActive(false);
    mainMenuPanel.SetActive(true);

    }



    // public void YouWon(){
    //     youWonPanel.SetActive(true);
    //     uiPanel.SetActive(false);

    //     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    // }

    // public void YouLost(){
    //     gameOverPanel.SetActive(true);
    // }

    // public void RestartGame(){
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }

    
    // public void AddScore(){
    //     return;
    // }

    public void GoToTraining(){
        SceneManager.LoadScene("Training");
    }
    public void GoBackToHome(){
        SceneManager.LoadScene(0);
    }


    public void QuitGame(){
        Application.Quit();
    }
    

    void Start()
    {
    // spawaner = GetComponent<AutoSpawaner>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
