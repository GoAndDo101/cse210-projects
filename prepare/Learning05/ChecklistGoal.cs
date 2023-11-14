using System.ComponentModel.DataAnnotations.Schema;

class ChecklistGoal : Goal{

    private int _completed;

    private int _needed;

    private int _fullyCompletePoints;
    
    public override void Complete()
    {
        throw new NotImplementedException();
    }

    ChecklistGoal(){
        
    }
}