using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;
    [SerializeField] GameObject _winnerPanel;
    public void ActivePanel(FinishGameStateEnum optionSelect)
    {
        _winnerPanel.SetActive(optionSelect.ToString() == "WIN");
        _losePanel.SetActive(optionSelect.ToString() == "LOSE");
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
}
