using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidaTest
{
    public class TestingClase
    {
        [Test]
        public void NumeroRomano()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(1);
            Assert.AreEqual("I",ob);
        }
        [Test]
        public void NumeroRomano1()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(2);
            Assert.AreEqual("II", ob);
        }
        [Test]
        public void NumeroRomano2()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(3);
            Assert.AreEqual("III", ob);
        }
        [Test]
        public void NumeroRomano3()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(4);
            Assert.AreEqual("IV", ob);
        }
        [Test]
        public void NumeroRomano4()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(5);
            Assert.AreEqual("V", ob);
        }
        [Test]
        public void NumeroRomano5()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(6);
            Assert.AreEqual("VI", ob);
        }
        [Test]
        public void NumeroRomano6()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(7);
            Assert.AreEqual("VII", ob);
        }
        [Test]
        public void NumeroRomano7()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(8);
            Assert.AreEqual("VIII", ob);
        }
        [Test]
        public void NumeroRomano8()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(9);
            Assert.AreEqual("IX", ob);
        }
        [Test]
        public void NumeroRomano9()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(10);
            Assert.AreEqual("X", ob);
        }
        [Test]
        public void NumeroRomano10()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(11);
            Assert.AreEqual("XI", ob);
        }
        [Test]
        public void NumeroRomano11()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(12);
            Assert.AreEqual("XII", ob);
        }
        [Test]
        public void NumeroRomano12()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(13);
            Assert.AreEqual("XIII", ob);
        }
        [Test]
        public void NumeroRomano13()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(14);
            Assert.AreEqual("XIV", ob);
        }
        [Test]
        public void NumeroRomano14()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(15);
            Assert.AreEqual("XV", ob);
        }
        [Test]
        public void NumeroRomano15()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(16);
            Assert.AreEqual("XVI", ob);
        }
        [Test]
        public void NumeroRomano16()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(17);
            Assert.AreEqual("XVII", ob);
        }
        [Test]
        public void NumeroRomano17()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(18);
            Assert.AreEqual("XVIII", ob);
        }
        [Test]
        public void NumeroRomano18()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(19);
            Assert.AreEqual("XIX", ob);
        }
        [Test]
        public void NumeroRomano19()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(20);
            Assert.AreEqual("XX", ob);
        }
        [Test]
        public void NumeroRomano20()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(21);
            Assert.AreEqual("XXI", ob);
        }
        [Test]
        public void NumeroRomano21()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(22);
            Assert.AreEqual("XXII", ob);
        }
        [Test]
        public void NumeroRomano22()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(23);
            Assert.AreEqual("XXIII", ob);
        }
        [Test]
        public void NumeroRomano23()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(24);
            Assert.AreEqual("XXIV", ob);
        }
        [Test]
        public void NumeroRomano24()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(25);
            Assert.AreEqual("XXV", ob);
        }
        [Test]
        public void NumeroRomano25()
        {
            var numerRom = new RomanoGenerator();
            var ob = numerRom.GetRomano(26);
            Assert.AreEqual("XXVI", ob);
        }
    }
}
