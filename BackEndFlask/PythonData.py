import pymssql
def DownloadPath(BoilerID):
    Path=""
    server="localhost"
    user=""
    password=""
    myconn = pymssql.connect(server,user,password,"DB")
    cursor = myconn.cursor()
    sql = "SELECT * FROM TblBoilerLookUp WHERE BoilerID=%s"
    cursor.execute(sql,BoilerID)
    for row in cursor.fetchall():
        Path=row[2]
    
    
    return Path

