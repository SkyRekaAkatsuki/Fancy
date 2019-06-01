using DB_Fancy;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Utility
{
    public class Cls_JA_Member
    {

        static FancyStoreEntities db = new FancyStoreEntities();
        #region 註冊
        public static bool Register(User NewUser)
        {
            if (AccountCheck(NewUser.UserName))
            { throw new Exception("帳號重複"); }
            if (EmailCheck(NewUser.Email))
            { throw new Exception("郵件重複"); }

            try
            {
                db.Users.Add(NewUser);
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException x)
            {

                throw;
            }
        }
        #endregion

        #region 登入驗證
        public static bool VaildateUser(string Username, string Password)
        {
            if (db.Users.Any(n => n.UserName == Username))
            {
                var userdata = db.Users.Where(n => n.UserName == Username).First();
                byte[] p = Cls_JA_IDo.HashPw(Password, userdata.GUID);
                if (BitConverter.ToString(p) == BitConverter.ToString(userdata.UserPassword))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 忘記密碼
        public static bool ForgotPassword(string Account, string Email)
        {
            if (db.Users.Any(n => n.UserName == Account && n.Email == Email))
            {
                try
                {
                    string newpw = Cls_JA_IDo.GetNewPW();
                    Cls_JA_IDo.SendEmail(Email, Account, newpw);
                    UpdatePassword(newpw, Account);
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else { return false; }
        }
        #endregion


        #region 更新密碼
        public static void UpdatePassword(string NewPw, string Account)
        {
            try
            {
                var data = db.Users.FirstOrDefault(n => n.UserName == Account);
                string guid = Guid.NewGuid().ToString("N");
                byte[] hashPw = Cls_JA_IDo.HashPw(NewPw, guid);

                data.UserPassword = hashPw;
                data.GUID = guid;
                db.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 帳號檢查是否重複
        public static bool AccountCheck(string Account)
        {
            return db.Users.Any(n => n.UserName == Account);
        }
        #endregion

        #region 檢查信箱是否重複
        public static bool EmailCheck(string Email)
        {

            return db.Users.Any(n => n.Email == Email);
        }
        #endregion

    }
}
