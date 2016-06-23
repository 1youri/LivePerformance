using System;
using Live_Performance.Logic;
using Live_Performance.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LivePerformanceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginEncrypt()
        {
            Assert.AreEqual(Live_Performance.Logic.Login.Encrypt(@"test"),
                "f9feb3240275c355e231bbb941e17cb3442c8f703aa74d4dca238a006bab1cf55a499e56ef37a50fadd0c409f95c1643eadada317dea350315eca9614e060bb5");
            Assert.AreEqual(Live_Performance.Logic.Login.Encrypt(@";'%][{]}"),
                "c0e3d5cc2c8429719ea769e6ac604c2e339e7311916f2dc560f60fcebd5cf7ced2b76ce796f1f3b7c34bbb4d00ceeaa01839a64a3bf5405ae03809f43522bfe9");
            Assert.AreEqual(Live_Performance.Logic.Login.Encrypt(@"!@#$%^&*()[]{}-=_+;':"",.<>/?\|"),
                "3dac565f2ba9943bb504f498829ae89b851d17e519a1b7a8ec69b65841f7a29b893689e7587cc3ea6025c59ea5adbb85110b7743b6ff78e43cb1bbf268af890c");
            Assert.AreEqual(Live_Performance.Logic.Login.Encrypt(@"liveperformance"),
                "9ab7311531dbea5d040578e6e54f3df5d76590c0eea6e9bcadb3f1c8fdc35be6ebc2e0caa0f87affebcf9875d29d88f0073428a303c6dd47d78edc291ccb42ce");
            Assert.AreEqual(Live_Performance.Logic.Login.Encrypt(@"HeelErgLangeStringOmTeKijkenOfIkDeFunctieKanLatenCrashenDoorEenLangeStringInTeVoeren"),
                "aa0fca9b373bc26c76382268ad1a9222d0d5df75f50279bba816ad18391fa9b80060ae99b46e7b1e08d399d914111147e46f72a6eee89a73936fea6830311b6f");
        }
        [TestMethod]
        public void TestLoginAvailable()
        {
            Assert.AreEqual(Login.CheckAvailable("1youri", "random@email.nl"), AccountRepo.Check.UsernameUsed);
            Assert.AreEqual(Login.CheckAvailable("RandomUnusedUsername", "yourish@live.nl"), AccountRepo.Check.EmailUsed);
            Assert.AreEqual(Login.CheckAvailable("RandomUnusedUsername", "random@email.nl"), AccountRepo.Check.Available);
            Assert.AreEqual(Login.CheckAvailable("1youri", "yourish@live.nl"), AccountRepo.Check.BothUsed);
        }

        [TestMethod]
        public void TestLoginValidation()
        {
            Assert.AreEqual(Login.LoginUser("1youri", "bliepbloep"), false);
            Assert.AreEqual(Login.LoginUser("Random", "bliepbloep"), false);
            Assert.AreEqual(Login.LoginUser("morerandom", "test123"), false);
            Assert.AreEqual(Login.LoginUser("test123", "1youri"), false);
            Assert.AreEqual(Login.LoginUser("1youri", "test123"), true);
        }

        [TestMethod]
        public void TestHuurContract()
        {
            HuurContract hc = new HuurContract();
            Assert.AreEqual(hc.PrijsBerekening(10.0, 20.0), "U kunt met dit budget 8 meren bevaren.");
            Assert.AreEqual(hc.PrijsBerekening(15.0, 0.0), "Uw budget is lager dan de kosten van uw huur!");
            Assert.AreEqual(hc.PrijsBerekening(20.0, 20.0), "Uw budget is niet hoog genoeg om een meer te bevaren!");
            Assert.AreEqual(hc.PrijsBerekening(6.0, 30.0), "U kunt met dit budget alle meren bevaren!");
            Assert.AreEqual(hc.PrijsBerekening(1.0, 10000.0), "U kunt met dit budget alle meren bevaren!");
        }


    }
}

