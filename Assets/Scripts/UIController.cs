using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;
    [SerializeField] GameObject _winnerPanel;
    [SerializeField] GameObject[] _livesImages;
    [SerializeField] Text _gameTimeText;
    public void ActivePanel(FinishGameStateEnum optionSelect, float gameTime = 0)
    {
        if (optionSelect.ToString() == "WIN")
        {
            _winnerPanel.SetActive(true);
            _gameTimeText.text = string.Format("Tiempo final: {0} seconds", Math.Floor(gameTime));
        } else
        {
            _losePanel.SetActive(true);
        }
        
        
    }

    public void Restart()
    {
        Debug.Log("Reiniciando el juego");
        SceneManager.LoadScene("Game");
    }

    public void GoToMainMenu()
    {
        Debug.Log("Ir al inicio de juego");
        SceneManager.LoadScene("MainMenu");
    }

    public void UpdateUILives(byte playerLives)
    {
        Debug.Log("Vidas: " + playerLives);
        for(int i = 0; i < _livesImages.Length; i++) 
        {
            if (i >= playerLives )
            {
                _livesImages[i].SetActive(false);
            }
        }
    }
}
