using System;
using Algorithms.Template;

namespace Algorithms.Assessment
{
	/// <summary>
	/// Marks fact properties and their recommendation level
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	sealed class AssessmentFactAttribute : Attribute
	{
		private readonly RecommendationLevel _level;
		private readonly object _correctValue;
		private readonly Func<object, bool> _correctnessChecker;

		public RecommendationLevel Level => _level;
		public object CorrectValue => _correctValue;
		public Func<object, bool> CorrectnessChecker => _correctnessChecker;

		public AssessmentFactAttribute(RecommendationLevel level = RecommendationLevel.None, object correctValue = null)
		{
			_level = level;
			_correctValue = correctValue;
		}

		public AssessmentFactAttribute(RecommendationLevel level, Func<object, bool> correctnessChecker)
		{
			_level = level;
			_correctnessChecker = correctnessChecker;
		}

		public string Message { get; set; }
	}
}
