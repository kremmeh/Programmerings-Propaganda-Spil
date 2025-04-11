using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void PostersUp()
    {
        if (goalType == GoalType.Posters)
            currentAmount++;
    }
    public void CoversationDone()
    {
        if (goalType == GoalType.Conversation)
            currentAmount++;
    }

}

public enum GoalType
{
    Posters,
    Conversation
}

