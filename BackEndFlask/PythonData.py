import pymssql
def DownloadPath(BoilerID):
    Path=""
    server="sql8003.site4now.net"
    user="db_a8793c_boilerdb_admin"
    password="Sujit123"
    myconn = pymssql.connect(server,user,password,"db_a8793c_boilerdb")
    cursor = myconn.cursor()
    sql = "SELECT * FROM TblBoilerLookUp WHERE BoilerID=%s"
    cursor.execute(sql,BoilerID)
    for row in cursor.fetchall():
        Path=row[2]
    
    
    return Path

