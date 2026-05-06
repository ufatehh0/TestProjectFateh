using UnityEngine;

public class EventListener : MonoBehaviour
{
    private void OnEnable()
    {
      
        UIButtonTrigger.OnStartPressed += StartTheGame;
        UIButtonTrigger.OnSettingsPressed += OpenSettings;
        UIButtonTrigger.OnExitPressed += ExitGame;
    }

    private void OnDisable()
    {
        
        UIButtonTrigger.OnStartPressed -= StartTheGame;
        UIButtonTrigger.OnSettingsPressed -= OpenSettings;
        UIButtonTrigger.OnExitPressed -= ExitGame;
    }

    void StartTheGame()
    {
        Debug.Log("Start Game");
    }

    void OpenSettings()
    {
        Debug.Log("Settings");
    }
    void ExitGame()
    {
        Debug.Log("Exit Game");
    }
}