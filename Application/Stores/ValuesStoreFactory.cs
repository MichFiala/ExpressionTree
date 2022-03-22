namespace Application.Stores
{
	public static class ValuesStoreFactory
    {
		public static IValuesStore GetValuesStore() => new ValuesStore();
	}
}