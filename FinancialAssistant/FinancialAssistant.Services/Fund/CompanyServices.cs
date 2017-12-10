using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Fund
{
    public class CompanyServices
    {
        public bool Delete(int Id)
        {
            string sql = string.Format("DELETE FROM Fund_Company Where Id={0}",Id);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Update(Fund_Company FC)
        {
            string sql = string.Format("UPDATE Fund_Company SET [CompanyName] = '{0}' WHERE ID={1} ", FC.CompanyName,FC.Id);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Insert(Fund_Company FC)
        {
            string sql = string.Format("INSERT INTO Fund_Company (CompanyName) VALUES ('{0}')",FC.CompanyName);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public IList<Fund_Company> GetData()
        {
            string sql = string.Format("select * from Fund_Company");
            return SqlProcessing<Fund_Company>.ExeQuerys(sql);
        }
        public IList<Fund_Company> GetData(int pageSize, int pageIndex, ref int pageNum,
                                            ref int TotalPages,string Where,string OrderBy)
        {
            string sql = "select * from Fund_Company";
            if (!string.IsNullOrWhiteSpace(Where))
                sql = sql + " " + Where;
            if (!string.IsNullOrWhiteSpace(OrderBy))
                sql = sql + " " + OrderBy;
            return SqlProcessing<Fund_Company>.Paging(sql, pageSize, pageIndex,ref pageNum,ref TotalPages);
        }
        public int GetCount()
        {
            string Sql = "SELECT COUNT(*) FROM Fund_Company";
            return int.Parse(SqlProcessing.ExeQuery(Sql).Rows[0][0].ToString());
        }
    }
}
