using RestServer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestServer
{
    public class AccountData
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-DKFS33I\SQLEXPRESS;Initial Catalog=BankAccount;Integrated Security=true;");
        BankAccountEntities entities = new BankAccountEntities();

        public long SaveAccount(Account accountToSave)
        {
            SqlCommand cmd = new SqlCommand("insert into AccountInfo(ID,Account_Name,Account_Number,Account_Balance) values(@id,@acName,@acNo,@acB)", sqlCon);
            sqlCon.Open();
            cmd.Parameters.AddWithValue("@id", accountToSave.id);
            cmd.Parameters.AddWithValue("@acName", accountToSave.accountName);
            cmd.Parameters.AddWithValue("@acNo", accountToSave.accountNumber);
            cmd.Parameters.AddWithValue("@acB", accountToSave.accountBalance);
            long id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;

        }

    }
}