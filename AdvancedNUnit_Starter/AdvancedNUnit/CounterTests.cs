using NUnit.Framework;

namespace AdvancedNUnit {
    public class CounterTests {
        private Counter _sut;

        //[SetUp]
        //public void SetUp() {
        //    _sut = new Counter( 6 );
        //}

        private void CreateSut() {
            _sut = new Counter( 6 );
        }

        [Test]
        public void Increment_IncreaseCountByOne() {
            CreateSut();
            _sut.Increment();
            Assert.That( _sut.Count, Is.EqualTo( 7 ) );
        }
        [Test]
        public void Decrement_DecreasesCountByOne() {
            CreateSut();
            _sut.Decrement();
            Assert.That( _sut.Count, Is.EqualTo( 5 ) );
        }
    }
}
