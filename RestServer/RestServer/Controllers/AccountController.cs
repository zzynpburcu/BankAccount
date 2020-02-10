using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestServer.Models;

namespace RestServer.Controllers
{
    public class AccountController : ApiController
    {
        // GET: api/Account
        public IEnumerable<AccountInfo> Get()
        {
            using (BankAccountEntities entities = new BankAccountEntities())
            {
                return entities.AccountInfo.ToList();

            }
        }

        // GET: api/Account/5
        public AccountInfo Get(int id)
        {
            using (BankAccountEntities entities = new BankAccountEntities())
            {
                return entities.AccountInfo.FirstOrDefault(e => e.ID == id);
            }
            //Account account = new Account();
            //account.id = id;
            //account.accountName = "İstinye/Sarıyer";
            //account.accountNumber = 123;
            //account.accountBalance = 500;
            //return account;
        }

        // POST: api/Account
        public void Post([FromBody]Account value)
        {
            AccountData ad = new AccountData();
            long id;
            id = ad.SaveAccount(value);
        }

        // PUT: api/Account/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
        }
    }
}
