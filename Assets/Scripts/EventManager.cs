using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action onPlayerDeath;

    [SerializeField] Transform player;
    [Tooltip("Limit distance for death when the player falls")]
    [SerializeField] float playerDeathBoundary;

    private void Update()
    {
        if (IsOutOfBoundary(player.position.y, playerDeathBoundary))
        {
            onPlayerDeath?.Invoke();
        }
    }

    private bool IsOutOfBoundary(float position, float boundary)
    {
        if (position < boundary ) return true;
        return false;
    }
}