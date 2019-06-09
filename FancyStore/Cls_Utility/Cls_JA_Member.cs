using DB_Fancy;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Utility
{
    public class Cls_JA_Member
    {

        public static FancyStoreEntities db = new FancyStoreEntities();
        public static int UserID { get; set; }
        public static bool IsAdmin { get; set; }

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
            catch (DbUpdateException)
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
                    UserID = userdata.UserID;
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

        #region 載入會員基本資料
        public static User UserDetail()
        {
            FancyStoreEntities dbb = new FancyStoreEntities();
            return dbb.Users.Where(n => n.UserID == UserID).First();
        }
        #endregion

        #region 修改Email
        public static bool UpdateEmail(string text)
        {
            if (!Cls_JA_IDo.IsValidEmail(text)) { return false; }
            try
            {
                User data = db.Users.FirstOrDefault(n => n.UserID == UserID);
                data.Email = text;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 修改手機
        public static bool UpdatePhone(string text)
        {
            if (!Cls_JA_IDo.IsValidPhone(text)) { return false; }
            try
            {
                var data = db.Users.FirstOrDefault(n => n.UserID == UserID);
                data.Phone = text;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 修改地址
        public static bool UpdateAddress(string r, string a)
        {
            User data = db.Users.FirstOrDefault(n => n.UserID == UserID);
            data.RegionID = db.Regions.Where(n => n.RegionName == r).Select(n => n.RegionID).First();
            data.Address = a;
            db.SaveChanges();
            return true;
        }
        #endregion

        #region 上傳圖片
        public static bool UpLoadPic(string FileName)
        {
            try
            {
                //建立FileStrream 串流 設定開啟模式 讀取權限
                using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = new byte[fs.Length];//串流讀取出來的資料都為byte
                    fs.Read(data, 0, (int)fs.Length);//讀取資料到指定byte陣列
                    Photo newp = new Photo
                    {
                        Photo1 = data,
                        CreateDate = DateTime.Now,

                    };

                    db.Photos.Add(newp);
                    db.SaveChanges();

                    //新增User頭像ID
                    User user = db.Users.FirstOrDefault(n => n.UserID == UserID);
                    user.PhotoID = newp.PhotoID;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        #region 會員更新頭像
        public static bool UserUppic(string FileName)
        {
            try
            {
                //建立FileStrream 串流 設定開啟模式 讀取權限
                using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = new byte[fs.Length];//串流讀取出來的資料都為byte
                    fs.Read(data, 0, (int)fs.Length);//讀取資料到指定byte陣列
                    var pp = db.Photos.Where(n => n.PhotoID == n.Users.Where(nn => nn.UserID == UserID).Select(nn => nn.PhotoID).FirstOrDefault()).First();
                    pp.Photo1 = data;
                    pp.CreateDate = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
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

        #region 移除我的最愛
        public static bool RemoveFavorite(int tag)
        {
            try
            {
                MyFavorite data = db.MyFavorites.Find(tag);
                db.MyFavorites.Remove(data);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion

        #region 會員發問
        public static bool AddQuestion(int orderid,Question Newquestion)
        {
            try
            {
                db.Questions.Add(Newquestion);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 取消訂單
        public static bool CancelOrder(int orderid)
        {
            try
            {
                var data = db.OrderHeaders.FirstOrDefault(n => n.OrderID == orderid);
                data.OrderStatusID = 3;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 驗證驗證碼
        public static bool CheckAuthCode(string code)
        {
            User data = db.Users.Where(n => n.UserID == UserID).First();
            if (data.VerificationCode == code)
            {
                data.VerificationCode = String.Empty;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }
        #endregion

        #region 寄送驗證碼
        public static void SendAuthCode(string Newpw, string Account)
        {
            User data = db.Users.Where(n => n.UserName == Account).FirstOrDefault();
            string AuthCode = Cls_JA_IDo.GetNewPW();
            string Email = data.Email;
            data.VerificationCode = AuthCode;
            db.SaveChanges();
            Cls_JA_IDo.SendEmail(Email, Account, AuthCode);
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
