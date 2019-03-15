using APPPInCSharp_ActiveObjectPattern.Console;
using NUnit.Framework;
using System.Diagnostics;

namespace APPPInCSharp_ActiveObjectPattern.UnitTests
{
    [TestFixture]
    public class SleepCommandTests
    {
        private WakeUpCommand wakeup;
        private ActiveObjectEngine engine;
        private SleepCommand sleep;

        [SetUp]
        public void SetUp()
        {
            wakeup = new WakeUpCommand();
            engine = new ActiveObjectEngine();
            sleep = new SleepCommand(1000, engine, wakeup);
            engine.AddCommand(sleep);
        }

        [Test]
        public void Sleep_SleepTimeGreaterThanOrEqualTo1000_ReturnTrue()
        {
            var sleepTime = ElapsedTime();
            Assert.That(sleepTime >= 1000, Is.True, $"SleepTime {sleepTime.ToString()} expected > 1000");
        }

        [Test]
        public void Sleep_SleepTimeLessThanOrEqualTo1100_ReturnTrue()
        {
            var sleepTime = ElapsedTime();
            Assert.That(sleepTime <= 1100, Is.True, $"SleepTime {sleepTime.ToString()} expected < 1100");
        }

        [Test]
        public void Sleep_WakeUpCommandExecuted_ReturnTrue()
        {
            ElapsedTime();
            Assert.That(wakeup.executed, Is.True, "Command Executed");
        }

        private double ElapsedTime()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            engine.Run();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}