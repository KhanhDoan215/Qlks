using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qlks;

namespace UnitTestDN
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = Checkkiemtradangnhap.ktdangnhap("admin", "admin");
            string expected = "0";
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID_and_Pass()
        {
            string actual = Checkkiemtradangnhap.ktdangnhap("", "");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID()
        {
            string actual = Checkkiemtradangnhap.ktdangnhap("", "admin");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhap_Thieu_pass()
        {
            string actual = Checkkiemtradangnhap.ktdangnhap("admin", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_pass()
        {
            string actual = Checkkiemtradangnhap.ktdangnhap("admin", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_OLD_pass()
        {
            string actual = checkChangePassword.check_changepassword("123", "123","123");
            string expected = "Nhập lại mật khẩu";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_New_Pass()
        {
            string actual = checkChangePassword.check_changepassword("amdin", "1234", "123");
            string expected = "Xác nhận lại mật khẩu";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_MK_Cof_pass()
        {
            string actual = checkChangePassword.check_changepassword("admin", "123", "1234");
            string expected = "Xác nhận lại mật khẩu";
            Assert.AreEqual(expected, actual);
        }
    }
}