using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Ganti "Level1" dengan nama scene Anda yang ingin dimuat
        SceneManager.LoadScene("Level1");
    }

    public void ExitApp()
    {
        // Keluar dari aplikasi
        Application.Quit();

        // Debug untuk editor (tidak akan keluar di editor, hanya berfungsi di build)
        Debug.Log("Game Exited!");
    }
}