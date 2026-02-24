using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private GameObject textInputContainer;
    [SerializeField] private Button[] choiceButtons;
    [SerializeField] private TMP_InputField textInput;

    public void DisplayQuestion(Question question) { /* ... */ }
    public void OnAnswerSelected(int choiceIndex) { /* ... */ }
    public void OnTextSubmitted() { /* ... */ }
    public void ApplyPhaseEffects(int phase) { /* ... */ }
}
