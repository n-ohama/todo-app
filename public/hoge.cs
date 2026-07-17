private void TransferProviderStatus(DbSession dmff_session, DbSession pcmdb_session)
{
  StringBuilder sql = new StringBuilder();
  sql.Append("SELECT KJNO, HOMON_ARG_NO, STATUS FROM HMN_PCDAT P ");
  sql.Append("WHERE HOMON_WSH_BI >= " + DateTime.Today.ToString("yyyyMMdd"));
  sql.Append("AND HOMON_ARG_NO = (SELECT MAX(HOMON_ARG_NO) FROM HMN_PCDAT S WHERE S.KJNO = P.KJNO) ");
  sql.Append("AND STATUS < 5 ");
  // HMN_PCDATはKJNOとHOMON_ARG_NOがPK
  DataTable dt = dmff_session.ExecuteQuery(sql.ToString());

  foreach (DataRow row in dt.Rows)
  {
    int _status = Convert.ToInt32(row["STATUS"]);
    String _kjno = row["KJNO"].ToString();
    String _arg_no = row["HOMON_ARG_NO"].ToString();
    sql.Clear();
    sql.Append("SELECT PC_COD FROM PCDAT WITH(NOLOCK) ");
    sql.Append("WHERE KJNO = " + _kjno);
    // PCDATはKJNOがPK
    DataTable pcmdb_dt = pcmdb_session.ExecuteQuery(sql.ToString());
    if (pcmdb_dt.Rows.Count > 0)
    {
      String pc_cod = pcmdb_dt.Rows[0]["PC_COD"];
      sql.Clear();
      if (_status != 3 && pc_cod == "0402")
      {
        sql.Append("UPDATE HMN_PCDAT SET STATUS = 3 ");
        sql.Append("WHERE KJNO = " + _kjno);
        sql.Append("AND HOMON_ARG_NO = " + _arg_no);
        dmff_session.ExecuteQuery(sql.ToString());
      }
      else if (pc_cod == "3602" || pc_cod == "3604")
      {
        sql.Append("UPDATE HMN_PCDAT SET STATUS = 6 ");
        sql.Append("WHERE KJNO = " + _kjno);
        sql.Append("AND HOMON_ARG_NO = " + _arg_no);
        dmff_session.ExecuteQuery(sql.ToString());
      }
    }
  }
}
