using Assets.Scripts;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    [SerializeField]
    int countOfPigs = 1;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("PigDestroy"))
        {
            countOfPigs--;
            if (countOfPigs <= 0)
            {
                GameState.isLevelCompleted = true;
                GameState.Pause("ÂÈÃÐÀØ", "Ð³âåíü ïðîéäåíî");

            }
        }
    }
}