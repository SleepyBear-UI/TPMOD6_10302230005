using System;
namespace TPMOD6_103022300056
{
	public class SayaTubeVideo
	{
		private int id;
		private String title;
		private int playCount;

		private static Random random = new Random();

        public SayaTubeVideo(String title)
        {

            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int addPlay)
		{
			this.playCount += addPlay;
		}

		public void PrintVideoDetail()
		{
			Console.WriteLine($"ID : {this.id}, Title : {this.title}, playCount : {this.playCount}");
		}
	}
}
