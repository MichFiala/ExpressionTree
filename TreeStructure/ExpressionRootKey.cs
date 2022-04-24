namespace TreeStructure
{
	/// <summary>
	/// Serves for creating indetifier for expression variables
	/// The key is build by multiple keyParts passed into constructor
	/// Uses .GetType() and .ToString() of keyParts to build key
	/// </summary>
	public abstract class ExpressionRootKey
	{
		/// <summary>
		/// Holds all keyparts in keys collection
		/// We need to have track of key parts for contain functionality
		/// </summary>
		private readonly HashSet<string> keyParts;
		/// <summary>
		/// Preserves all joined keyParts together
		/// Used for equality check and hash code 
		/// </summary>
		private readonly string key;
		/// <summary>
		/// Constructor for building key
		/// It builds it by converting keyParts into .ToString an concate .GetType
		/// </summary>
		/// <param name="keyParts">Key Parts</param>
		/// <exception cref="ArgumentException">Empty collection of key parts</exception>
		protected ExpressionRootKey(params object[] keyParts)
		{
			if (keyParts.Length == 0) throw new ArgumentException("Key parts cannot be empty");

			this.keyParts = new();

			var keyPartsAsStrings = keyParts.Select(x => KeyPartToString(x)).ToList();
			// Join key parts into one key
			this.key = string.Join(string.Empty, keyPartsAsStrings);
			// Put all parts into hash set
			foreach (var keyPartString in keyPartsAsStrings)
			{
				this.keyParts.Add(keyPartString);
			}
		}
		public override int GetHashCode() => key.GetHashCode();

		public override bool Equals(object? obj) => Equals(obj as ExpressionRootKey);

		public bool Equals(ExpressionRootKey? rootKey) => rootKey is not null && string.Equals(rootKey.key, key);
		public bool Contains(object keyPart) => keyParts.Contains(KeyPartToString(keyPart));

		public override string ToString() => key;
		/// <summary>
		/// Converts key part into string using .GetType() and .ToString()
		/// Allows to two different enums with same names of values to be NOT equal
		/// </summary>
		/// <param name="keyPart">Key part</param>
		/// <returns>Key part as string</returns>
		private static string KeyPartToString(object keyPart) => $"{keyPart.GetType()}{keyPart}";
	}
}