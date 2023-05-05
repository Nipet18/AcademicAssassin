using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    // Variables to hold the previous scene's name and the main menu scene's name
    private string previousSceneName;
    private string mainSceneName = "ARPage";

    private void Start()
    {
        // Set the previous scene's name to the main menu scene
        previousSceneName = mainSceneName;
    }

    private void Update()
    {
        // Check for arrow key input and navigate to the appropriate scene
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (previousSceneName == mainSceneName)
            {
                GoToScene("VictimPage");
            }
            else if (previousSceneName == "VictimPage")
            {
                GoToScene(mainSceneName);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (previousSceneName == mainSceneName)
            {
                GoToScene("SuspectPage");
            }
            else if (previousSceneName == "SuspectPage")
            {
                GoToScene(mainSceneName);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (previousSceneName == mainSceneName)
            {
                GoToScene("MapPage");
            }
            else if (previousSceneName == "MapPage")
            {
                GoToScene(mainSceneName);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (previousSceneName == mainSceneName)
            {
                GoToScene("FilterPage");
            }
            else if (previousSceneName == "FilterPage")
            {
                GoToScene(mainSceneName);
            }
        }
    }

    // Function to change scenes and update the previous scene name
    void GoToScene(string sceneName)
    {
        // Set the current scene to the new scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        previousSceneName = SceneManager.GetActiveScene().name;
    }
}