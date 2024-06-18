using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public BotController botController;

    void Start()
    {
        Button moveButton = transform.Find("MoveButton").GetComponent<Button>();
        moveButton.onClick.AddListener(OnMoveButtonClicked);
    }

    void OnMoveButtonClicked()
    {
        botController.MoveToNextWaypoint();
    }
}
