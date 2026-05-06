using UnityEngine;
using System; 

public class UIButtonTrigger : MonoBehaviour
{
    
    public static event Action OnStartPressed;
    public static event Action OnSettingsPressed;
    public static event Action OnExitPressed;

    public void TriggerStart()
    {
        
        OnStartPressed?.Invoke();
    }

    public void TriggerSettings()
    {
        OnSettingsPressed?.Invoke();
    }



    public void TriggerExit()
    {
        OnExitPressed?.Invoke();
    }
}