using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public class Application
    {
        public enum EarlyFinishReason { Cancel = 1, SolvedByOperator = 2 }
        
        public int Id { get; set; }
        
        public Appeal Appeal { get; set; }

        public Service ChosenService { get; set; } = new Service();

        public ITariff ChosenTariff { get; set; } 

        public bool _isFinished { get; protected set; } = false;

        public string _operatorComment { get; protected set; }

        public EarlyFinishReason _earlyFinishReason { get; protected set; }

        public void SetEarlyFinish(EarlyFinishReason earlyFinishReason)
        {
            _isFinished = true;
            _earlyFinishReason = earlyFinishReason;
        }

        public void SetEarlyFinish(EarlyFinishReason earlyFinishReason, string operatorComment)
        {
            _isFinished = true;
            _operatorComment = operatorComment;
            _earlyFinishReason = earlyFinishReason;
        }
    }
}
