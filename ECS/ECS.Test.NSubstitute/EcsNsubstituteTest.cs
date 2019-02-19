using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace ECS.Test.NSubstitute
{
    [TestFixture]
    public class EcsNsubstituteTest
    {
        private ECS _uut;
        private IHeater _heater;
        private ITempSensor _tempSensor;
        private IWindow _window;

        [SetUp]
        public void Setup()
        {
            _heater = Substitute.For<IHeater>();
            _tempSensor = Substitute.For<ITempSensor>();
            _window = Substitute.For<IWindow>();

            _uut = new ECS(_tempSensor, _heater, _window, 15, 25);
        }

        [Test]
        public void Regulate_TempBelowThreshold_HeaterTurnedOn()
        {
            
        }

    }
}
