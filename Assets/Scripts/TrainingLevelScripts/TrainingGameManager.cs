using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingGameManager : MonoBehaviour
{
    // Start is called before the first frame update
 


    // public GameObject gameOverPanel;
    // public GameObject youWonPanel;


    // Start is called before the first frame update

    // public GameObject startPanel;
    // public GameObject gamePanel;
    
    // public AutoSpawaner spawaner;
    public GameObject uiPanel;
    public GameObject backButton;

    private void Awake(){
        // gameOverPanel.SetActive(false);
        // youWonPanel.SetActive(false);
        uiPanel.SetActive(true);
        backButton.SetActive(false);
    }
    public void StartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        uiPanel.SetActive(false);
        backButton.SetActive(true);
        // spawaner.ChnagePlane();
        
    }

    
    // public void YouWon(){
    //     youWonPanel.SetActive(true);
    //     uiPanel.SetActive(false);

    //     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    // }
    // public void LevelUp(){
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    // // }
    // public void YouLost(){
    //     gameOverPanel.SetActive(true);
    // }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    // public void AddScore(){
    //     return;
    // }

    // public void GoToTraining(){
    //     SceneManager.LoadScene(1);
    // }
    public void GoBackToHome(){
        SceneManager.LoadScene(0);
    }
    public void GoBack(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
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

