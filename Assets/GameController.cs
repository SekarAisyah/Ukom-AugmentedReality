using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject PanelInfo;
    public AudioSource PlaySound;

    private bool show = false;
    private bool isPlaying = false;

    public void ShowHideInfo()
    {
        if (!show)
        {
            PanelInfo.SetActive(true);
            show = true;
        }
        else
        {
            PanelInfo.SetActive(false);
            show = false;
        }

        // Jika audio sedang diputar, hentikan saat menampilkan/menyembunyikan info
        if (isPlaying)
        {
            StopAudio();
        }
    }

    public void BackHideInfo()
    {
        if (!show)
        {
            PanelInfo.SetActive(false);
            show = true;
        }
        else
        {
            PanelInfo.SetActive(true);
            show = false;
        }

        // Jika audio sedang diputar, hentikan saat menampilkan/menyembunyikan info
        if (isPlaying)
        {
            StopAudio();
        }
    }

    public void BackToMainMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void PlayStopAudio()
    {
        if (isPlaying)
        {
            StopAudio();
        }
        else
        {
            PlayAudio();
        }
    }

    private void PlayAudio()
    {
        PlaySound.Play();
        isPlaying = true;
    }

    private void StopAudio()
    {
        PlaySound.Stop();
        isPlaying = false;
    }
}
