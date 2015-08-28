namespace Performance.Utils
{
	public class RefValue<T>
	{
		public T Value { get; set; }

		public RefValue()
		{
		}

		public RefValue(T value)
		{
			Value = value;
		}

		public static implicit operator T(RefValue<T> r)
		{
			return r.Value;
		}
	}
}
