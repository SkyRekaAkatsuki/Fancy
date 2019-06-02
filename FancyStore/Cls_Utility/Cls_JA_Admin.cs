using DB_Fancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Utility
{
    public class Cls_JA_Admin
    {
        
        public static bool UpdateUserPassword(int id, string newpw)
        {
            try
            {
                User user = Cls_JA_Member.db.Users.Where(n => n.UserID == id).First();
                string guid = Guid.NewGuid().ToString("N");
                user.GUID = guid;
                user.UserPassword = Cls_JA_IDo.HashPw(newpw, guid);
                Cls_JA_Member.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool UpdateUserAcode(int id, string 開通用驗證碼)
        {
            try
            {
                User user = Cls_JA_Member.db.Users.Where(n => n.UserID == id).First();
                user.VerificationCode = 開通用驗證碼;
                Cls_JA_Member.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool DeleteUser(int id, bool enabled)
        {
            try
            {
                User user = Cls_JA_Member.db.Users.Where(n => n.UserID == id).First();
                user.Enabled = !enabled;
                Cls_JA_Member.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool UpdateUserAdmin(int id, bool 權限)
        {
            try
            {
                User user = Cls_JA_Member.db.Users.Where(n => n.UserID == id).First();
                user.Admin = 權限;
                Cls_JA_Member.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
