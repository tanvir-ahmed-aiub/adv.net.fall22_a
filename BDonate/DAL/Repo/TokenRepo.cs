﻿using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo : IRepo<Token, string, Token>
    {
        BloodDonateEntities db;
        internal TokenRepo() {
            db = new BloodDonateEntities();
        }
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) {
                return obj;
            }
            return null;
        }

        public bool Delete(Token obj)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(t=>t.TKey.Equals(id));  
        }

        public Token Update(Token obj)
        {
            var tk = Get(obj.TKey);
            db.Entry(tk).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) { 
                return tk;  
            }
            return null;

        }
    }
}
