using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Functionality : MonoBehaviour
{

    private Button currentButton;

    public int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GetComponent<Button>();
        currentButton.onClick.AddListener(PerformAction);
    }

    void PerformAction()
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
