using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject authorsPanel;
    public void StartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void AuthorsButton()
    {
        mainPanel.SetActive(false);
        authorsPanel.SetActive(true);
    }

    public void ReturnButton()
    {
        mainPanel.SetActive(true);
        authorsPanel.SetActive(false);
    }
}
