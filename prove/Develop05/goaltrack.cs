using System;

public class Goal
{
    private string name;
    private string description;
    private int points;

    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int Points { get => points; set => points = value; }

    public virtual void RecordEvent() { }
}

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void RecordEvent()
    {
        Points += Points;
    }
}

public class ChecklistGoal : Goal
{
    private int totalEvents;
    private int targetEvents;

    public ChecklistGoal(string name, string description, int points, int targetEvents)
    {
        Name = name;
        Description = description;
        Points = points;
        totalEvents = 0;
        this.targetEvents = targetEvents;
    }

    public override void RecordEvent()
    {
        totalEvents++;
        Points += Points;
        if (totalEvents == targetEvents)
        {
            Points += 500;
        }
    }
}

public class GoalsManager
{
    private List<Goal> goals;
    private int score;

    public GoalsManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        goal.RecordEvent();
        score += goal.Points;
    }

    
   
}
