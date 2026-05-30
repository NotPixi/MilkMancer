using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject howToPlayPanel;

    public void OpenHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        howToPlayPanel.SetActive(false);
    }
}