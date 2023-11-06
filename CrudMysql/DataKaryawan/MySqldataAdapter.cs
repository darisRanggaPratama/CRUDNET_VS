namespace DataKaryawan
{
	internal class MySqldataAdapter
	{
		private string query;
		private string connectString;

		public MySqldataAdapter(string query, string connectString)
		{
			this.query = query;
			this.connectString = connectString;
		}
	}
}