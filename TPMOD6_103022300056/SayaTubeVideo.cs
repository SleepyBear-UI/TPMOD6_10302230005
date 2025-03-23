using System;
using System.Diagnostics.Contracts;

namespace TPMOD6_103022300056
{
	public class SayaTubeVideo
	{
		// Attribut untuk Class SayaTubeVideo
		private int id;
		private String title;
		private int playCount;

		private static Random random = new Random();

		// Constructor untuk SayaTubeVideo
        public SayaTubeVideo(String titles)
        {
            Contract.Requires(title != null && title.Length <= 100);
			Contract.Requires(playCount <= 10000000);
            this.id = random.Next(10000, 99999);
            this.title = titles;
            this.playCount = 0;
        }

        // Method IncreasePlayCount : Untuk menambahkan playcount berdasarkan yang diisi di parameter
        public void IncreasePlayCount(int addPlay)
		{
            Contract.Requires(playCount <= 10000000);

            try
			{
                this.playCount += addPlay;
            } catch(OverflowException e)
			{
				Console.WriteLine(e.Message);
			}
		}

        // Method PrintVideoDetail : untuk menampilkan ID, Title dan PlayCount
        public void PrintVideoDetail()
		{
			Console.WriteLine($"ID : {this.id}, Title : {this.title}, playCount : {this.playCount}");
		}
	}
}
