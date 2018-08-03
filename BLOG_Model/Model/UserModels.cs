using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Model.Model
{
     public class UserModels : BaseModels<UserObject>
    {
        public override List<UserObject> getElements()
        {
            var listData = dbContext.SP_User_getElements();

            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                listUser.Add(obj);
            }
            return listUser;
        }

        public override UserObject getElementById(Guid id)
        {
            var data = dbContext.SP_User_getElementById(id);
            foreach (var item in data)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                return obj;
            }
            return null;
        }

        public override bool update(UserObject obj)
        {
            try
            {
                return dbContext.SP_User_update(obj.idUser, obj.userName, obj.passWord, obj.email, obj.fullName, obj.mobile, obj.created_at, DateTime.Now, false) > 0;

            }
            catch
            {
                return false;
            }
        }

        public override bool create(UserObject obj)
        {
            try
            {
                return dbContext.SP_User_create(Guid.NewGuid(), obj.userName, BLOG_ValueObject.Common.CommonConstant.PASSWORD, obj.email, obj.fullName, obj.mobile, DateTime.Now, DateTime.Now, false) > 0;

            }
            catch
            {
                return false;
            }
        }

        public override bool delete(Guid id)
        {
            return dbContext.SP_User_delete(id) > 0;
        }

        public override UserObject checkLogin(string userName, string passWord)
        {
            var data = dbContext.SP_User_checkLogin(userName, passWord);
            foreach (var item in data)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };

                return obj;
            }
            return null;
        }

        public override bool deletePermanently(Guid id)
        {
            return dbContext.SP_User_deletePermanently(id)>0;
        }

        public override List<UserObject> getdeletedElements()
        {
            var listData = dbContext.SP_User_getdeletedElements();

            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                listUser.Add(obj);
            }
            return listUser;
        }

        public override bool restore(Guid id)
        {
            return dbContext.SP_User_restore(id)>0;
        }

        public override int getNumber()
        {
            var count = dbContext.SP_User_getNumberUser();
            foreach (var item in count)
            {
                return int.Parse(item.ToString());
            }
            return 0;
        }

        public override List<UserObject> getPaging(int start, int length)
        {
            var listData = dbContext.SP_User_getPaging(start, length);
            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                listUser.Add(obj);
            }
            return listUser;
        }

        public override List<UserObject> search(string email)
        {
            var listData = dbContext.SP_User_Search(email);
            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                listUser.Add(obj);
            }
            return listUser;
        }

        public override List<UserObject> searchPaging(string email, int start, int length)
        {
            var listData = dbContext.SP_User_Search_Paging(email, start, length);
            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject
                {
                    idUser = item.idUser,
                    userName = item.userName,
                    passWord = item.passWord,
                    fullName = item.fullName,
                    mobile = item.mobile,
                    email = item.email,
                    created_at = item.created_at,
                    updated_at = item.updated_at,
                    isDel = item.isDel
                };
                listUser.Add(obj);
            }
            return listUser;
        }

        public override int searchCount(string email)
        {
            var count = dbContext.SP_User_countPaging(email);
            foreach (var item in count)
            {
                return int.Parse(item.ToString());
            }
            return 0;
        }
    }
}
