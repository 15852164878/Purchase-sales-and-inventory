using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbUtility;
using System.Data;
using System.Data.SqlClient;
namespace Purchase_and_sale
{
    class Class5  ///进货
    {
        public void xg( string spbh, string jhr, string jhsl, string jhjg, string jhsj, string cjbh)
        {
            string sql = "UPDATE Purchase SET spbh='"+spbh+"', jhr='"+jhr+"', jhsl='"+jhsl+"', jhjg='"+jhjg+"', jhsj='"+jhsj+"',cjbh='"+cjbh"' WHERE spbh='"+spbh+"';
            SqlHelp.ExecuteSql(sql);
        }
        public void tj(string bh, string mc, string lx, string jg, string jhr, string jhsl, string jhjg, string jhsj, string cjbh)
        {
            string sql = "INSERT INTO Purchases ([spbh],[spmc],[splx],[spjg],[jhr],[jhsl],[jhjg],[jhsj],[cjbh]) VALUES ('"+bh+"','"+mc+"','"+lx+"','"+jg+"','"+jhr+"','"+jhsl+"','"+jhjg+"','"+jhsj+"','"+cjbh+"')";
            SqlHelp.ExecuteSql(sql);
      }
        public DataTable ssxs()
        {
            DataTable B = SqlHelp.Query("select * from Purchases").Tables[0];
            return B;
        }

    }
}
