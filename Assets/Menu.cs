using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject PanelMainMenu;
    public GameObject PanelCaraBermain;

    // Start is called before the first frame update
    void Start()
    {
        PanelMainMenu.SetActive(true);
        PanelCaraBermain.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        PanelMainMenu.SetActive(false);
        PanelCaraBermain.SetActive(true);
    }

    public void BackButton()
    {
        PanelMainMenu.SetActive(true);
        PanelCaraBermain.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
