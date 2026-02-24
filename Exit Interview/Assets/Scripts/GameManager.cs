using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // [SerializeField] private QuestionData questionData;
    // [SerializeField] private PhaseData[] phaseData;

    private int currentQuestionIndex = 0;
    private int currentPhase = 1;

    private void Awake() { /* Singleton setup */ }

    public void LoadNextQuestion() { /* ... */ }
    public void ProcessAnswer(string answer) { /* ... */ }
    private void CheckPhaseTransition() { /* ... */ }
    private void TransitionToPhase(int phase) { /* ... */ }
}