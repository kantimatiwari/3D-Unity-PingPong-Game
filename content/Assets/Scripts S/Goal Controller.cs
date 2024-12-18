using UnityEngine;
using UnityEngine.Events;

public class GoalController : MonoBehaviour
{
    // Rename the UnityEvent field to avoid conflict
    public UnityEvent onGoalScored;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            // Invoke the renamed event
            onGoalScored?.Invoke();
        }
    }
}
