using System;
using NUnit.Framework;
using VideoStore;

namespace Tests
{
	[TestFixture]
	public class RentalTests 
	{
		private Rental rental;
		private Movie movie;  
  
		[SetUp]
		public void Init() 
		{
			movie = new Movie("some movie", Movie.CHILDRENS);
			rental = new Rental(movie, 1);
		}

		[Test]
		public void GetDaysRented() 
		{
			Assert.AreEqual(1, rental.DaysRented);
		}
  
		[Test]
		public void GetMovie() 
		{
			Assert.AreEqual(movie, rental.Movie);
		}
	}
}