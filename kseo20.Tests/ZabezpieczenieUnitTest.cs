using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kseo20.Domain;

namespace kseo20.Tests
{
    [TestClass]
    public class ZabezpieczenieUnitTest
    {
        [TestMethod]
        public void zabezpieczenie_dotyczy_konkretnej_osoby()
        {
            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba,dataRozpoczecia,"","","");
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.IsNotNull(noweZabezpieczenie.ZabezpieczanaOsoba);
          

        }

        [TestMethod]
        public void zabezpieczenie_ma_datę_rozpoczęcia()
        {
            
            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba, dataRozpoczecia,"","","");
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.AreEqual(dataRozpoczecia,noweZabezpieczenie.DataRozpoczecia);

        }

        [TestMethod]
        public void zabezpieczenie_ma_przydzielonego_prowadzącego()
        {

            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            var prowadzacy = "JACEK KORPUSIK";
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba, dataRozpoczecia,prowadzacy,"","");
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.AreEqual(prowadzacy,noweZabezpieczenie.Prowadzacy);

        }

        [TestMethod]
        public void zabezpieczenie_jest_realizowane_w_jednostce_organizacyjnej()
        {

            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            var prowadzacy = "JACEK KORPUSIK";
            var jednostkaProwadzaca = "OŻW KRAKÓW";
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba, dataRozpoczecia, prowadzacy,jednostkaProwadzaca,"");
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.AreEqual(jednostkaProwadzaca, noweZabezpieczenie.JednostkaProwadzaca);

        }

        [TestMethod]
        public void zabezpieczenie_ma_okreslony_cel_pozyskania()
        {

            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            var prowadzacy = "JACEK KORPUSIK";
            var jednostkaProwadzaca = "OŻW KRAKÓW";
            var cel = "OZI";
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba, dataRozpoczecia, prowadzacy, jednostkaProwadzaca,cel);
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.AreEqual(cel, noweZabezpieczenie.Cel);

        }

        [TestMethod]
        public void zabezpieczenie_data_zakonczenia_musi_być_późniejsza_niż_data_rozpoczęcia()
        {

            //given
            var zabezpieczanaOsoba = new Osoba();
            var dataRozpoczecia = DateTime.Parse("2015-01-01");
            var prowadzacy = "JACEK KORPUSIK";
            var jednostkaProwadzaca = "OŻW KRAKÓW";
            var cel = "OZI";
            //when
            var noweZabezpieczenie = new Zabezpieczenie(zabezpieczanaOsoba, dataRozpoczecia, prowadzacy, jednostkaProwadzaca, cel);
            //then
            Assert.IsNotNull(noweZabezpieczenie);
            Assert.AreEqual(cel, noweZabezpieczenie.Cel);

        }
        
    }
}
