﻿using BLOG_ValueObject.EntityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG_Model.Model
{
     public class UserModel : BaseModels<UserObject>
    {
        public override List<UserObject> getElements()
        {
            var listData = dbContext.SP_User_getElements();

            List<UserObject> listUser = new List<UserObject>();
            foreach (var item in listData)
            {
                UserObject obj = new UserObject();
                obj.idUser = item.idUser;
                obj.userName = item.userName;
                obj.passWord = item.passWord;
                obj.fullName = item.fullName;
                obj.mobile = item.mobile;
                obj.created_at = item.created_at;
                obj.updated_at = item.updated_at;
                obj.isDel = item.isDel;
                listUser.Add(obj);
            }
            return listUser;
        }

        public override UserObject getElementById(Guid id)
        {
            var data = dbContext.SP_User_getElementById(id);
            foreach (var item in data)
            {
                UserObject obj = new UserObject();
                obj.idUser = item.idUser;
                obj.userName = item.userName;
                obj.passWord = item.passWord;
                obj.fullName = item.fullName;
                obj.mobile = item.mobile;
                obj.created_at = item.created_at;
                obj.updated_at = item.updated_at;
                obj.isDel = item.isDel;
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
                return dbContext.SP_User_update(obj.idUser, obj.userName, obj.passWord, obj.email, obj.fullName, obj.mobile, DateTime.Now, DateTime.Now, false) > 0;

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
    }
}
