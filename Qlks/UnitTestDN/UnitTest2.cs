using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qlks;


namespace UnitTestDN
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Nhap_TT_Du()
        {
            string actual = Check_Update.kt_suaphong("diepkhanhdoan", "1995", "366060680", "2");
            string expected = "1";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Khong_Nhap_Ten()
        {
            string actual = Check_Update.kt_suaphong("", "1995", "366060680", "2");
            string expected = "2";
            Assert.AreEqual(expected, actual);

         }

        [TestMethod]
        public void Test_Khong_Nhap_Namsinh()
        {
            string actual = Check_Update.kt_suaphong("diepkhanhdoan", "", "366060680", "2");
            string expected = "3";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Khong_Nhap_Socm()
        {
            string actual = Check_Update.kt_suaphong("diepkhanhdoan", "1995", "", "2");
            string expected = "4";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Khong_Nhap_Songaydp()
        {
            string actual = Check_Update.kt_suaphong("diepkhanhdoan", "1995", "366060680", "");
            string expected = "5";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Tong_Tien_Bang0()
        {
            string  actual = Check_Tinhtien.kt_tongtien("0");
            string  expected = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Tong_Tien()
        {
            string actual = Check_Tinhtien.kt_tongtien("15000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Du_TT()
        {
            string actual = Check_SuaTTP.kt_TTPhong("101","10000");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Thieu_MaPhong_TT()
        {
            string actual = Check_SuaTTP.kt_TTPhong("", "10000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Thieu_GiaPhong_TT()
        {
            string actual = Check_SuaTTP.kt_TTPhong("101", "");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Du_TT_NV()
        {
            string actual = Check_TTNV.kt_ThemTTNV("Diepkhanhdoan", "tanphu","0968043321","21","123456","admin");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Thieu_Ten_NV()
        {
            string actual = Check_TTNV.kt_ThemTTNV("", "tanphu", "0968043321", "21", "123456", "admin");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Thieu_TaiKhoan_NV()
        {
            string actual = Check_TTNV.kt_ThemTTNV("Diepkhanhdoan", "tanphu", "0968043321", "21", "", "admin");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Sai_TaiKhoan_NV()
        {
            string actual = Check_TTNV.kt_ThemTTNV("Diepkhanhdoan", "tanphu", "0968043321", "21", "123", "admin");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Sua_TTNV_TC()
        {
            string actual = Check_SuaTTNV.kt_SuaTTNV("Diepkhanhdoan", "tanphu", "0968043321", "21", "admin", "admin");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Sai_TaiKhoan()
        {
            string actual = Check_SuaTTNV.kt_SuaTTNV("Diepkhanhdoan", "tanphu", "0968043321", "21", "abc", "admin");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_Ten_NV()
        {
            string actual = Check_SuaTTNV.kt_SuaTTNV("", "tanphu", "0968043321", "21", "abc", "admin");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test__Nhap_TaiKhoan_NV()
        {
            string actual = Check_SuaTTNV.kt_SuaTTNV("DiepKhanhdoan", "tanphu", "0968043321", "21", "", "admin");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }



    }

}
