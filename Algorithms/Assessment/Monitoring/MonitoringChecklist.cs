using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.Template;

namespace Algorithms.Assessment.Monitoring
{
	public class MonitoringChecklist
	{
		[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to monitor CPU temperature")]
		public bool CpuTemp { get; set; }
		[AssessmentFact(RecommendationLevel.Advice, true, Message = "Consider to monitor CPU load")]
		public bool CpuLoad { get; set; }
	}
}
