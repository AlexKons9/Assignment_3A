namespace MyModels.Models
{
    public class MarkPerTopic
    {
        public int Id { get; set; }
        public int MarkOfTopic1 { get; set; }
        public int MarkOfTopic2 { get; set; }
        public int MarkOfTopic3 { get; set; }
        public int MarkOfTopic4 { get; set; }
        public int FinalScore 
        {
            get { return FinalScore; }
            set { FinalScore = MarkOfTopic1 + MarkOfTopic2 + MarkOfTopic3 + MarkOfTopic4; }
        }
    }
}