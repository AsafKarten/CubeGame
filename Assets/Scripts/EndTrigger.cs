
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovment movment;
    private void OnTriggerEnter()
    {
        movment.enabled = false;
        gameManager.CompleateLevel();
    }
}
