using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    public Attacker attackerBehavior;
    public Defender defenderBehavior;

    private bool isAttacker;
    private bool isGameOver;

    public bool IsGameOver => isGameOver;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        isAttacker = true;
        SwitchBehaviors();
        StartCoroutine(SwitchRoles());
    }

    private IEnumerator SwitchRoles()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(40f);
            isAttacker = !isAttacker;
            SwitchBehaviors();
        }
    }

    private void SwitchBehaviors()
    {
        attackerBehavior.enabled = isAttacker;
        defenderBehavior.enabled = !isAttacker;
    }

    public void GameOver()
    {
        isGameOver = true;
        // Display game over UI or perform any other necessary actions
    }
}
