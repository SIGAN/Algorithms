using Algorithms.Template;

namespace Algorithms.Assessment.Performance
{
	public class PerformanceChecklist
	{
		[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to wait for identical CPU temperature!")]
		public bool WaitCpuTemp { get; set; }
		[AssessmentFact(RecommendationLevel.Required, true, Message = "You should set affinity accordingly to the scenario!")]
		public bool SetAffinity { get; set; }
		//[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to set ideal CPU for computing!")]
		//public bool SetIdeal { get; set; }
		[AssessmentFact(RecommendationLevel.Required, true, Message = "You should synchronize ticks!")]
		public bool SyncTicks { get; set; }
		[AssessmentFact(RecommendationLevel.Required, true, Message = "Warm up is required for proper performance testing!")]
		public bool WarmUp { get; set; }
		[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to filter out top 10% of results!")]
		public bool FilterTop10 { get; set; }
		[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to filter out bottom 10% of results!")]
		public bool FilterBottom10 { get; set; }
	}
}
