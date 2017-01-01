using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using XconApp.Data;
using XconApp.Models;

namespace XconApp.Repository
{
    public class OrderRepository
    {
        private readonly XCON_GCEntities _db;
        public OrderRepository()
        {
            _db = new XCON_GCEntities();
        }


        public OrderModel GetOrder(string userId, string cardCode)
        {
            var order = new OrderModel();

            using (var conn = new SqlConnection(_db.Database.Connection.ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (var command = new SqlCommand("dbo.GetOrderByUser", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@CardCode", cardCode);

                    using (var reader = command.ExecuteReader(CommandBehavior.Default))
                    {
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                order = MapOrderToModel(reader);
                                order.OrderDetails = new List<OrderDetailModel>();

                                if (reader.NextResult())
                                {
                                    while (reader.Read())
                                    {
                                        order.OrderDetails.Add(MapOrderDetailToModel(reader));
                                    }

                                }
                            }
                            reader.Close();
                        }

                    }
                }
            }

            return order;

        }

        private OrderModel MapOrderToModel(IDataReader reader)
        {
            return new OrderModel
            {
                DocEntry = Convert.ToInt32(reader["DocEntry"] != DBNull.Value ? reader["DocEntry"] : 0),
                DocNum = Convert.ToInt32(reader["DocNum"] != DBNull.Value ? reader["DocNum"] : 0),
                DocDate = Convert.ToString(reader["DocDate"] != DBNull.Value ? reader["DocDate"] : ""),
                EndDate = Convert.ToString(reader["EndDate"] != DBNull.Value ? reader["EndDate"] : ""),

                RangeDateType = Convert.ToString(reader["RangeDateType"] != DBNull.Value ? reader["RangeDateType"] : ""),
                CardCode = Convert.ToString(reader["CardCode"] != DBNull.Value ? reader["CardCode"] : ""),
                CardName = Convert.ToString(reader["CardName"] != DBNull.Value ? reader["CardName"] : ""),
                ProjectName = Convert.ToString(reader["ProjectName"] != DBNull.Value ? reader["ProjectName"] : ""),
                ProjectCode = Convert.ToString(reader["ProjectCode"] != DBNull.Value ? reader["ProjectCode"] : ""),
                DocCur = Convert.ToString(reader["DocCur"] != DBNull.Value ? reader["DocCur"] : ""),
                DocRate = Convert.ToDecimal(reader["DocRate"] != DBNull.Value ? reader["DocRate"] : 0),
                Address = Convert.ToString(reader["Address"] != DBNull.Value ? reader["Address"] : "")
            };
        }

        private OrderDetailModel MapOrderDetailToModel(IDataReader reader)
        {
            return new OrderDetailModel
            {
                U_GC_GroupType = Convert.ToString(reader["U_GC_GroupType"] != DBNull.Value ? reader["U_GC_GroupType"] : ""),
                ItemCode = Convert.ToString(reader["ItemCode"] != DBNull.Value ? reader["ItemCode"] : ""),
                Dscription = Convert.ToString(reader["Dscription"] != DBNull.Value ? reader["Dscription"] : ""),
                CanEditChild = Convert.ToString(reader["CanEditChild"] != DBNull.Value ? reader["CanEditChild"] : ""),
                Price = Convert.ToDecimal(reader["Price"] != DBNull.Value ? reader["Price"] : 0),
                U_Size = Convert.ToString(reader["U_Size"] != DBNull.Value ? reader["U_Size"] : ""),
                U_Color = Convert.ToString(reader["U_Color"] != DBNull.Value ? reader["U_Color"] : "")
            };
        }
    }
}