
using System;
using System.Collections.Generic;


class program
{
    public static void Main()
    {
        EternalQuest quest = new EternalQuest();

        // Add some example goals

         quest.AddGoal(new SimpleGoal("Going out for training Every morning", 1000));
         quest.AddGoal(new SimpleGoal("Prepare for duty every 4:30PM", 1000));
        quest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        quest.AddGoal(new EternalGoal("Read Scriptures", 100));
        quest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));
        quest.AddGoal(new ChecklistGoal("3 hours Daily study", 100, 10));

        // Record some progress on the goals
        quest.RecordEvent("Read Scriptures");
        quest.RecordEvent("Read Scriptures");
        quest.RecordEvent("3 hours Daily study");
        quest.RecordEvent("Going out for training Every morning");
        quest.RecordEvent("Prepare for duty every 4:30PM");
        quest.RecordEvent("Attend Temple");
        quest.RecordEvent("Attend Temple");
        quest.RecordEvent("Attend Temple");
        // Display the current status of the goals
        quest.DisplayStatus();
    }
}