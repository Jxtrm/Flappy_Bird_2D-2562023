using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour
{
    public static Menu_Control intance;
    [SerializeField] private TMP_Text points;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject pointsObject;
    [SerializeField] private GameObject gameOverPanel;
    private int score = 0;
    public bool gameStarted = false;
    
    void Start()
    {
        if (intance == null)
        {
            intance = this;
        }
    }
    public void SumarPuntacion()
    {
        score++;
        points.text = score.ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
        startPanel.SetActive(false);
        pointsObject.SetActive(true);
    }

    public void GameStop()
    {
        gameStarted = false;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        applicantion.Quit();
        #endif
    }
}
