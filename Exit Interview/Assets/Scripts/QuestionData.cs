using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionData", menuName = "Scriptable Objects/QuestionData")]
public class QuestionData : ScriptableObject
{
    public List<Question> questions;
    public Question GetQuestion(int index)
    {
        return questions[index];
    }
}
