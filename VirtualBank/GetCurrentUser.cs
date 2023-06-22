namespace VirtualBank
{
	public class GetCurrentUser
	{
		public string path = Environment.CurrentDirectory + @"\User.txt";
		public int? userid { get; set; }

		public int? GettingUser()
		{

			StreamReader sr = new StreamReader(path);
			userid = int.Parse(sr.ReadLine());
			sr.Close();
			return userid;
		}
	}
}
